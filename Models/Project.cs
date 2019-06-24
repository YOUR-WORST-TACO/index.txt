using System.Collections.Generic;

namespace Index.txt.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        
        public IList<TodoItemProjects> TodoItemProjects { get; set; }
    }
}