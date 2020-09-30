using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Horse : Animal, ISwim, IPet
    {
        public string Name { get; set; }
        public Horse(string s, int a, string n):base(s,a)
        {
            Name = n;
        }
        public override void Move()
        {
            Console.WriteLine("moving like a horse");
        }
        public void Swim()
        {
            Console.WriteLine("*swimming like a horse*");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("name: " + Name);
        }
    }
}
