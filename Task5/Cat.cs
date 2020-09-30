using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Cat : Animal, IPet
    {
        public string Name { get; set; }
        public Cat(string s, int a, string n):base(s,a)
        {
            Name = n;
        }
        public override void Move()
        {
            Console.WriteLine("*moving like a cat*");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("name: "+Name);
        }
    }
}
