using System.ComponentModel.DataAnnotations;

namespace CostManagementAPI.Models
{
    public class Editor
    {   
        [Key]
        public int EditorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}