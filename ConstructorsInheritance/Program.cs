using ConstructorsInheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();                          //{ FirstName = "Toon", LastName = "ToonLM", Age = 42, Subject = "C#" };
            //student.FirstName = "Toon";
            //student.LastName = "ToonLM";
            //student.Age = 42;


            Student student = new Student("Toon","ToonLM");
            student.Age = 42;

            Console.WriteLine($"Firstname : {student.FirstName} : LastName {student.LastName}");
        }
    }
}
