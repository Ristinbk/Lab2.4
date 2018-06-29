using System;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class Teacher : Person, ITeacher
    {
        public Title Title { get; set; }

        public Teacher(FullName Name, DateTime dateBirthday, Title title) : base(Name, dateBirthday)
        {
            Title = title;
        }

        public void AddSubject(ISubject subject)
        {
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            Subjects.Add(subject);
        }

        public override string ToString() => $"id: {Id} {Name} ({DateBirthday:d}) {Title} {String.Join(", ", Subjects) }";
    }
}
