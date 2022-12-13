using System;

namespace UserLoginSystem.Net5
{
    class Program
    {

        static string userName;
        static string password;

        static void Main(string[] args)
        {
            
        }

        public void Register()
        {
            Console.WriteLine("Please enter your username");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
        }



    }
}
