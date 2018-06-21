using System.Collections.Generic;
using System.Collections.Specialized;

namespace Model
{
    public interface IRepository<T>
    {

        event NotifyCollectionChangedEventHandler DataSetChanged;

        IEnumerable<T> DataSet { get; }

        void Create(T obj);
        void Update(T obj);
        void Remove(T obj);
    }
}
