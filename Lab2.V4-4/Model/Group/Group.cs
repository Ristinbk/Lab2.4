using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    public class Group :  IGroup
    {
        public NumberGroup NumberGroup { get; set; }
        public List<IStudent> Students { get; set; }

        public Group(NumberGroup numberGroup)
        {
            Students = new List<IStudent>();
            NumberGroup = numberGroup;
        }

        public void AddStudent(IStudent student)
        {
            if (student == null)
                throw new ArgumentNullException();  
            Students.Add(student);
            student.Id = new Id(NumberGroup, student.Id);
        }

        public void RemoveStudent(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            Students.Remove(GetStudent(id));
        }

        public IStudent GetStudent(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return Students.Find(e => e.Id.ToString().Equals(id));
        }

        public bool Equals(IGroup other)
        {
            if (other != null && NumberGroup.ToString().Equals(other.NumberGroup.ToString()))
                return true;
            else
                return false;
        }

        public override string ToString() => $"{NumberGroup}";
    }
}
