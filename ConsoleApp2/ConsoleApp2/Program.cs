﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            bool isAValid = Int32.TryParse(str1, out int a);
            bool isBValid = Int32.TryParse(str2, out int b);
            Console.WriteLine(str1+str2);

            if(!isAValid || !isBValid)
                {
                    Console.WriteLine("Invalid input");
                }

            if(isAValid && isBValid)
                {
                    Console.WriteLine(a+b);
                }





            Cat cat1 = new Cat("Vaska", 10.1f, BreedEnum.Exotic);
            //Console.WriteLine(cat1.Name);
            //Console.WriteLine(cat1.Age);
            //Console.WriteLine(cat1.Breed);

            Cat cat2 = new Cat("Barsik", 3.5f);
            //Console.WriteLine(cat2.Name);
            //Console.WriteLine(cat2.Age);
            //Console.WriteLine(cat2.Breed);

            Cat cat3 = new Cat("Bobik", 3.5f, BreedEnum.None);
            //Console.WriteLine(cat3.Name);
            //Console.WriteLine(cat3.Age);
            //Console.WriteLine(cat3.Breed);

            Console.WriteLine(cat1.ToString());

            cat1.Name="Vaska"; 
            Console.WriteLine(cat1.Name);

        }
    }
}
