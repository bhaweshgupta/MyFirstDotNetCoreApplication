using System;
using System.Collections.Generic;

namespace MyFirstDotNetCoreApplication.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
    }
}
