using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("*flying*");
        }
        public Bird(string s, int a) : base(s, a) { }
    }
}
