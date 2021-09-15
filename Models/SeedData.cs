using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BugTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BugTrackerContext(serviceProvider.GetRequiredService<DbContextOptions<BugTrackerContext>>()))
            {

                //Look for any Bugs.
                if (!context.Bug.Any())
                {
                    context.Bug.AddRange(
                        new Bug
                        {
                            Title = "Example Bug",
                            CreationDate = DateTime.Now,
                            DueDate = DateTime.Now,
                            Status = "In Progress",
                            Assignee = "You",
                            PriorityLevel = "High",
                            Reporter = "You",
                            Summary = "Delete this bug and add your own!"
                        }
                    );
                }

                if (!context.Project.Any())
                {
                    context.Project.AddRange(
                        new Project
                        {
                            ID = 0,
                            Title = "Example Project",
                            People = "You",
                            BugIDs = 0,
                            Summary = "Delete this project and add your own!"
                        }
                        );
                }

                context.SaveChanges();
            }


        }

    }
}
