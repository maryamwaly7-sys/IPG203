using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    public class School
    {
        private List<Person> people = new List<Person>();

        public delegate void ThresholdReachedHandler(string message);
        public event ThresholdReachedHandler ThresholdReached;

        public void AddPerson(Person p)
        {
            people.Add(p);

            if (people.Count > 3)
            {
                if (ThresholdReached != null)
                    ThresholdReached(" The maximum number of people has been exceeded?");
            }
        }

        public void ShowAll()
        {
            foreach (var p in people)
            {
                p.DisplayInfo();
            }
        }
    }
}
