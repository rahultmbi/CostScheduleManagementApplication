using System.ComponentModel.DataAnnotations;

namespace CostManagementAPI.Models
{
    public class RoyaltyTemplate
    {
        [Key]
        public int Id { get; set; }
        public string RoyaltyTemplateName { get; set; }
        public string RoyaltyType { get; set; }
    }
}   