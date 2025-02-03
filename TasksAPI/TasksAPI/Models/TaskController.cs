using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Threading.Tasks;
using TasksAPI.Services;
using TasksAPI.Settings;

namespace TasksAPI.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        ITaskCollectionService _taskCollectionService;
        public TaskController(ITaskCollectionService taskCollectionService)
        {
            _taskCollectionService = taskCollectionService ?? throw new ArgumentNullException(nameof(TaskCollectionService));
        }

        [HttpGet]
        public async Task<IActionResult> GetTasks()
        {
            List<TaskModel> tasks = await _taskCollectionService.GetAll();
            return Ok(tasks);
        }

        [HttpPost("CreateTask")]
        public async Task<IActionResult> CreateTask([FromBody] TaskModel task)
        {
            task.Id = Guid.NewGuid();
            if (task == null)
            {
                return BadRequest();
            }
            if (task.Name == null || task.AssignedTo == null)
            {
                return BadRequest();
            }
            
            var newTask = await _taskCollectionService.Create(task);
            return Ok(newTask);
        }

        [HttpPut("UpdateTask/{taskid}")]
        public async Task<IActionResult> UpdateTask(string taskid, [FromBody] TaskModel task)
        {
            var updatedTask = await _taskCollectionService.Update(Guid.Parse(taskid), task);
            if (task == null)
            {
                return BadRequest();
            }
            if (task.Name == null || task.AssignedTo == null)
            {
                return BadRequest();
            }
            return Ok(updatedTask);
        }

        [HttpDelete("DeleteTask/{taskid}")]
        public async Task<IActionResult> DeleteTask(Guid taskid)
        {
            var deletedTask = await _taskCollectionService.Delete(taskid);
            return Ok(deletedTask);
        }
    }
}