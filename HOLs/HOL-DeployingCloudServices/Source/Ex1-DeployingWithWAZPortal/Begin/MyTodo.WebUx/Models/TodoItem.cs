﻿namespace MyTodo.WebUx.Models
{
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Todo item entity
    /// </summary>
    public class TodoItem
    {
        public int TodoItemId { get; set; }

        [Required]
        public string Title { get; set; }

        public bool IsDone { get; set; }

        [ForeignKey("TodoList")]
        public int TodoListId { get; set; }

        [JsonIgnore]
        public virtual TodoList TodoList { get; set; }
    }
}