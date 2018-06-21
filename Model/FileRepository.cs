using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Model
{
    public class FileRepository<T> : Repository<T>
    {
        protected override IList<T> InternalDataSet { get; }
        public string FileName { get; }

        public FileRepository(string fileName, Func<string, T> converter)
        {
            FileName = fileName;
            InternalDataSet = LoadData(converter);
        }

        private IList<T> LoadData(Func<string, T> converter)
        {
            if (!File.Exists(FileName)) return new List<T>();

            return File.ReadAllLines(FileName)
                .Select(converter)
                .ToList();
        }

        protected override void SaveChanges()
        {
            File.WriteAllLines(FileName, DataSet.Select(t => t.ToString()));
        }
    }
}
