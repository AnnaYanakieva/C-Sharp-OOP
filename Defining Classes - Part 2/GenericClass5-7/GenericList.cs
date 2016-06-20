namespace GenericClass5_7
{
    using System;
    using System.Collections.Generic;
    public class GenericList<T> where T : IComparable<T>
    {
        private int nextIndex = 0;
        private T[] elements;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        public void Add(T element)
        {
            if (this.nextIndex == elements.Length)
            {
                this.AutoGrow();
            }
            this.elements[nextIndex] = element;
            this.nextIndex++;
        }

        public T this[int index]
        {
            get
            {
                if (index > nextIndex - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return this.elements[index];
                }
            }
        }

        public void RemoveAtIndex(int index)
        {
            for (int i = index; i < this.nextIndex && i < this.elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.nextIndex--;
            this.elements[nextIndex] = default(T);
        }

        public void InsertAtIndex(int index, T element)
        {
            if (this.nextIndex == elements.Length)
            {
                // throw new IndexOutOfRangeException();
                this.AutoGrow();
            }
            for (int i = this.nextIndex - 1; i >= index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            this.nextIndex++;
        }

        public void Clear()
        {
            this.elements = new T[this.elements.Length];
        }

        public override string ToString()
        {
            return string.Join(", ", elements);
        }

        private void AutoGrow()
        {
            var newElements = new T[this.elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = elements[i];
            }

            this.elements = newElements;
        }

        public T Min()
        {
            if (this.nextIndex == 0)
            {
                throw new ArgumentException("There are no elements in the GenericList");
            }

            T min = this.elements[0];
            foreach (T item in this.elements)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public T Max()
        {

            if (this.nextIndex == 0)
            {
                throw new ArgumentException("There are no elements in the GenericList");
            }

            T max = this.elements[0];
            foreach (T item in this.elements)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

    }
}
