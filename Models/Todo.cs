using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwTodos.Models
{
    public class Todo
    {
        public int Id { get; set; }
        //Title must be initialized with an empty string because it is a string
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] 
        public DateOnly Deadline { get; set; }
        //FinishedAt must be initialized with null, and will later be set to a DateOnly value
        public DateOnly? FinishedAt { get; set; }
    }
}