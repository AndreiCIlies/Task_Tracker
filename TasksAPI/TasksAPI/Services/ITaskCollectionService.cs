using TasksAPI.Models;

namespace TasksAPI.Services
{
    public interface ITaskCollectionService : ICollectionService<Models.TaskModel>
    {
        Task<List<TaskModel>> GetTasksByStatus(string status);
    }
}
