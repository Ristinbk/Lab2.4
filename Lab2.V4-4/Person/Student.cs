using System;

namespace Lab2
{
    public class Student : Person
    {
        public string NumberGroup { get; }        

        public Student(FullName name, DateTime birthDate, Gender gender, Id id)
           : base(name, birthDate, gender)
        {
            Id = id;
            NumberGroup = id.ToString().Substring(0, 5);
        }

        public void AddAssessment(ISubject subject, Assessment assessment)
        {
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            Subjects.Find(e => e == subject).AddAssessment(assessment);
        }

        public void MoveToSubjectAssessment(ISubject subject, Assessment assessment)
        {

        }

        public override string ToString() => $"id: {Id} {Name} ({DateOfBirth:d}) {Gender} {NumberGroup}";

    }
}
