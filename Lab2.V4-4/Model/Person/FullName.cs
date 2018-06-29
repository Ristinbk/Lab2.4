using System;

namespace Lab2
{
    public class FullName
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Patronymic { get; set; }

        public FullName(string firstName, string lastName, string patronymic)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
        }

        public override string ToString() => $"{FirstName} {LastName} {Patronymic}";
    }
}
