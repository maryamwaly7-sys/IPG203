using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, string subject) : base(name)
        {
            Subject = subject;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Teacher] ID: {Id}, Name: {Name}, Subject: {Subject}");
        }
    }
}