using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Services;

namespace TaskManagerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TasksController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]
    public IActionResult GetTasks()
    {
        return Ok(_taskService.GetAllTasks());
    }

    [HttpPost]
    public IActionResult CreateTask([FromBody] string title)
    {
        _taskService.AddTask(title);
        return Ok("Görev başarıyla eklendi!");
    }
}
