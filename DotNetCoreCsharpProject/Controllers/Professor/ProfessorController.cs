using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotNetCoreCsharpProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace DotNetCoreCsharpProject.Controllers.Professor
{
    [Authorize(Roles = "PROFESSOR")]
    public class ProfessorController : Controller
    {
        readonly DataContext _context;
        readonly UserManager<IdentityUser> _userManager;
        Professors professor;
        IHttpContextAccessor _httpContextAccessor;
        public ProfessorController(DataContext context, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            ClaimsPrincipal currentuser = this.User;
            //.Identity.IsAuthenticated
            var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            //var userId = _userManager.GetUserId(currentuser);
            professor = _context.Professors.Include(std => std.IdUserNavigation).Where(std => std.IdUser == userId).FirstOrDefault();
        }


        // GET: Professor
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Groupes.Include(g => g.IdSocieteNavigation).Include(g => g.IdprofNavigation).Include(g => g.Reports).Where(g => g.Idprof == professor.Id);
            return View(await dataContext.ToListAsync());
        }

        // GET: Professor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupes = await _context.Groupes
                .Include(g => g.IdSocieteNavigation)
                .Include(g => g.IdprofNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (groupes == null)
            {
                return NotFound();
            }

            return View(groupes);
        }



        [HttpPost]
        public async Task<IActionResult> addNotes(string[] note)
        {
            var dataContext = _context.Groupes.Where(g => g.Idprof == professor.Id);
            int i = 0;
            foreach(var g in dataContext)
            {
                if(note[i] != null)
                {
                    double gnote = Convert.ToDouble(note[i]);
                    g.Note = gnote;
                    i++;
                }
            }
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
