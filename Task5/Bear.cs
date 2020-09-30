using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Bear : Animal, ISwim
    {
        public override void Move()
        {
            Console.WriteLine("*moving like a bear*");
        }
        public void Swim()
        {
            Console.WriteLine("*swimming like a bear*");
        }
        public Bear(string s, int a) : base(s, a) { }
    }
}
