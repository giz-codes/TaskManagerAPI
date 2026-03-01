using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;
namespace TaskManagerAPI.Services;

public class TaskService : ITaskService
{
    private readonly AppDbContext _context;

    public TaskService(AppDbContext context)
    {
        _context = context;
    }

    public List<TaskResponseDTO> GetAllTasks()
    {
        
        return _context.Tasks.Select(task => new TaskResponseDTO
        {
            Title = task.Title,
            IsCompleted = task.IsCompleted
        }).ToList();
    }

    public void AddTask(string title)
    {
        var newTask = new TodoTask
        {
            Title = title,
            IsCompleted = false,
            CreatedDate = DateTime.Now,
            SecretNote = "Bu sistem notudur, kullanıcı görmemeli!" 
        };
        _context.Tasks.Add(newTask);
        _context.SaveChanges();
    }
}