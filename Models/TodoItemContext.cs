namespace Index.txt.Models
{
    public class TodoItemContext
    {
        public int Id { get; set; }
        
        public int TodoItemId { get; set; }
        public TodoItem TodoItem { get; set; }
        
        public int ContextId { get; set; }
        public Context Context { get; set; }
    }
}