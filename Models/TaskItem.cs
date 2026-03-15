using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [RegularExpression("Pending|In Progress|Completed", ErrorMessage = "Status must be Pending, In Progress, or Completed")]
        public string Status { get; set; }
    }
}