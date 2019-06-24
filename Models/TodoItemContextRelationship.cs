namespace Index.txt.Models
{
    public class TodoItemContextRelationship
    {
        public int Id { get; set; }
        public TodoItem TodoItem;
        public Context Context;
    }
}