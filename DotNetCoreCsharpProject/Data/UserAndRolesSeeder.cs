using DotNetCoreCsharpProject.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCsharpProject.Data
{
    public class UserAndRolesSeeder
    {
            public static void SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, DataContext dataContext)
            {
                SeedRoles(roleManager);
                SeedUsers(userManager);
                SeedRepportType(dataContext);
                SeedFilieres(dataContext);
                SeedLevels(dataContext);
            }

            private static void SeedRepportType(DataContext dataContext)
            {
                if (dataContext.TypeReports.Where(r => r.Type == "PFE").FirstOrDefault() == null)
                {
                TypeReports typeReports = new TypeReports();
                typeReports.Type = "PFE";
                dataContext.TypeReports.Add(typeReports);
                dataContext.SaveChanges();
                }
                if (dataContext.TypeReports.Where(r => r.Type == "STAGE").FirstOrDefault() == null)
                {
                    TypeReports typeReports = new TypeReports();
                    typeReports.Type = "STAGE";
                    dataContext.TypeReports.Add(typeReports);
                    dataContext.SaveChanges();
                }
            if (dataContext.TypeReports.Where(r => r.Type == "PFA").FirstOrDefault() == null)
            {
                TypeReports typeReports = new TypeReports();
                typeReports.Type = "PFA";
                dataContext.TypeReports.Add(typeReports);
                dataContext.SaveChanges();
            }
        }
            
            private static void SeedFilieres(DataContext dataContext)
        {
            if (dataContext.Filieres.Where(s => s.NomFiliere.Equals("informatique")).FirstOrDefault() == null)
            {
                Filieres filieres = new Filieres();
                filieres.NomFiliere = "informatique";
                dataContext.Filieres.Add(filieres);
                dataContext.SaveChanges();
            }
            if (dataContext.Filieres.Where(s => s.NomFiliere.Equals("Génie télécommunication et reseaux")).FirstOrDefault() == null)
            {
                Filieres filieres = new Filieres();
                filieres.NomFiliere = "Génie télécommunication et reseaux";
                dataContext.Filieres.Add(filieres);
                dataContext.SaveChanges();
            }
        }

        private static void SeedLevels(DataContext dataContext)
        {
            if (dataContext.Levels.Where(l => l.NomNiveau.Equals("1erAnnee")).FirstOrDefault() == null)
            {
                Levels level = new Levels();
                level.NomNiveau = "1erAnnee";
                dataContext.Levels.Add(level);
                dataContext.SaveChanges();
            }
            if (dataContext.Levels.Where(l => l.NomNiveau.Equals("2emeAnnee")).FirstOrDefault() == null)
            {
                Levels level = new Levels();
                level.NomNiveau = "2emeAnnee";
                dataContext.Levels.Add(level);
                dataContext.SaveChanges();
            }
            if (dataContext.Levels.Where(s => s.NomNiveau.Equals("4emeAnnee")).FirstOrDefault() == null)
            {
                Levels level = new Levels();
                level.NomNiveau = "4emeAnnee";
                dataContext.Levels.Add(level);
                dataContext.SaveChanges();
            }
            if (dataContext.Levels.Where(s => s.NomNiveau.Equals("5emeAnnee")).FirstOrDefault() == null)
            {
                Levels level = new Levels();
                level.NomNiveau = "5emeAnnee";
                dataContext.Levels.Add(level);
                dataContext.SaveChanges();
            }
        }


        private static void SeedUsers(UserManager<IdentityUser> userManager)
            {
                if (userManager.FindByEmailAsync("admin@admin.com").Result == null)
                {
                IdentityUser user = new IdentityUser();

                     user.UserName = "admin@admin.com";
                     user.Email = "admin@admin.com";
                     user.EmailConfirmed = true;

                    IdentityResult result = userManager.CreateAsync(user, "Qwerty123@").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "ADMIN").Wait();
                    }
                }

            }

            private static void SeedRoles(RoleManager<IdentityRole> roleManager)
            {
                if (!roleManager.RoleExistsAsync("ADMIN").Result)
                {
                    IdentityRole role = new IdentityRole();
                    role.Name = "ADMIN";
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }


                if (!roleManager.RoleExistsAsync("STUDENT").Result)
                {
                    IdentityRole role = new IdentityRole();
                    role.Name = "STUDENT";
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }

            if (!roleManager.RoleExistsAsync("PROFESSOR").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "PROFESSOR";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }
        
    }
}
