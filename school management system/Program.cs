using school_management_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    internal class Program
    {
      
static void Main(string[] args)
{
    School school = new School();

 
    school.ThresholdReached += (msg) => { Console.WriteLine(msg); };

    Student   s1 = new Student(  "Ali", "CS");
    Teacher   t1 = new Teacher(  "Hana", "Math");
    Librarian l1 = new Librarian("Omar", 5);
    Student   s2 = new Student(  "Lina", "Physics");

    school.AddPerson(s1);
    school.AddPerson(t1);
    school.AddPerson(l1);
    school.AddPerson(s2);

    Console.WriteLine("\n--- People in School ---");
    school.ShowAll();

    Console.WriteLine($"\nTotalPersons: {Person.TotalPersons}");
    Console.ReadKey();
}
    }
}