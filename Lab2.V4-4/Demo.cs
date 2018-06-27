using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                        ShowMenuEntrants(U);
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
                        //    Console.Write("Введите идентификационный номер: ");
                        break;
                }
            } while (s != 0);

        }

        private static void ShowMenuEntrants(Univercity U)
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
                        U.AddEntrant(InputNewEntrant());
                        break;
                    case 2:
                        U.RemoveEntrant(InputId());
                        break;
                    case 3:
                        U.MoveEntrantInGroup(InputNumberGroup(), InputId());
                        break;
                    case 4:
                        U.ShowEntrants();
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
                        U.AddTeacher(InputNewTeacher());
                        break;
                    case 2:
                        U.RemoveTeacher(InputId());
                        break;
                    case 3:
                        U.AddSubjectToTeacher(InputId(), InputNameSubject());
                        break;
                    case 4:
                        U.ShowTeachers();
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
                        U.AddSubject(InputNewSubject());
                        break;
                    case 2:
                        U.RemoveSubject(InputNameSubject());
                        break;
                    case 3:
                        U.AddSubjectToTeacher(InputId(), InputNameSubject());
                        break;
                    case 4:
                        U.ShowSubjects();
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
                        U.AddGroup(InputNewGroup());
                        break;
                    case 2:
                        U.RemoveGroup(InputNumberGroup());
                        break;
                    case 3:

                        U.MoveToAnotherGroup(InputId(), InputNumberGroup(), InputNumberGroup());
                        break;
                    case 4:
                        U.ShowGroup();
                        break;
                    case 5:
                        U.ShowPersonsInGroup(InputNumberGroup());
                        break;
                    case 6:
                       
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
                        U.AddSession(InputNewSession());
                        break;
                    case 2:
                        U.RemoveSession(InputSession());
                        break;
                    case 3:
                        U.MoveResultPerson(InputSession(), InputNumberGroup(), InputId(), InputNameSubject(), InputAssessment());                        
                        break;
                    case 4:
                        U.ShowSession();
                        break;
                    case 5:
                        U.ShowResultOfSession(InputSession(), InputNumberGroup(), InputNameSubject());
                        break;
                }
            } while (s != 0);
        }       

        private static IPerson InputNewEntrant()
        {
            return new Entrant(InputFullName(), InputDate(), InputGender());
        }

        private static IPerson InputNewTeacher()
        {
            return new Teacher(InputFullName(), InputDate(), InputGender(), InputTitle());
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

        private static Gender InputGender()
        {
            Console.Write("Пол: 1- М, 2- Ж\nВыберите соответствующее значение:");
            Gender gender = new Gender();
            int s = Int32.Parse(Console.ReadLine());
            foreach (Gender g in Enum.GetValues(typeof(Gender)))
            {
                if ((int)g == s)
                    gender = g;
            }
            return gender;
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

        private static ISubject InputNewSubject()
        {
            string nameSubject = null;
            Console.Write("Предмет: ");
            nameSubject = ReturnName(nameSubject);
            return new Subject(nameSubject, InputSubjectType());
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

        private static IGroup InputNewGroup()
        {
            return new Group(new NumberGroup(InputSpecialty(), 2018));
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

        private static ISession InputNewSession()
        {
            return new Session(InputSessionType(), DateTime.Now.Year, InputSpecialty());
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
    }
}
