using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3450_Program1._2
{
    public class Container<T> : IQueueStorage<T>
    {
        private IQueueStorage<T> storageClass = null;
        public Container(IQueueStorage<T> storageMethod)
        {
            storageClass = storageMethod;
            storageClass?.Clear();
        }

        public void Add(T element)
        {
            storageClass?.Add(element);
        }

        public T Get()
        {
            return (storageClass is null) ? default : storageClass.Get();
        }

        public T Remove()
        {
            return (storageClass is null) ? default : storageClass.Remove();
        }

        public int Size()
        {
            return (storageClass is null) ? default : storageClass.Size();
        }

        public void Clear()
        {
            storageClass?.Clear();
        }

        public void ChangeImplementation(IQueueStorage<T> storage)
        {
            storage.Clear();
            if(storageClass != null)
            {
                while(storageClass.Size() > 0)
                {
                    storage.Add(storageClass.Remove());
                }
            }
            storageClass = storage;
        }
    }
}
