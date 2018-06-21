using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Model
{
    public abstract class Repository<T> : IRepository<T>
    {
        public event NotifyCollectionChangedEventHandler DataSetChanged;

        protected abstract IList<T> InternalDataSet { get; }

        public IEnumerable<T> DataSet => InternalDataSet.ToArray();

        public void Create(T obj)
        {
            InternalDataSet.Add(obj);
            SaveChanges();
            DataSetChanged?.Invoke(this, null);
        }

        public void Update(T obj)
        {
            InternalDataSet.Remove(obj);
            InternalDataSet.Add(obj);
            SaveChanges();
            DataSetChanged?.Invoke(this, null);
        }

        public void Remove(T obj)
        {
            InternalDataSet.Remove(obj);
            SaveChanges();
            DataSetChanged?.Invoke(this, null);
        }

        protected abstract void SaveChanges();
    }
}
