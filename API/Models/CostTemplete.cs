using System.ComponentModel.DataAnnotations;

namespace CostManagementAPI.Models
{
    public class CostTemplete
    {
        [Key]
        public int CostTempleteId { get; set; }
        public string CostTemplateName { get; set; }
         public int? ImprintId { get; set; }
         public int? RoyaltyTemplateId{ get; set; }
         public int? SalesTemplateId{ get; set; }
    }
}