using ExamPlanner_Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ExamPlanner_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ExamPlannerDbContext _context;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, IConfiguration configuration,
            RoleManager<IdentityRole> roleManager, ExamPlannerDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _roleManager = roleManager;
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            // Check if the role exists
            var roleExists = await _roleManager.RoleExistsAsync(model.Role!);
            if (!roleExists)
            {
                return BadRequest("Role does not exist");
            }

            // Check if the user exists
            var userExists = await _userManager.FindByEmailAsync(model.Email!);
            if (userExists != null)
            {
                return BadRequest("User with this email already exists");
            }

            // Check if the departments exist
            if (model.DepartmentIds == null)
            {
                return BadRequest("Department IDs are required");
            }
            var departmentsExist = await _context.Departments.Where(d => model.DepartmentIds.Contains(d.DepartmentId)).ToListAsync();
            if (departmentsExist.Count != model.DepartmentIds.Count)
            {
                return BadRequest("One or more departments do not exist");
            }

            //Add the user in the database
            var user = new ApplicationUser { UserName = model.UserName, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password!);
            if (!result.Succeeded)
            {
                return BadRequest("Registration failed");
            }

            if (result.Succeeded)
            {
                // Assign the user to a role
                await _userManager.AddToRoleAsync(user, model.Role!);

                // Add the user to the departments
                foreach (var departmentId in model.DepartmentIds)
                {
                    _context.UserDepartments.Add(new UserDepartment
                    {
                        UserId = user.Id,
                        DepartmentId = departmentId
                    });
                }
                await _context.SaveChangesAsync();

                return Ok("Registration successful");
            }

            return BadRequest(result.Errors);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName!);

            if (user == null)
            {
                return Unauthorized();
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password!, false);

            if (result.Succeeded)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.NameIdentifier, user.Id)

                };
                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]!));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expires = DateTime.Now.AddHours(1);

                var token = new JwtSecurityToken(
                    _configuration["JWT:ValidIssuer"],
                    _configuration["JWT:ValidAudience"],
                    claims,
                    expires: expires,
                    signingCredentials: creds
                );

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            }

            return Unauthorized();
        }
    }
}
