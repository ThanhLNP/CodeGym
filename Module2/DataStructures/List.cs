using System;

namespace DataStructures
{
    class List
    {
        static void Main(string[] args)
        {
            MyList<int> listInteger = new MyList<int>();
            listInteger.add(1);
            listInteger.add(2);
            listInteger.add(3);
            listInteger.add(3);
            listInteger.add(4);

            Console.WriteLine("element 4: {0}", listInteger.get(4));
            Console.WriteLine("element 1: {0}", listInteger.get(1));
            Console.WriteLine("element 2: {0}", listInteger.get(2));
        }
    }

    class MyList<E>
    {
        private int size = 0;
        private const int DEFAULT_CAPACITY = 10;
        private object[] elements;

        public int Size { get => size; set => size = value; }

        public object[] Elements { get => elements; set => elements = value; }

        public MyList()
        {
            elements = new object[DEFAULT_CAPACITY];
        }

        public void add(E e)
        {
            if (size == elements.Length)
            {
                ensureCapa();
            }
            elements[size++] = e;
        }

        public void ensureCapa()
        {
            int newSize = elements.Length * 2;
            object[] newElements = new object[newSize];
            Array.Copy(elements, newElements, elements.Length);
            elements = newElements;
        }

        public E get(int i)
        {
            if (i >= size || i < 0)
            {
                throw new IndexOutOfRangeException("Index: " + i + ", Size " + size);
            }
            return (E)elements[i];
        }
    }
}
