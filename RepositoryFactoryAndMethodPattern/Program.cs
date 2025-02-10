using RepositoryFactoryAndMethodPattern.Factories;
using RepositoryFactoryAndMethodPattern.Repositories;
using RepositoryFactoryAndMethodPattern.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DITest1 di1 = new DITest1(new RepositoryFactoryImpl());
            di1.Run();
            Console.WriteLine("======================");
            DITest2 di2 = new DITest2();
            di2.Run(new RepositoryFactoryImpl());

            Console.ReadLine();
        }
    }
}
