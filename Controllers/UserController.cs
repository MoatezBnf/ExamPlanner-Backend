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
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
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
                if (User.IsInRole("SuperAdmin") || (User.IsInRole("Director") && !roles.Contains("SuperAdmin") && !roles.Contains("Director")))
                {
                    userModelList.Add(new UserModel
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Email = user.Email,
                        Role = roles.FirstOrDefault()
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

            var userModel = new UserModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Role = roles.FirstOrDefault()
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

            var user = new IdentityUser
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
