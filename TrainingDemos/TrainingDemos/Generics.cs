using System;
namespace TrainingDemos
{
    public class Generics<T>
    {
        private int capacity;
        private T[] _data;

        public Generics(int Capacity)
        {
            this.capacity = Capacity;
            _data = new T[Capacity];
        }
        

        public void AddOrUpdate(int index, T item)
        {
            if(index > 0 && index < capacity)
            {
                _data[index] = item;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of bounds");
            }
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < capacity)
                return _data[index];
            else
            {
                throw new  IndexOutOfRangeException("Index is out of bounds");
            }
        }
        
    }
}

