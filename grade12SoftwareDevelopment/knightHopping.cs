using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace KnightHopProgram
{
    class Program
    {
        static void Main()
        {

            //non of this is releavnt to the program its just to make it looks cool
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("                            ");
            for (int i = 0; i < 35; i++)
            {
                Console.Write("_");

            }
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("                           |                                   |");
                if (i == 2)
                {
                    Console.WriteLine("             ______________|       WELCOME TO KNIGHT HOP       |____________");
                }
            }
            Console.Write("                            ");
            for (int i = 0; i < 35; i++)
            {
                Console.Write("-");

            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                 ________                                      ~~~~~~                   ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("                 |      |                                      |    |                           ");
                if (i == 0)
                {
                    Console.WriteLine("                 |<><><>|                                      |^_ ^|                               ");
                }
            }
            Console.WriteLine("                 | .... |                                      |____|                             ");
            Console.WriteLine("                  ------                                    /    ||   ^^                                  ");

            Console.WriteLine("                /{XXXXXX} _____                            /  {XXXX/X||||                         ");
            Console.WriteLine("              //  XXXXXX |     |              <--------   (    XXX/XX||||                          ");
            Console.WriteLine("             //   XXXXXX | ($) |                           |__ XX/XXX|__|                           ");
            Console.WriteLine("   --------]&-   ^^^^^^^^|____/                               ^^^^^^^^                                 ");
            Console.WriteLine("                  |<>|<>|                                      |<>|<>|                            ");
            Console.WriteLine("                  |_   _|                                      |_   _|                              ");
            Console.WriteLine("                  [ ] [ ]                                      [ ] [ ]                         ");


            Console.ForegroundColor = ConsoleColor.White;
            //-------------------------------------------------------------------

            int[,] Chessboard = new int[8, 8];
            int[,] Numberofmoves = new int[8, 8];
            int movementnumber = 0;
            int Mspotted = 0;
            int xI = 0;
            int yI = 0;
            int xF = 0;
            int yF = 0;

            Console.WriteLine();
            Console.WriteLine("Welcome to knight hop, begin by typing in your starting coordinates (make sure your coordinate are between 1 and 8) : ");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.Write("Enter the x value of the starting position : ");
            xI = Convert.ToInt32(Console.ReadLine());
            xI = xI - 1; //because arrays have a 0 index
            Console.Write("Enter the y value of the starting position : ");
            yI = Convert.ToInt32(Console.ReadLine());
            yI = yI - 1;

            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Now type in your final coordinates : ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter the x value of the final position : ");
            xF = Convert.ToInt32(Console.ReadLine());
            xF = xF - 1;
            Console.Write("Enter the y value of the final position : ");
            yF = Convert.ToInt32(Console.ReadLine());
            yF = yF - 1;

            for (int i = 0; i < 8; i++) // to make all the slots zero
            {
                for (int j = 0; j < 8; j++)
                {
                    Chessboard[i, j] = 0;
                }
            }

            // 0 = not visited (they were all zero before)
            // 1 = visited (current standing)
            // 2 = visited and completed 
            Chessboard[xI, yI] = 1;


            while (true)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Chessboard[i, j] == 1)
                        {
                            Mspotted = 0;

                            for (int k = 0; k < 8; k++)
                            {
                                if ((i + 1 < 8) && (j + 2 < 8))
                                {
                                    if ((k == 0) && (Chessboard[i + 1, j + 2] == 0))
                                    {

                                        Chessboard[i + 1, j + 2] = 1;
                                        //movementnumber = movementnumber + 1;
                                        Mspotted = 1;
                                        if (movementnumber > Numberofmoves[i + 1, j + 2])
                                        {
                                            Numberofmoves[i + 1, j + 2] = Numberofmoves[i, j] + 1;
                                            movementnumber = Numberofmoves[i + 1, j + 2];
                                        }

                                    }
                                }

                                if ((i + 2 < 8) && (j + 1 < 8))
                                {
                                    if ((k == 1) && (Chessboard[i + 2, j + 1] == 0))
                                    {

                                        Chessboard[i + 2, j + 1] = 1;
                                        //   movementnumber = movementnumber + 1;
                                        Mspotted = 1;
                                        if (movementnumber > Numberofmoves[i + 2, j + 1])
                                        {
                                            Numberofmoves[i + 2, j + 1] = Numberofmoves[i, j] + 1;
                                            movementnumber = Numberofmoves[i + 2, j + 1];
                                        }
                                        //  Numberofmoves[i + 2, j + 1] = movementnumber;
                                    }
                                }

                                if ((i + 2 < 8) && (j - 1 > -1))
                                {
                                    if ((k == 2) && (Chessboard[i + 2, j - 1] == 0))
                                    {

                                        Chessboard[i + 2, j - 1] = 1;
                                        //    movementnumber = movementnumber + 1;
                                        Mspotted = 1;
                                        if (movementnumber > Numberofmoves[i + 2, j - 1])
                                        {
                                            Numberofmoves[i + 2, j - 1] = Numberofmoves[i, j] + 1;
                                            movementnumber = Numberofmoves[i + 2, j - 1];
                                        }
                                        // Numberofmoves[i + 2, j - 1] = movementnumber;
                                    }
                                }

                                if ((i + 1 < 8) && (j - 2 > -1))
                                {
                                    if ((k == 3) && (Chessboard[i + 1, j - 2] == 0))
                                    {

                                        Chessboard[i + 1, j - 2] = 1;
                                        //   movementnumber = movementnumber + 1;
                                        Mspotted = 1;
                                        if (movementnumber > Numberofmoves[i + 1, j - 2])
                                        {
                                            Numberofmoves[i + 1, j - 2] = Numberofmoves[i, j] + 1;
                                            movementnumber = Numberofmoves[i + 1, j - 2];
                                        }
                                        //  Numberofmoves[i + 1, j - 2] = movementnumber;
                                    }
                                }

                                if ((i - 1 > -1) && (j - 2 > -1))
                                {
                                    if ((k == 4) && (Chessboard[i - 1, j - 2] == 0))
                                    {

                                        Chessboard[i - 1, j - 2] = 1;
                                        //     movementnumber = movementnumber + 1;
                                        Mspotted = 1;
                                        if (movementnumber > Numberofmoves[i - 1, j - 2])
                                        {
                                            Numberofmoves[i - 1, j - 2] = Numberofmoves[i, j] + 1;
                                            movementnumber = Numberofmoves[i - 1, j - 2];
                                        }
                                        //  Numberofmoves[i - 1, j - 2] = movementnumber;
                                    }
                                }

                                if ((i - 2 > -1) && (j - 1 > -1))
                                {
                                    if ((k == 5) && (Chessboard[i - 2, j - 1] == 0))
                                    {

                                        Chessboard[i - 2, j - 1] = 1;
                                        //   movementnumber = movementnumber + 1;
                                        Mspotted = 1;
                                        if (movementnumber > Numberofmoves[i - 2, j - 1])
                                        {
                                            Numberofmoves[i - 2, j - 1] = Numberofmoves[i, j] + 1;
                                            movementnumber = Numberofmoves[i - 2, j - 1];
                                        }
                                        // Numberofmoves[i - 2, j - 1] = movementnumber;
                                    }
                                }

                                if ((i - 2 > -1) && (j + 1 < 8))
                                {
                                    if ((k == 6) && (Chessboard[i - 2, j + 1] == 0))
                                    {

                                        Chessboard[i - 2, j + 1] = 1;
                                        //   movementnumber = movementnumber + 1;
                                        Mspotted = 1;
                                        if (movementnumber > Numberofmoves[i - 2, j + 1])
                                        {
                                            Numberofmoves[i - 2, j + 1] = Numberofmoves[i, j] + 1;
                                            movementnumber = Numberofmoves[i - 2, j + 1];
                                        }
                                        // Numberofmoves[i - 2, j + 1] = movementnumber;
                                    }
                                }


                                if ((i - 1 > -1) && (j + 2 < 8))
                                {
                                    if ((k == 7) && (Chessboard[i - 1, j + 2] == 0))
                                    {

                                        Chessboard[i - 1, j + 2] = 1;
                                        //     movementnumber = movementnumber + 1;
                                        Mspotted = 1;
                                        if (movementnumber > Numberofmoves[i - 1, j + 2])
                                        {
                                            Numberofmoves[i - 1, j + 2] = Numberofmoves[i, j] + 1;
                                            movementnumber = Numberofmoves[i - 1, j + 2];
                                        }
                                        //  Numberofmoves[i - 1, j + 2] = movementnumber;
                                    }
                                }

                                if (Mspotted == 1)
                                {
                                    movementnumber = movementnumber + 1;
                                }

                                if (Chessboard[xF, yF] != 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine();
                                    Console.WriteLine("!!!Final position has been reached!!!");
                                    Console.WriteLine();
                                    Console.Write("Your Final position is : ");
                                    Console.WriteLine(movementnumber - 1);
                                    Console.ReadLine();
                                    break;
                                }


                                Chessboard[i, j] = 2;


                            }
                        }
                    }
                }
            }
        }
    }
}



