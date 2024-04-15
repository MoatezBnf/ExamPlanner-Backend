using ExamPlanner_Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamPlanner_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ExamPlannerDbContext _context;

        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
            ExamPlannerDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        // GET: api/get-all-users
        [HttpGet("get-all-users")]
        [Authorize(Roles = "SuperAdmin,Director")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            var userModelList = new List<UserModel>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var departmentIds = _context.UserDepartments
                    .Where(ud => ud.UserId == user.Id)
                    .Select(ud => ud.DepartmentId)
                    .ToList();
                if (User.IsInRole("SuperAdmin") || (User.IsInRole("Director") && !roles.Contains("SuperAdmin") && !roles.Contains("Director")))
                {
                    userModelList.Add(new UserModel
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Email = user.Email,
                        Role = roles.FirstOrDefault(),
                        DepartmentIds = departmentIds
                    });
                }
            }

            return Ok(new { message = "Success", data = userModelList });
        }

        // GET: api/get-user-by-id/{id}
        [HttpGet("get-user-by-id/{id}")]
        [Authorize(Roles = "SuperAdmin,Director")]
        public async Task<ActionResult<UserModel>> GetUserById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            var roles = await _userManager.GetRolesAsync(user);
            if (User.IsInRole("Director") && (roles.Contains("SuperAdmin") || roles.Contains("Director")))
            {
                return NotFound(new { message = "User not found" });
            }

            var departmentIds = _context.UserDepartments
                .Where(ud => ud.UserId == user.Id)
                .Select(ud => ud.DepartmentId)
                .ToList();

            var userModel = new UserModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Role = roles.FirstOrDefault(),
                DepartmentIds = departmentIds
            };

            return Ok(new { message = "Success", data = userModel });
        }

        // POST: api/create-user
        [HttpPost("create-user")]
        [Authorize(Roles = "SuperAdmin,Director")]
        public async Task<IActionResult> CreateUser(RegisterModel registerModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = "Invalid data", errors = ModelState });
            }

            if (User.IsInRole("Director") && (registerModel.Role == "SuperAdmin" || registerModel.Role == "Director"))
            {
                return BadRequest(new { message = "Director cannot create a user with SuperAdmin or Director role" });
            }

            // Check if the role exists
            var roleExists = await _roleManager.RoleExistsAsync(registerModel.Role!);
            if (!roleExists)
            {
                return BadRequest(new { message = "Role does not exist" });
            }

            var user = new ApplicationUser
            {
                UserName = registerModel.UserName,
                Email = registerModel.Email
            };

            var result = await _userManager.CreateAsync(user, registerModel.Password!);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return BadRequest(new { message = "Failed to create user", errors = ModelState });
            }

            await _userManager.AddToRoleAsync(user, registerModel.Role!);

            // Check if the departments exist
            var existingDepartmentIds = _context.Departments.Select(d => d.DepartmentId).ToList();
            var invalidDepartmentIds = registerModel.DepartmentIds?.Except(existingDepartmentIds).ToList();
            if (invalidDepartmentIds != null && invalidDepartmentIds.Any())
            {
                return BadRequest(new { message = "Invalid department IDs", invalidDepartmentIds });
            }

            foreach (var departmentId in registerModel.DepartmentIds!)
            {
                _context.UserDepartments.Add(new UserDepartment
                {
                    UserId = user.Id,
                    DepartmentId = departmentId
                });
            }
            await _context.SaveChangesAsync();

            return Ok(new { message = "User created successfully" });
        }

        // PUT: api/update-user/{id}
        [HttpPut("update-user/{id}")]
        [Authorize(Roles = "SuperAdmin,Director")]
        public async Task<IActionResult> UpdateUser(string id, UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = "Invalid data", errors = ModelState });
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            var roles = await _userManager.GetRolesAsync(user);
            if (User.IsInRole("Director") && (roles.Contains("SuperAdmin") || roles.Contains("Director")))
            {
                return BadRequest(new { message = "Cannot update SuperAdmin or Director" });
            }

            if (User.IsInRole("Director") && (userModel.Role == "SuperAdmin" || userModel.Role == "Director"))
            {
                return BadRequest(new { message = "Director cannot assign SuperAdmin or Director role" });
            }

            // Check if the role exists
            var roleExists = await _roleManager.RoleExistsAsync(userModel.Role!);
            if (!roleExists)
            {
                return BadRequest(new { message = "Role does not exist" });
            }

            user.UserName = userModel.UserName;
            user.Email = userModel.Email;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return BadRequest(new { message = "Failed to update user", errors = ModelState });
            }

            if (!roles.Contains(userModel.Role!))
            {
                await _userManager.RemoveFromRolesAsync(user, roles);
                await _userManager.AddToRoleAsync(user, userModel.Role!);
            }

            var existingUserDepartments = _context.UserDepartments
                .Where(ud => ud.UserId == user.Id);
            _context.UserDepartments.RemoveRange(existingUserDepartments);

            // Check if the departments exist
            var existingDepartmentIds = _context.Departments.Select(d => d.DepartmentId).ToList();
            var invalidDepartmentIds = userModel.DepartmentIds?.Except(existingDepartmentIds).ToList();
            if (invalidDepartmentIds != null && invalidDepartmentIds.Any())
            {
                return BadRequest(new { message = "Invalid department IDs", invalidDepartmentIds });
            }

            foreach (var departmentId in userModel.DepartmentIds!)
            {
                _context.UserDepartments.Add(new UserDepartment
                {
                    UserId = user.Id,
                    DepartmentId = departmentId
                });
            }
            await _context.SaveChangesAsync();

            return Ok(new { message = "User updated successfully" });
        }

        // DELETE: api/delete-user/{id}
        [HttpDelete("delete-user/{id}")]
        [Authorize(Roles = "SuperAdmin,Director")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            var roles = await _userManager.GetRolesAsync(user);
            if (User.IsInRole("Director") && (roles.Contains("SuperAdmin") || roles.Contains("Director")))
            {
                return BadRequest(new { message = "Cannot delete SuperAdmin or Director" });
            }

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return BadRequest(new { message = "Failed to delete user", errors = ModelState });
            }

            return Ok(new { message = "User deleted successfully" });
        }
    }
}
