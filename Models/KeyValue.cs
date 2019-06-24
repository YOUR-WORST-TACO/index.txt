using System.Collections.Generic;

namespace Index.txt.Models
{
    public class KeyValue
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        
        public List<TodoItemKeyValueRelationship> TodoItemKeyValueRelationships;
    }
}