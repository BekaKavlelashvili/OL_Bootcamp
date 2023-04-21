using Exercise_1;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

public class Login
{
    public void LoginUser()
    {
        var startup = new StartUp();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter your nickname: ");
            string nickname = Console.ReadLine();

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if (startup.Settings.Nickname == nickname && startup.Settings.Password == password)
            {
                Console.WriteLine("You have successfully logged in :)");
                break;
            }
            else
            {
                if (i != 4)
                    Console.WriteLine("Please Try Again :(");
                else
                    Console.WriteLine("Terminated");
            }
        }
    }
}

