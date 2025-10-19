using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    public abstract class Person : IEntity
    {
        private static int counter = 0;
        private readonly int id;
        private string name;

        public int Id { get { return id; } }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name)
        {
            this.name = name;
            counter++;
            id = counter;
        }

        public abstract void DisplayInfo();

        public static int TotalPersons { get { return counter; } }
    }
}