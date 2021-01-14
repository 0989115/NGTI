using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NGTI.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using NGTI.Data;
using Microsoft.AspNetCore.Identity;

namespace NGTI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManeger;
        private readonly ApplicationDbContext _context;
        string connectionString = "Server=(localdb)\\mssqllocaldb;Database=NGTI;Trusted_Connection=True;MultipleActiveResultSets=true";


        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _userManeger = userManager;
            _context = context;
        }

        public bool bhvCheck(List<string> solos, List<string> bhvers)
        {
            bool bhv = false;
            foreach (string email in solos)
            {
                foreach (string name in bhvers)
                {
                    if (name == email)
                    {
                        bhv = true;
                    }
                }
            }
            return bhv;
        }

        public IActionResult Index()
        {
            var users = _userManeger.Users;
            List<string> bhvers = new List<string>();
            foreach(ApplicationUser user in users)
            {
                if (user.BHV)
                {
                    bhvers.Add(user.UserName);
                }
            }
            var applicationDbContext = _context.SoloReservations; //.Include(s => s.Seat)
            var solo = applicationDbContext.Where(x => x.Date == DateTime.Now.Date.AddDays(1) ).ToList();
            List<string> solos = new List<string>();

            foreach(SoloReservation sr in solo)
            {
                solos.Add(sr.Name);
            }

            bool bhv = bhvCheck(solos, bhvers);

            var model = new bhvViewModel() { bhver = bhv };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
