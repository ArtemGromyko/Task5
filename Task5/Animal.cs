using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    abstract class Animal
    {
        string Species { get; set; }
        int Age { get; set; }
        public Animal() { }
        public Animal(string s, int a)
        {
            Species = s;
            Age = a;
        }
        public abstract void Move();
        public void Eat()
        {
            Console.WriteLine("*eating*");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("species: "+Species+" age: "+Age);
        }
    }
}
