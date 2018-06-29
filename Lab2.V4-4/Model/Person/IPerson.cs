using System;
using System.Collections.Generic;

namespace Lab2
{
    public interface IPerson
    {
        List<ISubject> Subjects { get; }

        FullName Name { get; set; }
        DateTime DateBirthday { get; set; }
        Id Id { get; set; }

        //    void AddSubject(ISubject subject);
    }
}
