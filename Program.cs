namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            Start();
            Game();
            
            void Start()
            {
                Console.WriteLine("I'm thinking of a number between 1 and 100. Please guess!");
            }

            void Game()    
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > 100 || input < 0)
                {
                    Console.WriteLine("That's out of the range! Please try again!");
                    Game();
                }
                else if (input > randomNumber)
                {
                    Console.WriteLine("That's too high! Please guess again!");
                    Game();
                }
                else if (input < randomNumber)
                {
                    Console.WriteLine("That's too low! Please guess again!");
                    Game();
                }
                else if (input == randomNumber)
                {
                    Console.WriteLine("That's correct! Congratulations!");
                }
                else
                {
                    Console.WriteLine("Thats not a valid input! Please try again!");
                    Game();
                }
            }
        }
    }
}