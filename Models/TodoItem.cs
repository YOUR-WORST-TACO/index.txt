using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Index.txt.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public bool Complete { get; set; }
        public char Priority { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public string Description { get; set; }
        
        public IList<TodoItemProject> TodoItemProjects { get; set; }
        public IList<TodoItemContext> TodoItemContexts { get; set; }
        public IList<TodoItemKeyValue> TodoItemKeyValues { get; set; }
        
        //public List<TodoItemProjects> TodoItemProjectRelationships;
        //public List<TodoItemContexts> TodoItemContextRelationships;
        //public List<TodoItemKeyValues> TodoItemKeyValueRelationships;
    }
}