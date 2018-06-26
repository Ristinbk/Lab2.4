using System;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class Teacher : Person
    {
        public Title Title { get; set; }

        public Teacher(FullName Name, DateTime birthDate, Gender gender, Title title)
            : base(Name, birthDate, gender)
        {
            Title = title;
        }

        public new void AddSubject(ISubject subject)
        {
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            Subjects.Add(subject);
        }

        public override string ToString() => $"id: {Id} {Name} ({DateOfBirth:d}) {Gender} {Title} {String.Join(", ", Subjects) }";
    }
}
