using System;
using System.ComponentModel.DataAnnotations;

namespace Mummies.Models
{
	public class BurialData
	{
		[Key]
        public long id { get; set; }
		public string ?squarenorthsouth { get; set; }

        
	}
}

