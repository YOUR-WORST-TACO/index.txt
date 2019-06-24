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
        [Required] public string Description;
        
        public List<TodoItemProjectRelationship> TodoItemProjectRelationships;
        public List<TodoItemContextRelationship> TodoItemContextRelationships;
        public List<TodoItemKeyValueRelationship> TodoItemKeyValueRelationships;
    }
}