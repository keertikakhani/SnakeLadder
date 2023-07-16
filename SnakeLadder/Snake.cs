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
            Console.WriteLine("Snake and ladder game with single player");
            Console.WriteLine("player is at 0 position");
            Random random = new Random();
            dice = random.Next(1, 7);
            Console.WriteLine("Player is rolling the dice");
            Console.WriteLine("dice value:" + dice);
        }
    }
}
