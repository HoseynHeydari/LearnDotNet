using System.Collections.Generic;
using System.Linq;
using Sprint.Core;

namespace Sprint.Data
{
    public class InMemoryTaskData : ITaskData
    {
        List<Task> tasks;
        public InMemoryTaskData()
        {
            tasks = new List<Task>
            {
                new Task { Id = 1, Name = "Clean Code", Percent = Percentage.ZERO },
                new Task { Id = 2, Name = "Dirty Code", Percent = Percentage.ZERO },
                new Task { Id = 3, Name = "Continus Integration", Percent = Percentage.ZERO },
                new Task { Id = 4, Name = "Code Review", Percent = Percentage.ZERO },
                new Task { Id = 5, Name = "Add Feature Hi", Percent = Percentage.ZERO },
            };
        }
        public Task GetById(int id)
        {
            return tasks.SingleOrDefault(t => t.Id == id);
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return from task in tasks
                   orderby task.Name
                   select task;
        }
    }
}