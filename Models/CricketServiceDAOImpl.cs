using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cricketer.Models
{
    public class CricketServiceDAOImpl : CricketerServiceDAO
    {
        static CricketServiceDAOImpl cricketServiceDAOImpl = null;
        
        private CricketServiceDAOImpl()
        {
                
        }

        public static CricketServiceDAOImpl GetCricketServiceDAOImplInstance()
        {
            if (cricketServiceDAOImpl == null)
                cricketServiceDAOImpl = new CricketServiceDAOImpl();

            return cricketServiceDAOImpl;
        }


        CricketerDAOImpl impl = Factory.GetCricketerDAOImplInstance();
        public void AddCricketer()
        {
            try
            {
                Console.WriteLine("Enter id.");
                var id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name.");
                var name = Console.ReadLine();

                Console.WriteLine("Enter Jersey No.");
                var jesryno = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter DOB.");
                var Dob = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter Age.");
                var age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter Country.");
                var country = Console.ReadLine();

                Console.WriteLine("Enter Role.");
                var role = Console.ReadLine();

                var cricketer = new Cricketer(id, name, jesryno, Dob, age, country, role);
                impl.AddCricketer(cricketer);
            }
            catch(Exception ex)
            {
                Logger.Log(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteCricketer()
        {
            try {
                Console.WriteLine("Enter id of cricketer to be deleted.");
                var id = Int32.Parse(Console.ReadLine());
                impl.DeleteCricketer(id);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                Console.WriteLine(ex.Message);
            }

        }

        public void GetAllCricketers()
        {
            try {
                List<Cricketer> list = new List<Cricketer>();
                list = impl.GetAllCricketers();
                Console.ForegroundColor = ConsoleColor.Cyan;
                var table = new ConsoleTable("ID", "Name", "JerseyNo","Date Of Birth","Age","Country","Role");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var item in list)
                {
                   // Console.WriteLine(item.ToString());
                    table.AddRow(item.ID, item.Name, item.JerseyNo, item.DOB, item.Age, item.Country, item.Role);
                }

                Console.WriteLine(table);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                Console.WriteLine(ex.Message);
            }

        }

        public void GetCricketer()
        {
            try
            {
                Console.WriteLine("Enter id of cricketer to be fetch.");
                var id = Int32.Parse(Console.ReadLine());
                var cricketer = impl.GetCricketer(id);
                var table = new ConsoleTable("ID", "Name", "JerseyNo", "Date Of Birth", "Age", "Country", "Role");
                table.AddRow(cricketer.ID, cricketer.Name, cricketer.JerseyNo, cricketer.DOB, cricketer.Age, cricketer.Country, cricketer.Role);
                Console.WriteLine(table);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                Console.WriteLine(ex.Message);
            }

        }

        public void UpdateCricketer()
        {
            try {
                Console.WriteLine("Please provide below info to update cricketers info.");

                Console.WriteLine("Enter id.");
                var id = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter Name.");
                var name = Console.ReadLine();

                Console.WriteLine("Enter Jersey No.");
                var jesryno = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter DOB.");
                var Dob = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter Age.");
                var age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter Country.");
                var country = Console.ReadLine();

                Console.WriteLine("Enter Role.");
                var role = Console.ReadLine();

                var cricketer = new Cricketer(id, name, jesryno, Dob, age, country, role);
                impl.UpdateCricketer(cricketer);
            }
            catch(Exception ex)
            {
                Logger.Log(ex.Message);
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}