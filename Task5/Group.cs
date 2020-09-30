using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Group
    {
        private Animal [] arr;
        private int count;

        public Group()
        {
            arr = new Animal[10];
            count = 0;
        }
        public void Add(Animal a)
        {
            arr[count++] = a;
            if (arr.Length == count)
                Resize();
        }
        public void Remove(int index)
        {
            if(arr.Length != 0 && index >= 0 && index < count)
            {
                Animal[] newarr = new Animal[arr.Length];
                int j = 0;
                for(int i=0; i < count; i++)
                {
                    if(i != index)
                        newarr[j++] = arr[i];
                }
                arr = newarr;
                count--;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        private void Resize()
        {
            Animal [] newarr = new Animal[arr.Length * 2];
            for (int i = 0; i < arr.Length; i++)
                newarr[i] = arr[i];
            arr = newarr;
        }
        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i+":");
                arr[i].ShowInfo();
                Console.WriteLine();
            }
        }
    }
}
