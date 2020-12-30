using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Story
    {
        public int Id { get; set; }
        public StoryStatuses Status { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public List<Tasks> Tasks { get; set; }
    }

    public enum StoryStatuses
    {
        Todo,
        Done
    }
}
