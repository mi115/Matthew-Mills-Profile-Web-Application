using Matthew_Mills_Profile_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matthew_Mills_Profile_Project.Models
{
    public class SeedData
    {

    public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectsContext(serviceProvider.GetRequiredService<DbContextOptions<ProjectsContext>>()))
            {
                if (context.Project.Any())
                {
                    return;
                }

                context.Project.AddRange(

                    new Project
                    {
                        ProjectName = "monthly_summary_download",
                        Description = "A day to day tracker used in my current work. It pulls together details on live traffic projects from multiple contexts within the company.",
                        LastModified = DateTime.Parse("2019-11-24"),
                        Status = "Complete",
                        GitLink = "Not Available"
                    },

                    new Project
                    {
                        ProjectName = "Web_App_Test",
                        Description = "A PyPi Clone using Flask as a framework",
                        LastModified = DateTime.Parse("2019-11-17"),
                        Status = "Complete",
                        GitLink = "Not Available"
                    },

                    new Project
                    {
                        ProjectName = "CDL-Reporter",
                        Description = "A small app that summarises our monthly usage of a Vehicle Classification API. It then sends a graphical representation of this data, in an email, to relevent parties.",
                        LastModified = DateTime.Parse("2019-10-07"),
                        Status = "Complete",
                        GitLink = "Not Available"
                    },

                    new Project
                    {
                        ProjectName = "Speed_Calc",
                        Description = "A set of data processing algorithms to interpret raw ANPR data in-hand with specific site details. Utilising a Google Maps Api it calculates the distance between sites and from that calculates average speed per record. Finally this is presented in a client friendly Excel Format.",
                        LastModified = DateTime.Parse("2019-09-27"),
                        Status = "Work-In-Progress",
                        GitLink = "Not Available"
                    },

                    new Project
                    {
                        ProjectName = "pc_metric_workhorse",
                        Description = "A small reporting app to present timesheet, budget and project scope information to inform revised metrics.",
                        LastModified = DateTime.Parse("2019-09-27"),
                        Status = "Work-In-Progress",
                        GitLink = "Not Available"
                    },

                    new Project
                    {
                        ProjectName = "Project_Details_Updater",
                        Description = "A small app to update project tracking information in our MySQL database.",
                        LastModified = DateTime.Parse("2019-08-19"),
                        Status = "Complete",
                        GitLink = "Not Available"
                    }
                );
                context.SaveChanges();



            }
        }
    }
}
