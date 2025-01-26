namespace Dice_game
{


    class Program
    {

        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

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
            }
            Console.ReadKey();
           
        }
    }
}