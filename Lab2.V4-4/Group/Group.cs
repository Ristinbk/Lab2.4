using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Group : IGroup
    {
        public Specialty Specialty { get; }
        public NumberGroup NumberGroup { get; }
        public List<IPerson> Persons { get; set; }

        public Group(Specialty specialty) : this(specialty, new int()) => NumberGroup = new NumberGroup();

        public Group(Specialty specialty, int number)
        {
            Specialty = specialty;
            Persons = new List<IPerson>();
            NumberGroup = new NumberGroup(specialty, number);
        }

        public void AddPerson(IPerson student)
        {
            if (student == null)
                throw new ArgumentNullException();  
            Persons.Add(student);
        }

        public void RemovePerson(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException();
            var person = GetPerson(id);
            if (person == null)
                throw new ArgumentNullException();
            Persons.Remove(person);
        }

        public IPerson GetPerson(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException();
            return Persons.Find(e => e.Id == id);
        }

        public void ShowAllPersonInGroops()
        {
            Console.WriteLine("Группа: " + Specialty);
            foreach (var t in Persons)
            {
                t.ShowPerson();
            }
            Console.WriteLine();
        }

        public void ShowAllGroops() => Console.WriteLine("Группа: " + Specialty);
        public override string ToString() => $"{NumberGroup}";
    }
}
