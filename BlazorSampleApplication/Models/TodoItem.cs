namespace BlazorSampleApplication.Models
{
    public class TodoItem
    {
        // The line 'new Guid().ToString()' creates a Guid with all zeros (00000000-0000-0000-0000-000000000000).
        // To generate a unique Guid, use Guid.NewGuid().ToString() instead.

        public TodoItem()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string? Title { get; set; }
        public bool? IsDone { get; set; } = false;
    }
}
