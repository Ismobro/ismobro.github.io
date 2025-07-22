namespace FocusNest.Components.Pages.Models

{
    public class TaskItem
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        // string? FocusLevel { get; set; }  // e.g., "low", "medium", "high"
        public bool IsDone { get; set; } = false;
        public List<string> Subtasks { get; set; } = new();

        public enum FocusLevels
        {
            Low, Medium, High
        }

        public FocusLevels FocusLevel { get; set; }


    }



}
