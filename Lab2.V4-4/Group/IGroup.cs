using System;
using System.Collections.Generic;
namespace Lab2
{
    public interface IGroup
    {
        NumberGroup NumberGroup { get; set; }
        List<IPerson> Persons { get; set; }

        void AddPerson(IPerson person);
        void RemovePerson(string id);
        IPerson GetPerson(string id);
        void ShowAllPersonInGroop();
    }
}
