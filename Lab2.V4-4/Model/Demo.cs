using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab2
{
    public static class Demo
    {
        public static void ShowMenu(Univercity U)
        {
            int s;
            do
            {
                Console.Write("1 - Абитуриенты\n2 - Преподаватели\n3 - Предметы\n4 - Группы\n5 - Сессии\n0 - Выход");
                Console.Write("\nВведите соответствуещее значение: ");
                s = Int32.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        ShowMenuStudents(U);
                        break;
                    case 2:
                        ShowMenuTeachers(U);
                        break;
                    case 3:
                        ShowMenuSubjects(U);
                        break;
                    case 4:
                        ShowMenuGroups(U);
                        break;
                    case 5:
                        ShowMenuSessions(U);
                        break;
                }
            } while (s != 0);
        }

        public static void InitializeUnivercity(Univercity U)
        {
            Random Rand = new Random();
            U.AddGroup(new Group(new NumberGroup(Specialty.Informatics, 2018)));
            U.AddGroup(new Group(new NumberGroup(Specialty.StateAudit, 2018)));

            U.Students.Add(new Student(new FullName("Илья", "Иванов", "Андреевич"), GetRandDate()));
            U.Students.Add(new Student(new FullName("Петр", "Борисов", "Петрович"), GetRandDate()));

            U.Groups[0].AddStudent(new Student(new FullName("Илья", "Иванов", "Андреевич"), GetRandDate()));
            U.Groups[0].AddStudent(new Student(new FullName("Иван", "Петров", "Олегович"), GetRandDate()));
            U.Groups[0].AddStudent(new Student(new FullName("Мария", "Иванова", "Олеговна"), GetRandDate()));
            U.Groups[1].AddStudent(new Student(new FullName("Ольга", "Зинко", "Евгеньевна"), GetRandDate()));
            U.Groups[1].AddStudent(new Student(new FullName("Петр", "Борисов", "Петрович"), GetRandDate()));


            U.AddTeacher(new Teacher(new FullName("Илья", "Смирнов", "Олегович"), GetRandDate(), Title.Aspirant));
            U.AddTeacher(new Teacher(new FullName("Борис", "Петров", "Дмитриевич"), GetRandDate(), Title.Lecture));
            U.AddTeacher(new Teacher(new FullName("Мария", "Иванова", "Олеговна"), GetRandDate(), Title.Lecture));

            List<ISubject> winterSession = new List<ISubject>()
            {
                new Subject("Математика", SubjectType.Exem),
                new Subject("Физика", SubjectType.Exem),
                new Subject("Информатика", SubjectType.Credited),
                new Subject("Психология", SubjectType.Credited)
            };
            List<ISubject> summerSession = new List<ISubject>()
            {  
                new Subject("Английский", SubjectType.Credited),
                new Subject("История", SubjectType.Credited)
            };
            U.Subjects.AddRange(winterSession);
            U.Subjects.AddRange(summerSession);

            foreach (var t in U.Subjects)
            {
                t.AddTeacher(GetRandTeacher());
            }

            U.AddSession(new Session(SessionType.Winter, 2018));
            U.AddSession(new Session(SessionType.Summer, 2018));
            U.Sessions[0].AddSubjects(U.Subjects);
            U.Sessions[1].AddSubjects(summerSession);

            foreach (var session in U.Sessions)
            {
                foreach (var group in U.Groups)
                {

                    session.AddSubjectsInGroup(group);
                }
            }

            U.Sessions[0].Groups[0].Students.ForEach(delegate (IStudent student)
            {
                student.Subjects.ForEach(delegate (ISubject subject)
                {
                    subject.AddAssessment(GetRandAssessment());
                });
            });

            U.Sessions[0].Groups[1].Students.ForEach(delegate (IStudent student)
            {
                student.Subjects.ForEach(delegate (ISubject subject)
                {
                    subject.AddAssessment(GetRandAssessment());
                });
            });

            foreach (var subject in U.Subjects)
            {
                subject.AddTeacher(GetRandTeacher());
            }

            DateTime GetRandDate()
            {
                return new DateTime(Rand.Next(1800, 1890), Rand.Next(1, 13), Rand.Next(1, 29));
            }

            ITeacher GetRandTeacher()
            { 
                return U.Teachers[Rand.Next(U.Teachers.Count)];
            }

            Assessment GetRandAssessment()
            {
                return (Assessment)Rand.Next(Enum.GetNames(typeof(Assessment)).Length);
            }
        }

        private static int GetNowYear()
        {
            return DateTime.Now.Year;
        }

        private static FullName InputFullName()
        {
            string firstName = null, lastName = null, patronymic = null;
            Console.Write("Фамилия: ");
            lastName = ReturnName(lastName);
            Console.Write("Имя: ");
            firstName = ReturnName(firstName);
            Console.Write("Отчество: ");
            patronymic = ReturnName(patronymic);
            return new FullName(firstName, lastName, patronymic);
        }

        private static string ReturnName(string name)
        {
            bool a = false;
            do
            {
                name = Console.ReadLine();
                if (OnlyLetters(name))
                    a = true;
                else
                    Console.Write("Ошибка! Введите заново: ");
            }
            while (!a);
            return name;
        }

        private static bool OnlyLetters(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z а-яА-Я]+$");
        }

        private static DateTime InputDate()
        {
            Console.Write("Дата(01.01.0001): ");
            DateTime date;
            while (!(DateTime.TryParse(Console.ReadLine(), out date)))
            {
                Console.Write("Ошибка! Введите заново: ");
            }
            return date;
        }

        private static Title InputTitle()
        {
            Console.Write("Должность: 1-Professor, 2- Lecture, 3 - Aspirant\nВыберите соответствующее значение:");
            Title title = new Title();
            int s = Int32.Parse(Console.ReadLine());
            foreach (Title t in Enum.GetValues(typeof(Title)))
            {
                if ((int)t == s)
                    title = t;
            }
            return title;
        }

        private static string InputId()
        {
            Console.Write("Введите идентификационный номер: ");
            return Console.ReadLine();
        }

        private static string InputNameSubject()
        {
            Console.Write("Введите предмет: ");
            return Console.ReadLine();
        }

        private static string InputNumberGroup()
        {
            Console.Write("Введите номер группы:");
            return Console.ReadLine();
        }

        private static string InputSubject()
        {
            string nameSubject = null;
            Console.Write("Предмет: ");
            return nameSubject = ReturnName(nameSubject);
        }

        private static SubjectType InputSubjectType()
        {
            Console.Write("1- Зачёт, 2- Экзамен\nВыберите соответствующее значение:");
            SubjectType subjectType = new SubjectType();
            int s = Int32.Parse(Console.ReadLine());
            foreach (SubjectType st in Enum.GetValues(typeof(SubjectType)))
            {
                if ((int)st == s)
                    subjectType = st;
            }
            return subjectType;
        }

        private static Specialty InputSpecialty()
        {
            Console.Write("Направление: 1-InformaticsAndComputerFacilities, 2- TechnosphericSafety, 3- Management, 4- StateAudit, " +
                "5- FinanceAndCredit, 6- Service, 7- Tourism\nВыберите соответствующее значение:");
            Specialty specialty = new Specialty();
            int s = Int32.Parse(Console.ReadLine());
            foreach (Specialty sp in Enum.GetValues(typeof(Specialty)))
            {
                if ((int)sp == s)
                    specialty = sp;
            }
            return specialty;
        }

        private static SessionType InputSessionType()
        {
            Console.Write("Сессия: 1- Зимняя, 2- Летняя\nВыберите соответствующее значение:");
            SessionType sessionType = new SessionType();
            int s = Int32.Parse(Console.ReadLine());
            foreach (SessionType st in Enum.GetValues(typeof(SessionType)))
            {
                if ((int)st == s)
                    sessionType = st;
            }
            return sessionType;
        }

        private static string InputSession()
        {
            Console.Write("Введите сессию(Winter 2018):");
            return Console.ReadLine();
        }

        private static Assessment InputAssessment()
        {
            Console.Write("Результат: 1- Незачтено, 2- Зачтено, 3- Удовлетворительно, 4- Хорошо, 5- Отлично\nВыберите соответствующее значение:");
            Assessment assessment = new Assessment();
            int s = Int32.Parse(Console.ReadLine());
            foreach (Assessment ass in Enum.GetValues(typeof(Assessment)))
            {
                if ((int)ass == s)
                    assessment = ass;
            }
            return assessment;
        }

        private static void ShowStudents(Univercity U)
        {
            foreach (IStudent f in U.Students)
                Console.WriteLine(f.ToString());
        }

        private static void ShowTeachers(Univercity U)
        {
            foreach (ITeacher f in U.Teachers)
                Console.WriteLine(f.ToString());
        }

        private static void ShowSubjects(Univercity U)
        {
            foreach (ISubject f in U.Subjects)
                Console.WriteLine(f.ToString());
        }

        private static void ShowGroups(Univercity U)
        {
            foreach (IGroup f in U.Groups)
                Console.WriteLine(f.ToString());
        }

        private static void ShowStudentsInGroup(Univercity U, string numberGroup)
        {
            if (numberGroup == null)
                throw new ArgumentNullException();

            IGroup group = U.GetGroup(numberGroup);
            Console.WriteLine("группа: " + group.NumberGroup);
            if (group.Students != null)
            {
                foreach (var t in group.Students)
                {
                    Console.WriteLine(t.ToString());
                }
            }
        }        

        private static void ShowSession(Univercity U)
        {
            foreach (ISession f in U.Sessions)
                Console.WriteLine(f.ToString());
        }

        private static void ShowResultOfSubject(Univercity U, string session, string numberGroup, string nameSubject)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));
            if (numberGroup == null)
                throw new ArgumentNullException(nameof(numberGroup));
            if (nameSubject == null)
                throw new ArgumentNullException(nameof(nameSubject));
            U.GetSession(session);
            ShowResultToGroup(U.GetGroup(numberGroup), U.GetSubject(nameSubject));
        }

        private static void ShowResultToGroup(IGroup group, ISubject subject)
        {
            if (group == null)
                throw new ArgumentNullException(nameof(group));
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            Console.WriteLine(subject.NameSubject + " " + subject.SubjectType + " " + group.NumberGroup);
            group.Students.ForEach(delegate (IStudent student)
            {
                ShowResultOfStudent(student, subject);
            });
        }

        private static void ShowInfoOfStudentInGroup(Univercity U, string id)
        {
            IStudent student = U.GetGroup(id.Substring(0, 5)).GetStudent(id);
            foreach (var s in student.Subjects)
            {
                ShowResultOfStudent(student, s);
            }
        }

        private static void ShowResultOfStudent(IStudent student, ISubject subject)
        {
            Console.WriteLine(student.Name + ":\t" + subject.NameSubject + "-" + subject.Assessment);
        }

        private static void ShowMenuStudents(Univercity U)
        {
            Console.Write("1 - Добавить запись\n2 - Удалить запись\n3 - Перевести в группу\n4 - Вывести весь список\n0 - В главное меню");
            int s;
            do
            {
                Console.Write("\nВведите соответствуещее значение: ");
                s = Int32.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        U.AddStudent(new Student(InputFullName(), InputDate()));
                        break;
                    case 2:
                        U.RemoveStudent(InputId());
                        break;
                    case 3:
                        U.MoveStudentInGroup(InputNumberGroup(), InputId());
                        break;
                    case 4:
                        ShowStudents(U);
                        break;
                }
            } while (s != 0);
        }

        private static void ShowMenuTeachers(Univercity U)
        {
            Console.Write("1 - Добавить запись\n2 - Удалить запись\n3 - Назначить предмет\n4 - Вывести весь список\n0 - В главное меню");
            int s;
            do
            {
                Console.Write("\nВведите соответствуещее значение: ");
                s = Int32.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        U.AddTeacher(new Teacher(InputFullName(), InputDate(), InputTitle()));
                        break;
                    case 2:
                        U.RemoveTeacher(InputId());
                        break;
                    case 3:
                        U.AddSubjectToTeacher(InputId(), InputNameSubject());
                        break;
                    case 4:
                        ShowTeachers(U);
                        break;
                }
            } while (s != 0);
        }

        private static void ShowMenuSubjects(Univercity U)
        {
            Console.Write("1 - Добавить запись\n2 - Удалить запись\n3 - Назначить преподавателя\n4 - Вывести весь список\n0 - В главное меню");
            int s;
            do
            {
                Console.Write("\nВведите соответствуещее значение: ");
                s = Int32.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        U.AddSubject(new Subject(InputSubject(), InputSubjectType()));
                        break;
                    case 2:
                        U.RemoveSubject(InputNameSubject());
                        break;
                    case 3:
                        U.AddSubjectToTeacher(InputId(), InputNameSubject());
                        break;
                    case 4:
                        ShowSubjects(U);
                        break;
                }
            } while (s != 0);
        }

        private static void ShowMenuGroups(Univercity U)
        {
            Console.Write("1 - Добавить запись\n2 - Удалить запись\n3 - Перевести в другую группу\n4 - Вывести список групп\n" +
                "5 - Вывести список студентов в группе\n6 - Вывести информацию о студенте\n0 - В главное меню");
            int s;
            do
            {
                Console.Write("\nВведите соответствуещее значение: ");
                s = Int32.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        U.AddGroup(new Group(new NumberGroup(InputSpecialty(), GetNowYear())));
                        break;
                    case 2:
                        U.RemoveGroup(InputNumberGroup());
                        break;
                    case 3:

                        U.MoveStudentToAnotherGroup(InputId(), InputNumberGroup());
                        break;
                    case 4:
                        ShowGroups(U);
                        break;
                    case 5:
                        ShowStudentsInGroup(U, InputNumberGroup());
                        break;
                    case 6:
                        ShowInfoOfStudentInGroup(U, InputId());
                        break;
                }
            } while (s != 0);
        }

        private static void ShowMenuSessions(Univercity U)
        {
            Console.Write("1 - Добавить запись\n2 - Удалить запись\n3 - Изменить результат экзамена\n4 - Вывести список сессий\n" +
                "5 - Вывести результаты экзамена для группы\n0 - В главное меню");
            int s;
            do
            {
                Console.Write("\nВведите соответствуещее значение: ");
                s = Int32.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        U.AddSession(new Session(InputSessionType(), DateTime.Now.Year));
                        break;
                    case 2:
                        U.RemoveSession(InputSession());
                        break;
                    case 3:
                        U.MoveResultPerson(InputSession(), InputNumberGroup(), InputId(), InputNameSubject(), InputAssessment());
                        break;
                    case 4:
                        ShowSession(U);
                        break;
                    case 5:
                        ShowResultOfSubject(U, InputSession(), InputNumberGroup(), InputNameSubject());
                        break;
                }
            } while (s != 0);
        }
    }
}
