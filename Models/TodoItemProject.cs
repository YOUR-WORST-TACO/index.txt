namespace Index.txt.Models
{
    public class TodoItemProject
    {
        public int Id { get; set; }
        
        public int TodoItemId { get; set; }
        public TodoItem TodoItem { get; set; }
        
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}