namespace TaskManagerAPI.DTOs;
public class TaskResponseDTO
{
    public required string Title { get; set; }
    public bool IsCompleted { get; set; }
}
