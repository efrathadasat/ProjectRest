using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRest.Models
{
    public class City
    {
        [Key]
        public int IdCity { get; set; }
        public string NameCity { get; set; }
    }
}
