using System.ComponentModel.DataAnnotations;

namespace CostManagementAPI.Models
{
    public class EditionType
    {
        [Key]
         public int EditionTypeId { get; set; }
         public string Type { get; set; }
    }
}