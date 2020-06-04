using DotNetCoreCsharpProject.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCsharpProject.ViewComponents
{
    public class CalendrierViewComponent: ViewComponent
    {
        private readonly DataContext _dataContext;

        public CalendrierViewComponent(DataContext dataContext)
        {
            _dataContext = dataContext;

        }
        public Task<IViewComponentResult> InvokeAsync()
        {
            PlanningDates planning = _dataContext.PlanningDates.FirstOrDefault();
            if (planning == null)
            {
                planning = new PlanningDates();
                planning.PlanningSoutenanceFile = "";
                _dataContext.PlanningDates.Add(planning);
                _dataContext.SaveChanges();
            }

           


            return Task.FromResult<IViewComponentResult>(View(planning));
        }

    }
}
