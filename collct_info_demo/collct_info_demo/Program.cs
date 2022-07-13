// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, whats your name?");

            var userName = Console.ReadLine();

            Console.WriteLine("Hello there," + userName + "isn't that a good day?");
            var goodDay_user = Console.ReadLine();

            Console.WriteLine("Yeah me too!");

            Console.ReadKey();
            Console.WriteLine("How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So you are" + userAge + " ?");
            Console.ReadLine();

            Console.WriteLine("Here are the results:/n Username:" + userName + "Age:" + userAge);





        }
    }
}