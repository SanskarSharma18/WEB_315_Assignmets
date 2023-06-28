using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuestItems.Data;


namespace QuestItems.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QuestItemsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<QuestItemsContext>>()))
            {
                // Look for any movies.
                if (context.QuestItems.Any())
                {
                    return;   // DB has been seeded
                }

                    // Add data of QuestItems 
{
        context.QuestItems.AddRange(
            new QuestItems { Name = "John Doe", Age = 25, Location = "New York" },
            new QuestItems { Name = "Jane Smith", Age = 30, Location = "London" }
            // Add additional seed data here
        );
        
        context.SaveChanges();
    }
            }
    }
    }
}