using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Student : Person, IStudent
    { 
        public string NumberGroup { get; }

        public Student(FullName name, DateTime birthday) : base(name, birthday)        
        {
            Id = new Id();
        }

        public Student(FullName name, DateTime birthday, Id id) : base(name, birthday)
        {
            Id = id;
            NumberGroup = id.ToString().Substring(0, 5);
        }

        public void AddSubjects(List<ISubject> subjects)
        {
            if (subjects == null)
                throw new ArgumentNullException(nameof(subjects));
            foreach (var s in subjects)
            {
                Subjects.Add(new Subject(s.NameSubject, s.SubjectType, s.NameTeacher));
            }
        }

        public void MoveToSubjectAssessment(ISubject subject, Assessment assessment)
        {
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            Subjects.Find(e => e == subject).AddAssessment(assessment);
        }



        public override string ToString() => $"id: {Id} {Name} ({DateBirthday:d})";
    }
}
