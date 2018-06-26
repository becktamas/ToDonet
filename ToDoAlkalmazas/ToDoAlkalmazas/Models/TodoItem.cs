using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoAlkalmazas.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public bool Done { get; internal set; }
    }
}