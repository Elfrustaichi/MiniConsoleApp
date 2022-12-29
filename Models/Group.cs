using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleAppProject.Models
{
    internal class Group
    {
        private int _id;
        public int Id { get; set; }

        public string? Name { get; set; }

        public Student[] Students = { };
        
        public Group()
        {
            _id++;
            Id++;
        }

     
    }
}
