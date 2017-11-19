using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue
{
    public class Queue<T>
    {
        private T[] queue;
        private int count;

        public Queue()
        {
            queue = new T[0];
        }

        public int Count
        {
            get { return count; }

            private set { count = value; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public T this[int index]
        {
            get { return queue[index]; }
        }

        public void Add(T item)
        {
            if (item == null)
            {
                throw new NullReferenceException();
            }

            if (queue.Length == 0)
            {
                Array.Resize(ref queue, 1);
                queue[0] = item;
                Count = 1;
            }
            else 
            if (queue.Length != Count)
            {
                queue[Count] = item;
                Count += 1;
            }
            else
            {
                int prevLength = queue.Length;
                Array.Resize(ref queue, queue.Length * 2);
                queue[prevLength] = item;
                Count += 1;
            }
        }

        public void Clear()
        {
            queue = new T[0];
            count = 0;
        }

        public bool Contains(T value)
        {
            return queue.Contains(value);
        }

        public void CopyTo(T[] array, int index)
        {
            for (int i = 0; i < Count; ++i)
            {
                array.SetValue(this[i], i + index);
            }
                
            Count += index;
        }

        public void Remove()
        {
            queue = queue.Skip(1).ToArray();
            Count--;
        }

        public CustomIterator GetEnumerator()
        {
            return new CustomIterator(this);
        }

        public struct CustomIterator
        {
            private readonly Queue<T> collection;
            private int currentIndex;

            public CustomIterator(Queue<T> collection)
            {
                currentIndex = -1;
                this.collection = collection;
            }

            public T Current
            {
                get
                {
                    if (currentIndex == -1 || currentIndex == collection.Count)
                    {
                        throw new InvalidOperationException();
                    }

                    return collection[currentIndex];
                }
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public bool MoveNext()
            {
                return ++currentIndex < collection.Count;
            }
        }
    }
}
