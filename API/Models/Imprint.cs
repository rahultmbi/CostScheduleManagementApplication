using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CostManagementAPI.Models
{
    public class Imprint
    {
         [Key]
         public int ImprintId { get; set; }
         public int? ContriutorId { get; set; }
         public int? EditorId { get; set; }
         public string Type { get; set; }
         public string ISBN { get; set; }
    }
}