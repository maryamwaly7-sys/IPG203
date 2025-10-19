using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    public class Librarian : Person
    {
        public int YearsOfExperience { get; set; }

        public Librarian(string name, int years) : base(name)
        {
            YearsOfExperience = years;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Librarian] ID: {Id}, Name: {Name}, Experience: {YearsOfExperience} years");
        }
    }
}
