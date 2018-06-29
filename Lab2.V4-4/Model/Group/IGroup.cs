using System;
using System.Collections.Generic;
namespace Lab2
{
    public interface IGroup : IEquatable<IGroup>
    {
        NumberGroup NumberGroup { get; set; }
        List<IStudent> Students { get; set; }

        void AddStudent(IStudent student);
        void RemoveStudent(string id);
        IStudent GetStudent(string id);
    }
}
