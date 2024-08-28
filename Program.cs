namespace PrisonerDilemnaGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("\nPrisoner Dilemna Game\n");
            Console.WriteLine("Made by Ashton K\n");
            Console.WriteLine("A simple game that can be won by understanding your opponent");
            Console.WriteLine("The opponent (your computer) is not random");
            Console.WriteLine("Figuring out how it operates is the key to winning");
            Console.WriteLine("\nThe rules are simple:\n");
            Console.WriteLine("Both you and the computer start with 3 points each");
            Console.WriteLine("If you choose to share your points and the computer also shares, you both get 2 points");
            Console.WriteLine("However, if you choose to steal, you gain 3 points while the computer loses 1 point");
            Console.WriteLine("This applies to the computer as well");
            Console.WriteLine("The goal is to end the game with the most points");
            Console.WriteLine("\nGood luck!\n");
            Console.WriteLine("******************************************************************************************\n");

            while (true)
            {
                Console.WriteLine("Enter number of rounds you would like to play: ");
                try
                {
                    string input = Console.ReadLine();
                    int length = int.Parse(input);
                    string[] userArray = new string[length];
                    string[] computerArray = new string[length];
                    int[] temp = { };
                    TitForTat titForTat = new TitForTat(temp);

                    int count = 0;
                    while (count < length)
                    {

                        Console.WriteLine("Enter steal or share: ");
                        string userInput = Console.ReadLine();
                        userInput = userInput.ToLower();

                        if (userInput == "share" || userInput == "steal")
                        {
                            userArray[count] = userInput;

                            if (count > 0)
                            {
                                computerArray[count] = userArray[count - 1];
                                Console.WriteLine($"Opponent chose to {userArray[count - 1]}\n");

                            }
                            else
                            {
                                computerArray[count] = userInput;
                                Console.WriteLine($"Opponent chose to {userArray[count]}\n");
                            }

                            count++;
                            
                        }
                        else
                        {
                            Console.WriteLine("Please specify share or steal");
                        }
                        
                    }

                    temp = titForTat.GoldBalance(userArray, computerArray);

                    if (temp[0] > temp[1])
                    {
                        Console.WriteLine("\n\nCongratulations! You Won!");
                        Console.WriteLine($"You got {temp[0]} points, and your opponent got {temp[1]} points");
                    }
                    if (temp[0] < temp[1])
                    {
                        Console.WriteLine("\n\nYou Lost! Better luck next time.");
                        Console.WriteLine($"You got {temp[0]} points, and your opponent got {temp[1]} points");
                    }
                    if (temp[0] == temp[1])
                    {
                        Console.WriteLine("\n\nDraw! You and your opponent got the same amount of points!");
                        Console.WriteLine($"You both received {temp[0]} points");
                    }

                    Console.WriteLine("\nStop Playing? (Y)");
                    string yes = Console.ReadLine().ToLower();

                    if (yes == "y")
                    {
                        break;
                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine(ex.Message);
                }

            }

        }

    }
}
