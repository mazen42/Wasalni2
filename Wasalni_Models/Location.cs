using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasalni_Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Governorate { get; set; }
        public string Area { get; set; }
    }
}
