namespace CaTinder.Models;

public class Chat
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string LastMessage { get; set; }
    public string Timestamp { get; set; }
    public string ImageName { get; set; }
}