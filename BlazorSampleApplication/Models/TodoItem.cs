namespace BlazorSampleApplication.Models
{
    public class TodoItem
    {
        public TodoItem()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
