using System.ComponentModel.DataAnnotations;

namespace CostManagementAPI.Models
{
    public class ScheduleTemplates
    {
        [Key]
        public int ScheduleTemplateId { get; set; }
        public string TemplateName { get; set; }
         public string DateRange { get; set; }
        
    }
}