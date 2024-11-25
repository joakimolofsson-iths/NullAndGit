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

            string? name = null;
            name ??= "Default name";
            Console.WriteLine(name);

            string? name2 = "Bacon";
            int name2Length = name2?.Length ?? 0;
            Console.WriteLine($"{name2Length}");

            string? name3 = "Bacon3";
            if(name3 is not null)
            {
                Console.WriteLine($"{name3} is not null");
            }

            string? name4 = "Bacon4";

            string b2 = "Commmmmmmmit";

            string b1 = "Commmmmmmiiititititi!!!!";

            string main = "main";

            string main2 = "main2";
        }
    }
}
