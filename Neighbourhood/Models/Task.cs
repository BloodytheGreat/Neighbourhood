using System.ComponentModel.DataAnnotations;


namespace Neighbourhood.Models
{
    public class Task
    {
        [Key]
        public int task_id { get; set; }
        [Required]
        [Display(Name = "Write down your task")]
        public string task_des { get; set; }

        public int upvotes { get; set; }

        public int downvotes { get; set; }
    }
}