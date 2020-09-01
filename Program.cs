using System;
using System.IO;


namespace Filsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //File.WriteAllText("words.txt", "Thing");
            // string s = File.ReadAllText("words.txt");
            if(File.Exists("words.txt"))
            {
            string[] words = File.ReadAllLines("words.txt");
            System.Console.WriteLine(words[0]);

            }
            // Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
