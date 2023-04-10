using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mummies.Models
{
    public class BurialRecordsDbContext : DbContext
    {

        public BurialRecordsDbContext(DbContextOptions<BurialRecordsDbContext> options) : base (options)
        {
        }

        public DbSet<Burialmain> BurialRecords { get; set; }
    }
}

