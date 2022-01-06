using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cricketer.Models
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            CricketServiceDAOImpl impl = Factory.GetCricketServiceDAOImplInstance();
            Console.WriteLine("Welcome to cricketer info App");
            Console.WriteLine("\n");

            int i = 1;

            while(i != 0)
            {
                Console.WriteLine("Select an option to perfom");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1.Add Cricketer   2.Get All Cricketer   3.Find Cricketer  4.Delete Cricketer  5.Update Cricketer");
                Console.ForegroundColor = ConsoleColor.White;

                int input = Int32.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("\n");
                        impl.AddCricketer();
                        Console.WriteLine("\n");                    
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        impl.GetAllCricketers();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        impl.GetCricketer();
                        Console.WriteLine("\n");                        
                        break;
                    case 4:
                        Console.WriteLine("\n");
                        impl.DeleteCricketer();
                        Console.WriteLine("\n");                       
                        break;
                    case 5:
                        Console.WriteLine("\n");
                        impl.UpdateCricketer();
                        Console.WriteLine("\n");                      
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("\n");                       
                        break;
                }
            }
           
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}