using System.Collections.Generic;
using Sprint.Core;

namespace Sprint.Data
{
    public interface ITaskData
    {
        Task GetById(int id);
        public IEnumerable<Task> GetAllTasks();
    }
}
