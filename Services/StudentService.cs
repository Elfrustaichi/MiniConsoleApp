using MiniConsoleAppProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleAppProject.Services
{
    internal class StudentService:IStudenService
    {
        Group group = new Group();

        public  void Create(string name, string surname, int avarage)
        {
            Student student = new Student(); 

                student.Name = name;

            student.Surname = surname;
            student.Avarage = avarage;
        
            Array.Resize(ref group.Students, group.Students.Length + 1);

            group.Students[group.Students.Length-1] = student;

           
            
            
        }

        public  void Delete(int id)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id==id)
                {
                    group.Students[i] = group.Students[group.Students.Length - 1];
                    Array.Resize(ref group.Students,group.Students.Length -1);
                }
                else
                {
                    Console.WriteLine("There is no such Student.");
                }
            }

        }


        

        public void Edit(int id, string name, string surname,int avarage)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id==id)
                {
                    group.Students[i].Name = name;
                    group.Students[i].Surname = surname;
                    group.Students[i].Avarage= avarage;
                }
                else
                {
                    Console.WriteLine("There is no such Student.");
                }


            }
        }

        public void GetAll()
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                Console.WriteLine(group.Students[i].Name+" " + group.Students[i].Surname+ " " + group.Students[i].Avarage);
                
            }
        }

        public void GetById(int id)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id==id)
                {
                    Console.WriteLine(group.Students[i].Name + " " + group.Students[i].Surname + " " + group.Students[i].Avarage);
                }
                else
                {
                    Console.WriteLine("There is no such Student.");
                }
            }
        }
    }
}
