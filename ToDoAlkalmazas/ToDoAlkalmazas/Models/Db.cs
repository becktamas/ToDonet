using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoAlkalmazas.Models
{
    public class Db : DbContext 
    {
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}