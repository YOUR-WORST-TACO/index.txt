using System.Collections.Generic;

namespace Index.txt.Models
{
    public class Context
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        
        public IList<TodoItemContext> TodoItemContexts { get; set; }
    }
}