namespace Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int firstNumber = 1, secondNumber = 1;
            Console.WriteLine("Please type the lowest number you want me to generate.");
              firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type the highest number you want me to generate");
            secondNumber = Convert.ToInt32(Console.ReadLine());
             Random generator = new Random();
             int number = generator.Next(firstNumber,secondNumber + 1);

            if (number == 1) 
            {
                Console.WriteLine("It's One");  
            }
            if (number == 2)
            {
                Console.WriteLine("It's Two");
            }

            if (number == 3)
            {
                Console.WriteLine("It's Three");
            }
            if (number == 4)
            {
                Console.WriteLine("It's Four");
            }

            if (number == 5)
            {
                Console.WriteLine("It's Five");
            }
            if (number == 6)
            {
                Console.WriteLine("It's Six");
            }


        }
    }
}