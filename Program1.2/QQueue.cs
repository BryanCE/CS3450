using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3450_Program1._2
{
    public class QQueue<T> : IQueueStorage<T>
    {
        private Queue<T> q;

        public QQueue()
        {
           this.q = new Queue<T>();
        }

        public void Add(T p)
        {
            q.Enqueue(p);
        }

        public void Clear()
        {
            q?.Clear();
        }

        public T Get()
        {
            return q.Peek();
        }

        public T Remove()
        {
            return q.Dequeue();
        }

        public int Size()
        {
            return q.Count();
        }
    }
}
