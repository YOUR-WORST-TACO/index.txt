using System.Collections.Generic;

namespace Index.txt.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        
        public List<TodoItemProjectRelationship> TodoItemProjectRelationships;
    }
}