using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleAppProject.Models
{
    internal class Student
    {
        public static int _id;
        public  string? _name;
        protected string? _surname;
        protected int _avarage;


        public Student()
            {
            _id++;
            }

      

        public string Name { get 
            { 
                return _name;
            } 
            set
            {
                
                
                    if (value.Length > 3 && value.Length < 15 && string.IsNullOrWhiteSpace(value) == false)
                    {
                        _name = value;
                    }
                    else
                    {
                        Console.WriteLine("Name must contain at least 3 letter or must have less than 15 letters.");
                        
                    }

                
               
            }
        }

        public string Surname { get 
            {
                return _surname;
            } 
            set
            {
                if (value.Length > 3 && value.Length < 15 && string.IsNullOrWhiteSpace(value) == false)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Surname must contain at least 3 letter or must have less than 15 letters.");
                }
            } 
        }

        public int Avarage 
        { 
            get 
            {
                return _avarage;
            } 
            set 
            {
                if (value>0&&value<100)
                {
                    _avarage = value;
                }
            }
        
        }    
   
    
    
    
    }
}
