using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoAlkalmazas.Models
{
    public class MyDb
    {
        /// <summary>
        /// Nem szép munka
        /// </summary>
        public static List<TodoItem> Lista = new List<TodoItem>
        {
            new TodoItem() { Id = 1, Name = "Cukor", Done = true },
            new TodoItem() { Id = 2, Name = "Só", Done = false },
            new TodoItem() { Id = 3, Name = "Kávé", Done = false },
            new TodoItem() { Id = 4, Name = "Dió", Done = true }
        };

    }
}