using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_120
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person persons = new Person();
            persons.FirstName = "Glen";
            persons.LastName = " Buck";
            persons.SayName();

            Employee employees = new Employee();
            employees.FirstName = "Sample";
            employees.LastName = " Student";
            employees.SayName();

            
            Console.ReadLine();



         

        }
    }
}
