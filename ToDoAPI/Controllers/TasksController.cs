using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public List<Story> GetAllStories()
        {
            List<Story> stories = new List<Story>();
            
            for (int i = 0; i < 100; i++)
            {
                List<Tasks> tasks = new List<Tasks>();
                Story story = new Story { Id = i, Description = "House Work" + i.ToString(), Status = StoryStatuses.Todo, LastUpdated = DateTime.Now, Tasks = tasks };
                tasks.Add(new Tasks() { Id = 1, Description = "Electricity Bill Payment", Status = TaskStatuses.Todo, LastUpdated = DateTime.Now, StoryId = i });
                tasks.Add(new Tasks() { Id = 2, Description = "Sainsbury Shopping", Status = TaskStatuses.Todo, LastUpdated = DateTime.Now, StoryId = i });
                stories.Add(story);                 
            }
           
            return stories;
        }
    }
}
