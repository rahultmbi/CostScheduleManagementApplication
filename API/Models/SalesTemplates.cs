using System.ComponentModel.DataAnnotations;

namespace CostManagementAPI.Models
{
    public class SalesTemplates
    {
        [Key]
        public int SalesTemplatesId { get; set; }
        public string SalesType { get; set; }
        public string SalesTemplateName{ get; set; }
    }
}