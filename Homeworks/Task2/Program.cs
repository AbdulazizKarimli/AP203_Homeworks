using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("test@gmail.com", "Test1234")
            {
                Fullname = "test testov"
            };
            //Console.WriteLine("Password: " + user.Password);
            user.ShowInfo();
        }
    }
}
