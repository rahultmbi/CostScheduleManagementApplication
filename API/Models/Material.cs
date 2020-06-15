using System.ComponentModel.DataAnnotations;

namespace CostManagementAPI.Models
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        public string CoverType { get; set; }
    }
}