using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using QuestItems.Models;

// create databse context class

namespace QuestItems.Data
{
    public class QuestItemsContext : DbContext
    {
        public QuestItemsContext(DbContextOptions<QuestItemsContext> options)
            : base(options)
        {
        }
        public DbSet<QuestItems.Models.QuestItems> QuestItems { get; set; }
    }
}
