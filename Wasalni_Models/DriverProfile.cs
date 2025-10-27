using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasalni_Models
{
    public class DriverProfile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        public string LicenseImageUrl { get; set; }
        [Required]
        public string IdCardURL { get; set; }
        [Required]
        public string VehicleType { get; set; }
        [Required]
        [ForeignKey(nameof(BusId))]
        public Bus Bus { get; set; }
        public int BusId { get; set; }
        public DateTime SubscriptionExpiryDate { get; set; }
        public bool IsSubscriptionActive => SubscriptionExpiryDate >= DateTime.UtcNow;
        [Required]
        public string VehiclePlateNumber { get; set; }
        public DriverApprovalStatus ApprovalStatus { get; set; } = DriverApprovalStatus.Pending;
    }
}
