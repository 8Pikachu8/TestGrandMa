﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInCS
{
    internal class Animal
    {
        public string name;
        public int power;
        string size;



        public void Sleep()
        {
            Console.WriteLine("Спит)))");
        }

        public void Run()
        {
            Console.WriteLine("Бежит!!!!");
        }

        static void Main()
        {

            Animal rabbit = new Animal();
            rabbit.name = "Заяц";
            rabbit.power = 1;
            rabbit.Run();
            rabbit.Sleep();
        }
    }
}
