using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Wasalni_Models
{
    public class Bus
    {
        public int Id { get; set; }
        [Required]
        [Range(1,14)]
        public string PlateNumber { get; set; }
        [Range(1,14)]
        [Required]
        public int Capacity { get; set; }
        public DriverProfile DiverProfile { get; set; }
        public List<BusTrip> BusTrips { get; set; } = new List<BusTrip>();
    }
}
