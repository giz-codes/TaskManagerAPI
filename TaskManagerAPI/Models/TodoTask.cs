namespace TaskManagerAPI.Models;

public class TodoTask
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public required string SecretNote { get; set; }
}