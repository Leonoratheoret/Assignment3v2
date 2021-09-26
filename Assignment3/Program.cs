using System;

namespace Assignment3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "Hello, World!";
            Extensions.ReverseString(s);

            Queries q = new Queries();
            Console.WriteLine(q.Sith_Lords_Year2());

        }
    }
}
