namespace Index.txt.Models
{
    public class TodoItemKeyValues
    {
        public int Id { get; set; }
        
        public int TodoItemId { get; set; }
        public TodoItem TodoItem { get; set; }
        
        public int KeyValueId { get; set; }
        public KeyValue KeyValue { get; set; }
    }
}