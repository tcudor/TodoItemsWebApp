using System.ComponentModel.DataAnnotations;

namespace TodoItemsWebApp.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "Name can have a maximum of 200 characters")]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.Date)] 
        public DateTime Deadline { get; set; }

        [Range(0, 2, ErrorMessage = "Status must 0 = Pending, 1 = Done, 2 = Rejected")]
        public int Status { get; set; }

        [Display(Name = "Status")]
        public string DisplayStatus
        {
            get
            {
                switch (Status)
                {
                    case 0:
                        return "Pending";
                    case 1:
                        return "Done";
                    case 2:
                        return "Rejected";
                    default:
                        return "Unknown";
                }
            }
        }
    }
}
