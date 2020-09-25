using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3450_Program1._2
{
    public class ListQ<T> : IQueueStorage<T>
    {
        private List<T> list;
        public ListQ()
        {
            this.list = new List<T>();
        }
                  
        public void Add(T p)
        {
            list.Add(p);
        }

        public void Clear()
        {
            list.Clear();
        }

        public T Get()
        {
            return list.First();
        }

        public T Remove()
        {
            var thing = list[0];
            list.RemoveAt(0);
            return thing;
        }

        public int Size()
        {
            return list.Count();
        }

    }
}
