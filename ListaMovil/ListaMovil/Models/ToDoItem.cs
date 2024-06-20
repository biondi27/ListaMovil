using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaMovil.Models
{
    public class ToDoItem
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
