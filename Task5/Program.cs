using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Group a = new Group();
            Cat c = new Cat("burmilla", 3, "Tom");
            Dog d = new Dog("husky", 4, "Max");
            Bear b = new Bear("brown", 5);

            a.Add(c);
            a.Add(d);
            a.Add(b);

            a.Remove(0);

            a.Show();
        }
    }
}
