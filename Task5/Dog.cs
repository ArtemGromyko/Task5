using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Dog : Animal
    {
        public string Name { get; set; }
        public Dog(string s, int a, string n) : base(s, a)
        {
            Name = n;
        }
        public override void Move()
        {
            Console.WriteLine("*moving like a Dog*");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("name: " + Name);
        }
    }
}
