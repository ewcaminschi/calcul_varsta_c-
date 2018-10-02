using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduceti data nasterii in format dd/mm/yyyy :");
                var person = new Person(DateTime.Parse(Console.ReadLine()));
                
                
                //person.Birthdate = new DateTime(1982, 1, 1);
                Console.WriteLine("Varsta dumneavoastra este de: {0} de ani.", person.Age);
            }

            catch
            {
                Console.WriteLine("Data introdusa nu este valida!");
               
            }
            Console.ReadKey();
        }
    }
}
