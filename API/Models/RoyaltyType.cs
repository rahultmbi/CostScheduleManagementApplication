using System.ComponentModel.DataAnnotations;

namespace CostManagementAPI.Models
{
    public class RoyaltyType
    {
        [Key]
        public int RoyaltyTypeId { get; set; }
        public string RoyaltyName { get; set; }
        public string Type { get; set; }
    }
}