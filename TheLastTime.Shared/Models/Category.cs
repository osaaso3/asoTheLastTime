using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TheLastTime.Shared.Pages;

namespace TheLastTime.Shared.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Description { get; set; } = "Model";

        [Required]
        public string Color { get; set; } = string.Empty;

        [Required]
        public string Icon { get; set; } = string.Empty;

        public List<Habit> HabitList = new List<Habit>();

        [Required]
        public int ModelNumber { get; set; } = 5;
        [Required]
        public int TrialNumber { get; set; } = 20;
    }
}
