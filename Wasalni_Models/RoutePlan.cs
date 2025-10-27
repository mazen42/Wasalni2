using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasalni_Models
{
    public class RoutePlan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public List<TripPoint> PickUpPoints { get; set; }
        [Required]
        public List<TripPoint> DropOffPoints { get; set; }
        [Required]
        public TimeOnly ExpectedArrivalTime {  get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
