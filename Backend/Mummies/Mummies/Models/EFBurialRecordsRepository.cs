using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mummies.Models
{
    public class EFBurialRecordsRepository : IBurialRecordsRepository
    {

        private Mummies_databaseContext context { get; set; }

        public EFBurialRecordsRepository (Mummies_databaseContext temp)
        {
            context = temp;
        }


        public IQueryable<Burialmain> burialInfo => context.Burialmains;
    }
}

