using System;
using System.Collections.Generic;
namespace Lab2
{
    public interface IGroup
    {
        Specialty Specialty { get; }
        NumberGroup NumberGroup { get; }
        List<IPerson> Persons { get; set; }

        void AddPerson(IPerson person);
        void RemovePerson(string id);
        IPerson GetPerson(string id);
        void ShowAllPersonInGroops();
        void ShowAllGroops();
    }
}
