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
            new TodoItem() { Name = "Cukor", Done = true },
            new TodoItem() { Name = "Só", Done = false },
            new TodoItem() { Name = "Kávé", Done = false },
            new TodoItem() { Name = "Dió", Done = true }
        };

    }
}