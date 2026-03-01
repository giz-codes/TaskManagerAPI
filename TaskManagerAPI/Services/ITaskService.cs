using TaskManagerAPI.DTOs;
namespace TaskManagerAPI.Services;

public interface ITaskService
{
    List<TaskResponseDTO> GetAllTasks();
    void AddTask(string title);
}
