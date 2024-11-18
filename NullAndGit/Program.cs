namespace NullAndGit
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
        }
    }
}
