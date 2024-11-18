﻿namespace NullAndGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Null & Git!");

            string? inputName = Console.ReadLine();

            Console.WriteLine(inputName ?? "Null...");

            if(inputName != null)
            {
                Console.WriteLine($"{inputName}");
            }
            else
            {
                Console.WriteLine("Null...");
            }
        }
    }
}
