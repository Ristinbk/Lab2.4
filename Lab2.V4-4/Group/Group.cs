using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    public class Group :  IGroup
    {
        public NumberGroup NumberGroup { get; set; }
        public List<IPerson> Persons { get; set; }

        public Group(NumberGroup numberGroup)
        {
            Persons = new List<IPerson>();
            NumberGroup = numberGroup;
        }

        public void AddPerson(IPerson person)
        {
            if (person == null)
                throw new ArgumentNullException();  
            Persons.Add(person);
        }

        public void RemovePerson(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            Persons.Remove(GetPerson(id));
        }

        public IPerson GetPerson(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return Persons.Find(e => e.Id.ToString().Equals(id));
        }

        public void ShowAllPersonInGroop()
        {
            Console.WriteLine("Группа: " + NumberGroup);
            if (Persons != null)
            {
                foreach (var t in Persons)
                {
                    Console.WriteLine(t.ToString());
                }
                Console.WriteLine();
            }
        }

        public bool Equals(IGroup other)
        {
            if (other != null && NumberGroup.ToString().Equals(other.NumberGroup.ToString()))
                return true;
            else
                return false;
        }

        public override string ToString() => $"{NumberGroup}";
    }
}
