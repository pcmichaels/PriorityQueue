using System.Collections.Generic;
using System.Linq;

namespace PQueue
{
    public class PriorityQueue<T>
    {
        private List<T> _list;

        public PriorityQueue()
        {
            _list = new List<T>();
        }

        public void Enqueue(T newItem)
        {
            _list.Add(newItem);
        }

        public int Count()
        {
            return _list.Count();
        }

        public T Dequeue()
        {
            T item = _list.FirstOrDefault();
            if (item == null) return default(T);

            _list.Remove(item);

            return item;
        }

        public T Peek()
        {
            return _list.FirstOrDefault();
        }
    }
}
