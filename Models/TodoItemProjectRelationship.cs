namespace Index.txt.Models
{
    public class TodoItemProjectRelationship
    {
        public int Id { get; set; }
        public TodoItem TodoItem;
        public Project Project;
    }
}