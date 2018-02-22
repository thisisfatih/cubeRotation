using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cubeRotation
{
    class Program
    {
        private static List<string> moves;
        private static List<string> positions;

        static void Main(string [ ] args)
        {
            moves = new List<string>();
            positions = new List<string>();

            moves.Add("back");
            moves.Add("front");
            moves.Add("left");
            moves.Add("right");

            positions.Add("top"); //0
            positions.Add("bottom"); //1
            positions.Add("right"); //2
            positions.Add("left"); //3
            positions.Add("back"); //4
            positions.Add("front"); //5

            Console.WriteLine("Ready");
            Console.ReadKey();

            Random initialRandom= new Random();

            Random moveRandom = new Random();

            var move = 0;

            var currentPosition = initialRandom.Next(5);
            Console.WriteLine("Initial Position: " + positions [ currentPosition ]);
            var totalMoveRandom = new Random();
            Thread.Sleep(3000);
            Console.Clear();
            for ( int i = 0 ; i < totalMoveRandom.Next(30) ; i++ )
            {
                move = moveRandom.Next(3);
                Console.WriteLine("Move: " + moves [ move ]);
                Thread.Sleep(2000);
                Console.Clear();
                Thread.Sleep(1000);
                currentPosition = getNewPosition(currentPosition , move);
                //Console.WriteLine("Current Position: " + positions [ currentPosition ]);
            }
            Console.WriteLine("Last Position");
            Console.ReadKey();
            Console.WriteLine(positions [ currentPosition ]);

        }

        public static int getNewPosition(int currentPosition , int moveNumber)
        {
            if ( moveNumber == 0 )
            {
                if ( currentPosition == 0 )
                    return 4;
                else if ( currentPosition == 1 )
                    return 5;
                else if ( currentPosition == 2 )
                    return 2;
                else if ( currentPosition == 3 )
                    return 3;
                else if ( currentPosition == 4 )
                    return 1;
                else if ( currentPosition == 5 )
                    return 0;
                else
                    return 0;
            }

            else if ( moveNumber == 1 )
            {
                if ( currentPosition == 0 )
                    return 5;
                else if ( currentPosition == 1 )
                    return 4;
                else if ( currentPosition == 2 )
                    return 2;
                else if ( currentPosition == 3 )
                    return 3;
                else if ( currentPosition == 4 )
                    return 0;
                else if ( currentPosition == 5 )
                    return 1;
                else
                    return 0;
            }

            else if ( moveNumber == 2 )
            {
                if ( currentPosition == 0 )
                    return 3;
                else if ( currentPosition == 1 )
                    return 2;
                else if ( currentPosition == 2 )
                    return 0;
                else if ( currentPosition == 3 )
                    return 1;
                else if ( currentPosition == 4 )
                    return 4;
                else if ( currentPosition == 5 )
                    return 5;
                else
                    return 0;
            }

            else if ( moveNumber == 3 )
            {
                if ( currentPosition == 0 )
                    return 2;
                else if ( currentPosition == 1 )
                    return 3;
                else if ( currentPosition == 2 )
                    return 1;
                else if ( currentPosition == 3 )
                    return 0;
                else if ( currentPosition == 4 )
                    return 4;
                else if ( currentPosition == 5 )
                    return 5;
                else
                    return 0;
            }

            else
            {
                return 0;
            }

        }

    }
}
