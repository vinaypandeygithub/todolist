using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public TaskStatuses Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public int StoryId { get; set; }
    }

    public enum TaskStatuses
    {
        Todo, 
        Done
    }
}
