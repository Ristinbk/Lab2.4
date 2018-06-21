using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace Lab2
{
    public class Teacher : Person
    {
        public override string Id { get; set; }
        public Title Title { get; set; }        

        public Teacher(FullName Name, DateTime birthDate, Gender gender, Title title)
            : base(Name, birthDate, gender)
        {
            Id = "0";
            Title = title;
        }

        public override void SetId(int id) => Id = id.ToString();
        public override string ToString() => $"id: {Id} {Name} ({DateOfBirth:d}) {Gender} {Title}";

        public override void ShowPerson()
        {
            Console.Write(Name + "\t" + Gender + "\t" + Title + "\t Предметы:");

            foreach (var t in Subjects)
            {
                Console.Write(t.ToString()+ "; ");
            }
            Console.Write("\n");
        }
    }
}
