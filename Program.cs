using System.ComponentModel.Design;

namespace Dice_game
{


    class Program
    {

        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;


            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();   

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 10);
                Console.WriteLine("John Connor rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 10);
                Console.WriteLine("Skynet AI rolled a " + enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("John Conner beat Skynet!!!");
                }
                else if(enemyRandomNum > enemyPoints)
                {
                    enemyPoints++;
                    Console.WriteLine("Skynet will take over the world!!!");
                }
                else
                {
                    Console.WriteLine("The war continues");
                }

                Console.WriteLine("The score is now - John Conner :  " + playerPoints + " . Skynet : " + enemyPoints + ".");
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("The future is saved!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("The future is doomed!");
            }
            else
            {
                Console.WriteLine("We will continue to fight!");
            }
            Console.ReadKey();
           
        }
    }
}