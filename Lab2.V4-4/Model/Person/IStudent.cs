using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface IStudent : IPerson
    {
        string NumberGroup { get; }

        void AddSubjects(List<ISubject> subjects);
    }
}
