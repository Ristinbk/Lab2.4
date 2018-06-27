using System;

namespace Lab2
{
    public static class Default
    {
        public static void DefaultUnivercity(Univercity U)
        {
            U.AddGroup(new Group(new NumberGroup(Specialty.TechnosphericSafety, 2018)));
            U.AddGroup(new Group(new NumberGroup(Specialty.InformaticsAndComputerFacilities, 2018)));
            U.AddGroup(new Group(new NumberGroup(Specialty.Tourism, 2018)));
            U.AddGroup(new Group(new NumberGroup(Specialty.StateAudit, 2018)));
            DefaultStudent(U);
            DefaultTeacher(U);
            DefaultSubjects(U);
            DefaultSession(U);
        }

        public static void DefaultStudent(Univercity U)
        {
            U.AddEntrant(new Entrant(new FullName("Илья", "Иванов", "Андреевич"), GetDate(), Gender.Male));
            U.AddEntrant(new Entrant(new FullName("Иван", "Петров", "Олегович"), GetDate(), Gender.Male));
            U.AddEntrant(new Entrant(new FullName("Петр", "Борисов", "Петрович"), GetDate(), Gender.Male));
            U.AddEntrant(new Entrant(new FullName("Ольга", "Зинко", "Евгеньевна"), GetDate(), Gender.Female));
            U.AddEntrant(new Entrant(new FullName("Мария", "Иванова", "Олеговна"), GetDate(), Gender.Female));

            U.MoveEntrantInGroup(U.Groups[0].NumberGroup.ToString(), U.Entrants[0].Id.ToString());
            U.MoveEntrantInGroup(U.Groups[0].NumberGroup.ToString(), U.Entrants[1].Id.ToString());
            U.MoveEntrantInGroup(U.Groups[0].NumberGroup.ToString(), U.Entrants[2].Id.ToString());

           // U.MoveEntrantInGroup(U.Groups[0].NumberGroup, new Student
           //(new FullName("Илья", "Иванов", "Андреевич"), GetDate(), Gender.Male));
           // U.MoveEntrantInGroup(U.Groups[0].NumberGroup, new Student
           //     (new FullName("Иван", "Петров", "Олегович"), GetDate(), Gender.Male));
           // U.MoveEntrantInGroup(U.Groups[0].NumberGroup, new Student
           //     (new FullName("Петр", "Борисов", "Петрович"), GetDate(), Gender.Male));
           // U.MoveEntrantInGroup(U.Groups[0].NumberGroup, new Student
           //     (new FullName("Ольга", "Зинко", "Евгеньевна"), GetDate(), Gender.Female));
           // U.MoveEntrantInGroup(U.Groups[1].NumberGroup, new Student
           //     (new FullName("Мария", "Иванова", "Олеговна"), GetDate(), Gender.Female));
           // U.MoveEntrantInGroup(U.Groups[1].NumberGroup, new Student
           //     (new FullName("Олег", "Иванов", "Иванович"), GetDate(), Gender.Male));
           // U.MoveEntrantInGroup(U.Groups[1].NumberGroup, new Student
           //     (new FullName("Ирина", "Савина", "Евгеньевна"), GetDate(), Gender.Female));
           // U.MoveEntrantInGroup(U.Groups[2].NumberGroup, new Student
           //    (new FullName("Иван", "Петров", "Олегович"), GetDate(), Gender.Male));
           // U.MoveEntrantInGroup(U.Groups[2].NumberGroup, new Student
           //     (new FullName("Ирина", "Савина", "Евгеньевна"), GetDate(), Gender.Female));
        }

        public static void DefaultTeacher(Univercity U)
        {
            U.AddTeacher(new Teacher(new FullName("Илья", "Смирнов", "Олегович"), GetDate(), Gender.Male, Title.Aspirant));
            U.AddTeacher(new Teacher(new FullName("Борис", "Петров", "Дмитриевич"), GetDate(), Gender.Male, Title.Lecture));
            U.AddTeacher(new Teacher(new FullName("Мария", "Иванова", "Олеговна"), GetDate(), Gender.Female, Title.Lecture));
        }
        public static void DefaultSubjects(Univercity U)
        {
            U.AddSubject(new Subject("Математика", SubjectType.Exem));
            U.AddSubject(new Subject("Физика", SubjectType.Exem));
            U.AddSubject(new Subject("Информатика", SubjectType.Credited));
            U.AddSubject(new Subject("Психология", SubjectType.Credited));

            //U.AddSubjectToTeacher(new Teacher
            //    (new FullName("Илья", "Иванов", "Андреевич"), 
            //    GetDate(), Gender.Male, Title.Aspirant), U.Subjects[0]);
            //U.AddSubjectToTeacher(U.Teachers[0], U.Subjects[0]);
            //U.AddSubjectToTeacher(U.Teachers[0], U.Subjects[1]);
            //U.AddSubjectToTeacher(U.Teachers[1], U.Subjects[2]);
            //U.AddSubjectToTeacher(U.Teachers[2], U.Subjects[3]);
        }

        public static void DefaultSession(Univercity U)
        {
            U.AddSession(new Session(SessionType.Winter, 2018, Specialty.Service));
            U.Sessions[0].AddSubjects(U.Groups[0], U.Subjects);
            U.Sessions[0].AddSubjects(U.Groups[1], U.Subjects);
            U.Sessions[0].MoveToSubjectAssessment(U.Groups[0].Persons[0], U.Subjects[0], Assessment.Five);
            U.Sessions[0].MoveToSubjectAssessment(U.Groups[0].Persons[0], U.Subjects[1], Assessment.Five);
            U.Sessions[0].MoveToSubjectAssessment(U.Groups[0].Persons[0], U.Subjects[2], Assessment.Four);
            U.Sessions[0].MoveToSubjectAssessment(U.Groups[0].Persons[0], U.Subjects[3], Assessment.Four);
            U.Sessions[0].MoveToSubjectAssessment(U.Groups[0].Persons[1], U.Subjects[0], Assessment.Four);
        }

        public static DateTime GetDate()
        {
            Random Rand = new Random();
            DateTime randDate = new DateTime(Rand.Next(1800, 1890), Rand.Next(1, 13), Rand.Next(1, 29));
            return randDate;
        }          
    }
}