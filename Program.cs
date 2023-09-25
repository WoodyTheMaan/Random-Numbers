using System.Diagnostics;

namespace Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int usersFirstNumber, usersSecondNumber, theNumberGenerated;
            Console.WriteLine("Welcome!!!");
            Console.WriteLine("");
            Console.WriteLine("Tell ya what, if you give me a minimum number and maximum number I'll give you a random number in that range");
            Console.WriteLine("So here give me the smallest number i the range I'm gunna generate!");
            usersFirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now put the highest number you want in the range!");
            usersSecondNumber = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(500);
            Console.WriteLine("Okay, I hope your glad to know that I already have the number!");
            Thread.Sleep(1000);
            Console.WriteLine("Okay okay okay, I feel bad, I don't have your number yet, the code to generate the number hasn't been initilized yet......Sorry");
            Console.WriteLine("");
            theNumberGenerated = generator.Next(usersFirstNumber, usersSecondNumber + 1);
            Thread.Sleep(1000);  
            Console.WriteLine("Okay! Now I have your number");
            Console.WriteLine("Click enter to see it!");
            Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine($"Your RaNdOm number is........{theNumberGenerated} and I'm going to generate 4 more!");
            Console.WriteLine("");
            Console.WriteLine("Click Enter");
            Console.ReadLine();
            theNumberGenerated = generator.Next(usersFirstNumber, usersSecondNumber + 1);
            Console.WriteLine(theNumberGenerated);
            Console.WriteLine("");
            Thread.Sleep(800);
            theNumberGenerated = generator.Next(usersFirstNumber, usersSecondNumber + 1);
            Console.WriteLine(theNumberGenerated);
            Console.WriteLine("");
            Thread.Sleep(800);
            theNumberGenerated = generator.Next(usersFirstNumber, usersSecondNumber + 1);
            Console.WriteLine(theNumberGenerated);
            Console.WriteLine("");
            Thread.Sleep(800);
            theNumberGenerated = generator.Next(usersFirstNumber, usersSecondNumber + 1);
            Console.WriteLine(theNumberGenerated);
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Cool eh?");
            Console.WriteLine("Okay thanks for playing! BYEEEE!!!!!!!");
        }
    }
}