using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Models
{

    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public string Priority { get; set; }
    }
}

