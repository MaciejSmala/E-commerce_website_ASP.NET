using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using N0855975_assessment2.Models;

namespace N0855975_assessment2.Pages
{
    [Authorize(Roles = "Admin")]
    public class AdminDashboardModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        public List<IdentityRole> roles { get; set; }
        public List<AppUser> users { get; set; }
        public AdminDashboardModel(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty(SupportsGet = true)]

        public string roleName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string userId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string passwordString { get; set; }
        public void OnGet()
        {
            roles = _roleManager.Roles.ToList();
            users = _userManager.Users.ToList();
        }
        public async Task<IActionResult> OnPostUpdateAsync()
        {
            var users = await _userManager.FindByIdAsync(Id);
            await _userManager.RemovePasswordAsync(users);
            await _userManager.AddPasswordAsync(users, passwordString);
            return RedirectToPage("/AdminDashboard");
        }
        public async Task<IActionResult> OnGetDeleteAsync()
        {
            var role = await _roleManager.FindByIdAsync(Id);
            await _roleManager.DeleteAsync(role);
            return RedirectToPage("/AdminDashboard");
        }
        public async Task<IActionResult> OnGetDeleteUserAsync()
        {
            var user = await _userManager.FindByIdAsync(Id);
            await _userManager.DeleteAsync(user);
            return RedirectToPage("/AdminDashboard");
        }


        public async Task<IActionResult> OnPostAsync()
        {
            await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
            return RedirectToPage("/AdminDashboard");
        }
    }
}

