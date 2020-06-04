using DotNetCoreCsharpProject.Entities;
using DotNetCoreCsharpProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCsharpProject.ViewComponents
{
    
    public class ListePfeInfoViewComponent: ViewComponent
    {
        private readonly DataContext _dataContext;

        public ListePfeInfoViewComponent(DataContext dataContext)
        {
            _dataContext = dataContext;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Filieres filInfo = _dataContext.Filieres.Where(s => s.NomFiliere.Equals("informatique")).FirstOrDefault();
            List<GroupsModel> grpsModel = new List<GroupsModel>();

            

            if (filInfo != null)
            {
                List<Groupes> grps = _dataContext.Groupes.Where(g => g.Students.FirstOrDefault().IdFil == filInfo.IdFiliere).ToList();

                GroupsModel testModel;
                foreach (Groupes grp in grps)
                {

                    List<AspNetUsers> student = (from s in _dataContext.Students
                                                 join u in _dataContext.AspNetUsers
                                                 on s.IdUser equals u.Id
                                                 where (s.GroupId == grp.Id)

                                                 select u).ToList();

                    testModel = new GroupsModel();
                    testModel.id = grp.Id;
                    testModel.sujet = grp.Sujet;
                    testModel.students = student;
                    Societes societe = _dataContext.Societes.Where(s => grp.IdSociete == s.Id).FirstOrDefault();
                    if (societe != null)
                    {
                        testModel.ville = societe.Ville;
                    }
                    Professors professor = _dataContext.Professors.Where(s => grp.Idprof == s.Id).FirstOrDefault();
                    if (professor != null)
                    {
                        testModel.encadrant = _dataContext.AspNetUsers.Where(s => s.Id == professor.IdUser).FirstOrDefault();
                    }
                    grpsModel.Add(testModel);
                }
            }
         
            return View(grpsModel);
        }
    }
}
