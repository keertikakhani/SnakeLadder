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
            int position1 = 0;
            int position2 = 0;
            int dice;
            int option;
            bool turn = true;
            int count1 = 0;
            int count2 = 0;

            Console.WriteLine("Snake and ladder game with two players");
            Console.WriteLine("Both players are at 0 position");

            while (position1 < 100 && position2 < 100)
            {
                if (turn == true)
                {
                    Console.WriteLine("\nplayer1 is rolling the dice");

                    Random random = new Random();
                    dice = random.Next(1, 7);
                    Console.WriteLine("dice value:" + dice);

                    Random random1 = new Random();
                    option = random1.Next(0, 3);

                    if (option == 0)
                    {
                        Console.WriteLine("No play");
                        position1 = position1 + 0;
                        Console.WriteLine("player 1 position: " + position1);
                        turn = false;
                        count1 = count1 + 1;
                    }
                    else if (option == 1)
                    {
                        Console.WriteLine("snake");
                        position1 = position1 - dice;
                        if (position1 < 0)
                        {
                            position1 = 0;
                        }
                        turn = false;
                        Console.WriteLine("player 1 position: " + position1);
                        count1 = count1 + 1;
                    }
                    else
                    {
                        Console.WriteLine("ladder");
                        position1 = position1 + dice;
                        if (position1 > 100)
                        {
                            position1 = position1 - dice;
                        }
                        else if (position1 == 100)
                        {
                            Console.WriteLine("player 1 position: 100");
                            Console.WriteLine("player 1 won");
                            break;
                        }
                        turn = true;
                        Console.WriteLine("player 1 position: " + position1);
                        Console.WriteLine("player 1 gets one more chance");
                    }

                }
                else
                {

                    Console.WriteLine("\nplayer 2 is rolling the dice");
                    Random random = new Random();
                    dice = random.Next(1, 7);
                    Console.WriteLine("dice value:" + dice);
                    Random random1 = new Random();
                    option = random1.Next(0, 3);

                    if (option == 0)
                    {
                        Console.WriteLine("No play");
                        position2 = position2 + 0;
                        turn = true;
                        Console.WriteLine("player 2 position: " + position2);
                        count2 = count2 + 1;
                    }
                    else if (option == 1)
                    {
                        Console.WriteLine("snake");
                        position2 = position2 - dice;
                        if (position2 < 0)
                        {
                            position2 = 0;
                        }
                        turn = true;
                        Console.WriteLine("player 2 position: " + position2);
                        count2 = count2 + 1;
                    }
                    else
                    {
                        Console.WriteLine("ladder");
                        position2 = position2 + dice;
                        if (position2 > 100)
                        {
                            position2 = position2 - dice;
                        }
                        else if (position2 == 100)
                        {
                            Console.WriteLine("player 2 position: 100");
                            Console.WriteLine("player 2 won");
                            break;
                        }
                        turn = false;
                        Console.WriteLine("player 2 position: " + position2);
                        Console.WriteLine("player 2 gets one more chance");
                        count2 = count2 + 1;
                    }

                }
            }
            if (position1 == 100)
            {
                Console.WriteLine("Number of times player 1 rolled the dice to win the game : " + count1);
            }
            else
            {
                Console.WriteLine("Number of times player 2 rolled the dice to win the game : " + count2);
            }


        }
    }
}
