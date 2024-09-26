namespace Topic_5___Assignment_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/26/24

            int randNum, userGuess;

            Console.WriteLine("Please input the correct random number from 1-10 or else...");
            int.TryParse(Console.ReadLine(), out userGuess);
            if (userGuess >= 1 && userGuess <= 9)
                randNum = (userGuess + 1);
            else if (userGuess == 10)
                randNum = (userGuess - 1);
            else
            {
                Console.WriteLine("That is an invalid answer");
                randNum = 5;
            }
            if (randNum == userGuess)
                Console.WriteLine("Lucky guess...");
            else
            {
                Console.WriteLine("The correct number was " + randNum);
                Console.WriteLine("You will face the punishment now...");
                Console.ReadLine();
            }


        }
    }
}
