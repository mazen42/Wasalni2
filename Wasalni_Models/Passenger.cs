using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasalni_Models
{
    public class Passenger
    {
        public int Id { get; set; }
        [Required]
        public int FromLocationId { get; set; }
        [ForeignKey(nameof(FromLocationId))]
        public Location FromLocation { get; set; }
        [Required]
        public int ToLocationId { get; set; }
        [ForeignKey(nameof(ToLocationId))]
        public Location ToLocation { get; set; }
        [Required]
        public TimeOnly ArrivalTime { get; set; }
        [Required]
        public TripType TripType { get; set; }
        public int? BusTripId { get; set; }
        public BusTrip BusTrip { get; set; }
        public bool IsPaid { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey(nameof(ApplicationUserId))]

        public ApplicationUser ApplicationUser { get; set; }
    }
}
