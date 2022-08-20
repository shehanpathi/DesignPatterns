using System;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            string test =  "";
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string x = new string(Enumerable.Repeat(chars, 20)
                    .Select(s => s[random.Next(s.Length)]).ToArray()).ToString();
            while (true)
            {
                test += x;
                Console.WriteLine(test);
            }
        }
    }
}
