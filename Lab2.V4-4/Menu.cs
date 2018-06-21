using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class Menu
    {
        public static void ShowMenu(Univercity U)
        {
            Console.Write("1 - Cписок студентов\n2 - Список преподавателей\n3 - Информация о сессии\n4 - Добавить запись о студенте\n5 - Добавить запись о преподавателе\n6 - Удалить запись о студенте\n7 - Удалить запись о преподавателе\n8 - Изменить запись о студенте\n9 - Изменить запись о преподавателе");

            int a;
            do
            {
                Console.Write("\nВведите соответствуещее значение: ");
                a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        foreach (var t in U.Groups)
                        {
                            t.ShowAllPersonInGroops();
                        }
    
                        break;
                    case 2:
                        foreach (var t in U.Groups)
                        {
                            t.ShowAllGroops();
                        }
                        break;
                    case 3:
                        foreach (var t in U.Teachers)
                        {
                            t.ShowAllPerson(U.Teachers);
                        }
                        break;
                    case 4:
                        foreach (var t in U.Sessions)
                        {
                            t.ShowSession(U.Sessions);
                        }
                        break;
                    case 5:

                        break;
                    case 6:
                        Console.Write("Введите идентификационный номер: ");
                        string number = Console.ReadLine();
                        //      students.RemovePerson(number);
                        break;
                    case 7:
                        Console.Write("Введите идентификационный номер: ");
                        number = Console.ReadLine();
                        //       teachers.RemovePerson(number);
                        break;
                    case 8:
                        Console.Write("Введите идентификационный номер: ");
                        number = Console.ReadLine();
                        //    students.СhangePerson(number);
                        break;
                    case 9:
                        Console.Write("Введите идентификационный номер: ");
                        number = Console.ReadLine();
                        //     teachers.СhangePerson(number);
                        break;
                }
            } while (a != 0);

        }

    }
}
