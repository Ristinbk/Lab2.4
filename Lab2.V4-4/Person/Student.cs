using System;

namespace Lab2
{
    public class Student : Person
    {
        public override string Id { get; set; }
        public IGroup Group { get; private set; }        

        public Student(FullName name, DateTime birthDate, Gender gender)
           : base(name, birthDate, gender) { }

        public void AddTo(IGroup Group) => this.Group = Group ?? throw new ArgumentNullException();
        public void AddAssessment(ISubject subject, Assessment assessment) => subjects.Find(e => e == subject).AddAssessment(assessment);
        public override void SetId(int id) => Id = Group.NumberGroup.ToString() + id;
        public override string ToString() => $"id: {Id} {Name} ({DateOfBirth:d}) {Gender} {Group}";
        public override void ShowPerson() => Console.WriteLine(Name + "\t" + Gender + "\t" + Group);
    }
}
