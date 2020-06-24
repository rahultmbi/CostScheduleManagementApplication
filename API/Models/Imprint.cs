using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CostManagementAPI.Models
{
    public class Imprint
    {
         [Key]
         public int ImprintId { get; set; }
         public int? ContriutorId { get; set; }
         public string ContriutorName { get; set; } //AuthorNAme
         public string Title { get; set; } //title
         public string EditorName { get; set; }  //EditorName
         public string CoverType { get; set; } // Meterial Type
         public int? EditorId { get; set; }
         public int? MaterialId { get; set; } 
         public string Type { get; set; } // EdittionType
         public string ISBN { get; set; } //123456789X
    }
}