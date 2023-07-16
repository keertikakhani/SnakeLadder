using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Snake
    {
        public static void Ladder()
        {
            int dice;
            int option;
            int position = 0;
            Console.WriteLine("Snake and ladder game with single player");
            Console.WriteLine("player is at 0 position");

            while (position < 100)
            {
                Console.WriteLine("\nplayer is rolling the dice");
                Random random = new Random();
                dice = random.Next(1, 7);
                Console.WriteLine("dice value : " + dice);
                Random random1 = new Random();
                option = random1.Next(0, 3);

                if (option == 0)
                {
                    Console.WriteLine("option is No play");
                    position = position + 0;
                    Console.WriteLine("position: " + position);
                }
                else if (option == 1)
                {
                    Console.WriteLine("option is snake");
                    position = position - dice;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    Console.WriteLine("position: " + position);
                }
                else
                {
                    Console.WriteLine("option is ladder");
                    position = position + dice;
                    Console.WriteLine("position: " + position);
                }
            }
        }
    }
}
