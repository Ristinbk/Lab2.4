using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Entrant : Person
    {
        public Id IdCredited { get; set; }

        public Entrant(FullName name, DateTime birthDate, Gender gender)
           : base(name, birthDate, gender)        {        }

        public void AddAssessment(ISubject subject, Assessment assessment)
        {
            if (subject == null) 
                throw new ArgumentNullException(nameof(subject));
            Subjects.Find(e => e == subject).AddAssessment(assessment);
        }

        public override string ToString() => $"id: {Id} {Name} ({DateOfBirth:d}) {Gender}";
    }
}
