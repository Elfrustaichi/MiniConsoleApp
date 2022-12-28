


using MiniConsoleAppProject.Models;
using MiniConsoleAppProject.Services;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
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

    switch (Order)
    {
        case 1:
            string name;
            string surname;
            Console.Write("Enter the name of student:");
            name = Console.ReadLine();
            Console.Write("Enter the surname of student:");
            surname = Console.ReadLine();
            StudentService.Create(name, surname);

            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
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







