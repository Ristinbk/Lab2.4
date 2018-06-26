using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Id
    {
        public string Number { get; }

        public Id()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                    .Select(e => e.ToString())
                    .Concat(Enumerable.Range(97, 26).Select(e => e.ToString()))
                    .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                    .OrderBy(e => Guid.NewGuid())
                    .Take(2)
                    .ToList().ForEach(e => builder.Append(e));
            Number = builder.ToString();
        }   

        public Id(NumberGroup numberGroup, Id id)
        {
            Number = numberGroup.ToString() + id;
        }

        public override string ToString() => $"{Number}";
    }
}
