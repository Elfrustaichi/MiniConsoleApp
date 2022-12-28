using MiniConsoleAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleAppProject.Services
{
    internal class StudentService:Group
    {
     

        public static void Create(string name, string surname) 
        {
            Student student= new Student();
            
            student.Name = name;
            
            student.Surname = surname;

           
            
            
        }

        public static void Delete(int id)
        {

        }




    }
}
