using Microsoft.AspNetCore.Mvc;

namespace TasksAPI
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Get all tasks");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Update a task");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Create a task");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Delete a task");
        }
    }
}
