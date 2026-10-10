using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManagementAPI.Model;
using TaskManagementAPI.services;


namespace TaskManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly Itaskservices _task;
        public TaskController(Itaskservices task)
        {
            _task=task;
        }
        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok(_task.GetTasks());
        }
        [HttpGet("{id}")]
        public IActionResult gettaskbyID(int id)
        {
            var task = _task.gettaskbyID(id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }
        [HttpPost]
public IActionResult CreateTask(taskmodel task)
{
    var createdTask = _task.createtask(task);
    return Ok(createdTask);
}
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, taskmodel updatedTask)
        {
            var task = _task.updatetask(id, updatedTask);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = _task.deletetask(id);

            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }
    }
}