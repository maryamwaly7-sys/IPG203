using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    public class Student : Person
    {
        public string Major { get; set; }

        public Student(string name, string major) : base(name)
        {
            Major = major;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Student] ID: {Id}, Name: {Name}, Major: {Major}");
        }
    }
}
