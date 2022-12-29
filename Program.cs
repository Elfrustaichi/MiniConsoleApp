


using MiniConsoleAppProject.Models;
using MiniConsoleAppProject.Services;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
StudentService studentservice = new StudentService();
do
{
    
    bool ordercheck;
    int Order = 0;
    do
    {
        Console.WriteLine("Welcome to TeacherMine-student controlling app.");
        Console.WriteLine("Press 1--If you want to add a new student.");
        Console.WriteLine("Press 2--If you want to delete student.");
        Console.WriteLine("Press 3--If you want to edit student.");
        Console.WriteLine("Press 4--If you want to get all students.");
        Console.WriteLine("Press 5--If you want to get student by id.");
        Console.WriteLine("Press 0--If you want to exit.");
        Console.Write("Give your Order--");
        try
        {

            Order = int.Parse(Console.ReadLine());
            ordercheck = true;
            Console.Clear();
        }
        catch (Exception)
        {
            Console.Clear();
            Console.WriteLine("Wrong Order.Try Again.");
            ordercheck = false;
        }


    } while (ordercheck == false || Order < 0 || Order > 5);
    string name;
    string surname;
    int avarage;
    int id;
    switch (Order)
    {
        case 1:
            
            
            Console.Write("Enter the name of student:");
            name = Console.ReadLine();
            Console.Write("Enter the surname of student:");
            surname = Console.ReadLine();
            Console.Write("Enter the avarage of student:");
            avarage=int.Parse( Console.ReadLine());
           
            studentservice.Create(name, surname, avarage);
            

            break;
        case 2:
            Console.WriteLine("Enter the students Id.");
             id=int.Parse(Console.ReadLine());
            studentservice.Delete( id);
            break;
        case 3:

            Console.Write("Enter Student id:");

             id = int.Parse(Console.ReadLine());

            Console.Write("Enter Student name:");
             name=Console.ReadLine();
            Console.Write("Enter Student surname:");
            surname=Console.ReadLine();
            Console.Write("Enter Student avarage:");
            avarage=int.Parse(Console.ReadLine());
            studentservice.Edit( id, name, surname, avarage);
            break;
        case 4:
            studentservice.GetAll();
            break;
        case 5:
            Console.WriteLine("Enter the students Id.");
            id=int.Parse(Console.ReadLine());
            studentservice.GetById(id);
            break;
        case 0:
            return;



    }

    do
    {
        Console.WriteLine("If you want to continue press 1.");
        Console.WriteLine("If you want to exit press 0.");
        Console.Write("Your order--");
        try
        {

            Order = int.Parse(Console.ReadLine());
            ordercheck= true;
            Console.Clear();
        }
        catch (Exception)
        {
            Console.Clear();
            Console.WriteLine("Wrong Order.Try Again.");
            ordercheck= false;

        }
    } while (ordercheck==false||Order>1||Order<0);
      

    

    switch (Order)
    {
        case 1:
            continue;
        case 0:
            return;

    }

} while (true);







