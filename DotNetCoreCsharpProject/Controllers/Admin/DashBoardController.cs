using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreCsharpProject.Entities;
using DotNetCoreCsharpProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreCsharpProject.Controllers.Admin
{
    [Authorize(Roles = "ADMIN,PROFESSOR")]
    public class DashBoardController : Controller
    {
        private readonly DataContext _dataContext;

        public DashBoardController(DataContext dataContext)
        {
            _dataContext = dataContext;
            
        }
        public IActionResult Index(UsersTabViewModel vm)
        {
            PlanningDates planning = _dataContext.PlanningDates.FirstOrDefault();
            if (planning == null)
            {
                planning = new PlanningDates();
                planning.PlanningSoutenanceFile = "";
                _dataContext.PlanningDates.Add(planning);
                _dataContext.SaveChanges();
            }

            ViewBag.PlanningSoutenanceFile = planning.PlanningSoutenanceFile;

            if (vm == null)
            {
                vm = new UsersTabViewModel { ActiveTab = Tab.Calendrier };
            }
            return View(vm);
        }
        public IActionResult SwitchToTabs(string tabname)
        {


            var vm = new UsersTabViewModel();
            switch (tabname)
            {
                case "Calendrier":
                    vm.ActiveTab = Tab.Calendrier;
                    break;
                case "ListePfeInfo":
                    vm.ActiveTab = Tab.ListePfeInfo;
                    break;
                case "ListePfeGtr":
                    vm.ActiveTab = Tab.ListePfeGtr;
                    break;
                case "PlanningSout":
                    vm.ActiveTab = Tab.PlanningSout;
                    break;
                default:
                    vm.ActiveTab = Tab.Calendrier;
                    break;
            }
            return RedirectToAction(nameof(DashBoardController.Index), vm);
        }
    }
}