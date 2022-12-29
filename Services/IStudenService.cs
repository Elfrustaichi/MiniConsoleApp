using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleAppProject.Services
{
    internal interface IStudenService
    {
        public void Create(string name, string surname,int avarage);
        public  void Delete(int id);

        public void Edit(int id ,string name, string surname,int avarage);
        public void GetAll();

        public void GetById(int id);

        

       

    }
}
