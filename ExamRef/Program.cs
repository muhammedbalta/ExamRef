﻿using ExamRef.Threading;
using System;
using System.Threading.Tasks;

namespace ExamRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task_Child.Run();
        }
    }
}
