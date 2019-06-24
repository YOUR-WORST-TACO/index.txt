namespace Index.txt.Models
{
    public class TodoItemKeyValueRelationship
    {
        public int Id { get; set; }
        public TodoItem TodoItem;
        public KeyValue KeyValue;
    }
}