using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Index.txt.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public bool Complete { get; set; }
        public char Priority { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? CreationDate { get; set; }
        [Required]
        public string Description { get; set; }
        public IdentityUser User { get; set; }
        
        public IList<KeyValue> KeyValues { get; set; }
        public IList<TodoItemProject> TodoItemProjects { get; set; }
        public IList<TodoItemContext> TodoItemContexts { get; set; }
        
    }
}