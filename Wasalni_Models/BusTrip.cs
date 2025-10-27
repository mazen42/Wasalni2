using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasalni_Models
{
    public class BusTrip
    {
        [Key]
        public int Id { get; set; }
        public int? BusId { get; set; }
        public Bus Bus {  get; set; }
        public List<Passenger> Passengers { get; set; } = new List<Passenger>();
        public double? Salary { get; set; }
        [ForeignKey(nameof(RoutePlanId))]
        public RoutePlan RoutePlan { get; set; }
        public int? RoutePlanId { get; set; }
        public DateOnly? StartDate {  get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsOptimized { get; set; } = false; // Ai Place it 
        public bool IsConfirmed { get; set; } = false; // After Paying
        public double? FairPrice { get; set; } 
        public double? Price { get; set; }
        public bool IsDone { get; set; } = false;
        public bool IsCompleted() => this.Passengers.Count == 14;

    }
}
