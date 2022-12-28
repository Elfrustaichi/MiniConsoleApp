using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleAppProject.Models
{
    internal class Group:Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static string[] Students { get; set; }

     
    }
}
