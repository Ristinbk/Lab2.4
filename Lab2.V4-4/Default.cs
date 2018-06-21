using System;

namespace Lab2
{
    public static class Default
    {
        public static void DefaultUnivercity(Univercity U)
        {
            U.AddGroup(new Group(Specialty.Enrollee));
            U.AddGroup(new Group(Specialty.InformaticsAndComputerFacilities, 1234));
            U.AddGroup(new Group(Specialty.Tourism, 12532));
            U.AddGroup(new Group(Specialty.StateAudit, 2346));
            DefaultStudent(U);
            DefaultTeacher(U);
            DefaultSubjects(U);
            DefaultSession(U);
        }

        public static void DefaultStudent(Univercity U)
        {
            U.AddStudentInGroup("Inf1234", new Student
           (new FullName("Илья", "Иванов", "Андреевич"), GetDate(), Gender.Male));
            U.AddStudentInGroup("Inf1234", new Student
                (new FullName("Иван", "Петров", "Олегович"), GetDate(), Gender.Male));
            U.AddStudentInGroup("Inf1234", new Student
                (new FullName("Петр", "Борисов", "Петрович"), GetDate(), Gender.Male));
            U.AddStudentInGroup("Inf1234", new Student
                (new FullName("Ольга", "Зинко", "Евгеньевна"), GetDate(), Gender.Female));
            U.AddStudentInGroup("Tou12532", new Student
                (new FullName("Мария", "Иванова", "Олеговна"), GetDate(), Gender.Female));
            U.AddStudentInGroup("Tou12532", new Student
                (new FullName("Олег", "Иванов", "Иванович"), GetDate(), Gender.Male));
            U.AddStudentInGroup("Tou12532", new Student
                (new FullName("Ирина", "Савина", "Евгеньевна"), GetDate(), Gender.Female));
            U.AddStudentInGroup("Enr0", new Student
               (new FullName("Иван", "Петров", "Олегович"), GetDate(), Gender.Male));
            U.AddStudentInGroup("Tou12532", new Student
                (new FullName("Ирина", "Савина", "Евгеньевна"), GetDate(), Gender.Female));
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

            U.AddTeacherToSubject(new Teacher
                (new FullName("Илья", "Иванов", "Андреевич"), 
                GetDate(), Gender.Male, Title.Aspirant), U.Subjects[0]);
            U.AddTeacherToSubject(U.Teachers[0], U.Subjects[0]);
            U.AddTeacherToSubject(U.Teachers[0], U.Subjects[1]);
            U.AddTeacherToSubject(U.Teachers[1], U.Subjects[2]);
            U.AddTeacherToSubject(U.Teachers[2], U.Subjects[3]);
        }

        public static void DefaultSession(Univercity U)
        {
            U.AddSession(new Session(SessionType.Winter, U.Groups));
            U.Sessions[0].AddSubjects(U.Groups[0], U.Subjects);
            U.Sessions[0].AddSubjects(U.Groups[1], U.Subjects);
            U.Sessions[0].moveAssessment(U.Groups[1].Persons[0], U.Subjects[0], Assessment.Five);
            U.Sessions[0].moveAssessment(U.Groups[1].Persons[1], U.Subjects[0], Assessment.Four);
        }

        public static DateTime GetDate()
        {
            Random Rand = new Random();
            DateTime randDate = new DateTime(Rand.Next(1800, 1890), Rand.Next(1, 13), Rand.Next(1, 29));
            return randDate;
        }          
    }
}