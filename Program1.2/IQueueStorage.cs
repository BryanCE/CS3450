namespace CS3450_Program1._2
{
    public interface IQueueStorage<T>
    {
        void Clear();
        int Size();
        void Add(T p);
        T Remove();
        T Get();
    }
}