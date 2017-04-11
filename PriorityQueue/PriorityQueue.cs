using System;
using System.Collections.Generic;
using System.Linq;

namespace PQueue
{
    public class PriorityQueue<T>
    {
        private class ListItemEntry
        {
            /// <summary>
            /// Lower number is higher priority
            /// </summary>
            public int Priority { get; set; }
            public T Item { get; set; }

            public ListItemEntry(int priority, T item)
            {
                Priority = priority;
                Item = item;
            }
        }

        private List<ListItemEntry> _list;
        private int _highestPriority = 0;

        public PriorityQueue()
        {
            _list = new List<ListItemEntry>();
        }

        /// <summary>
        /// Enqueue an item with
        /// </summary>
        /// <param name="newItem"></param>
        public void Enqueue(T newItem)
        {
            ListItemEntry li = new ListItemEntry(_highestPriority++, newItem);
            _list.Add(li);
        }

        /// <summary>
        /// Enqueue a new item with a priority
        /// </summary>
        /// <param name="newItem"></param>
        /// <param name="priority"></param>
        public void Enqueue(T newItem, int priority)
        {
            ListItemEntry li = new ListItemEntry(priority, newItem);

            if (_list.Count() != 0)
            {
                _list.Where(a => a.Priority >= priority).ToList().ForEach(b => b.Priority++);

                int highestPriority = _list.OrderByDescending(a => a.Priority).FirstOrDefault().Priority;
                if (highestPriority >= _highestPriority)
                    _highestPriority = highestPriority + 1;
            }

            if (priority > _highestPriority)
                _highestPriority = priority;

            _list.Add(li);
        }

        public int Count()
        {
            return _list.Count();
        }

        public T Dequeue()
        {
            ListItemEntry entry = _list.OrderBy(a => a.Priority).FirstOrDefault();
            if (entry == null) return default(T);

            _list.Remove(entry);

            return entry.Item;
        }

        public T Peek()
        {
            if (_list.Count() == 0) return default(T);
            return _list.FirstOrDefault().Item;
        }
    }
}
