using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cursorx, cursory, random_place, m;
            ConsoleKeyInfo cki;
            m = 0;
            cursorx = 0;
            cursory = 0;


            // --- Static screen parts
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("+##############################+");
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(0, i + 1);
                Console.WriteLine("#                              #");
            }
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("+##############################+");

            int[] row1 = new int[32];
            int[] row2 = new int[32];
            int[] row3 = new int[32];
            Random random = new Random();
            for (random_place = 1; random_place < 31; random_place += 1)
            {

                cursorx = random.Next(1, 31);
                cursory = random.Next(1, 4);
                m = random.Next(1, 4);
                if (cursory == 1)
                {
                    row1[cursorx] = m;

                }
                if (cursory == 2)
                {

                    row2[cursorx] = m;

                }

                if (cursory == 3)
                {
                    row3[cursorx] = m;

                }


                Console.SetCursorPosition(cursorx, cursory);
                Console.Write("{0}", m);



            }

            Console.SetCursorPosition(cursorx, cursory);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.UpArrow)
                    {
                        if (cursory > 1 && cursory < 5)
                        {
                            cursory--;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                    }
                    if (cki.Key == ConsoleKey.DownArrow)
                    {
                        if (cursory > 0 && cursory < 3)
                        {
                            cursory++;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                    }
                    if (cki.Key == ConsoleKey.LeftArrow)
                    {
                        if (cursorx >= 2 && cursorx <= 31)
                        {
                            cursorx--;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                    }
                    if (cki.Key == ConsoleKey.RightArrow)
                    {
                        if (cursorx >= 1 && cursorx <= 30)
                        {
                            cursorx++;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                    }
                    if (cki.Key == ConsoleKey.W)
                    {
                        if (row2[cursorx] == 0 && cursory == 3)
                        {

                            row2[cursorx] = row3[cursorx];
                            row3[cursorx] = 0;
                            cursory = cursory - 1;
                            Console.Write(" ");
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write(row2[cursorx]);
                            Console.SetCursorPosition(cursorx, cursory);

                        }
                        else if (row1[cursorx] == 0 && cursory == 2)
                        {

                            row1[cursorx] = row2[cursorx];
                            row2[cursorx] = 0;
                            cursory = cursory - 1;
                            Console.Write(" ");
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write(row1[cursorx]);
                            Console.SetCursorPosition(cursorx, cursory);

                        }
                    }
                    if (cki.Key == ConsoleKey.S)
                    {
                        if (row2[cursorx] == 0 && cursory == 1)
                        {

                            row2[cursorx] = row1[cursorx];
                            row1[cursorx] = 0;
                            cursory = cursory + 1;
                            Console.Write(" ");
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write(row2[cursorx]);
                            Console.SetCursorPosition(cursorx, cursory);

                        }
                        else if (row3[cursorx] == 0 && cursory == 2)
                        {

                            row3[cursorx] = row2[cursorx];
                            row2[cursorx] = 0;
                            cursory = cursory + 1;
                            Console.Write(" ");
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write(row3[cursorx]);
                            Console.SetCursorPosition(cursorx, cursory);

                        }
                    }

                    if (cki.Key == ConsoleKey.A)
                    {
                        while (true)
                        {

                            if (cursory == 1 && row1[cursorx - 1] == 0 && row1[cursorx] != 0)
                            {
                                if (cursorx == 1)
                                    break;
                                row1[cursorx - 1] = row1[cursorx];
                                row1[cursorx] = 0;
                                Console.Write(" ");
                                cursorx = cursorx - 1;
                                Console.SetCursorPosition(cursorx, cursory);
                                Console.Write(row1[cursorx]);
                                Console.SetCursorPosition(cursorx, cursory);


                            }
                            else if (cursory == 1 && row1[cursorx - 1] != 0)
                            {
                                break;
                            }


                            if (cursory == 2 && row2[cursorx - 1] == 0 && row2[cursorx] != 0)
                            {
                                if (cursorx == 1)
                                    break;
                                row2[cursorx - 1] = row2[cursorx];
                                row2[cursorx] = 0;
                                Console.Write(" ");
                                cursorx = cursorx - 1;
                                Console.SetCursorPosition(cursorx, cursory);
                                Console.Write(row2[cursorx]);
                                Console.SetCursorPosition(cursorx, cursory);

                            }
                            else if (cursory == 2 && row2[cursorx - 1] != 0)
                            {
                                break;
                            }

                            if (cursory == 3 && row3[cursorx - 1] == 0 && row3[cursorx] != 0)
                            {
                                if (cursorx == 1)
                                    break;
                                row3[cursorx - 1] = row3[cursorx];
                                row3[cursorx] = 0;
                                Console.Write(" ");
                                cursorx = cursorx - 1;
                                Console.SetCursorPosition(cursorx, cursory);
                                Console.Write(row3[cursorx]);
                                Console.SetCursorPosition(cursorx, cursory);

                            }
                            else if (cursory == 3 && row3[cursorx - 1] != 0)
                            {
                                break;
                            }



                        }

                    }

                    if (cki.Key == ConsoleKey.D)
                    {
                        while (true)
                        {


                            if (cursory == 1 && row1[cursorx + 1] == 0 && row1[cursorx] != 0)
                            {
                                if (row1[cursorx - 1] == 0 && row1[cursorx + 1] == 0)
                                {

                                    if (cursorx == 1)
                                        break;
                                    row1[cursorx + 1] = row1[cursorx];
                                    row1[cursorx] = 0;
                                    Console.Write(" ");
                                    cursorx = cursorx + 1;
                                    Console.SetCursorPosition(cursorx, cursory);
                                    Console.Write(row1[cursorx]);
                                    Console.SetCursorPosition(cursorx, cursory);


                                }
                                else if (cursory == 1 && row1[cursorx + 1] != 0)
                                {
                                    break;
                                }

                            }



                            if (cursory == 2 && row2[cursorx + 1] == 0 && row2[cursorx] != 0)
                            {
                                if (row2[cursorx - 1] == 0 && row2[cursorx + 1] == 0)
                                {
                                    if (cursorx == 1)
                                        break;
                                    row2[cursorx + 1] = row2[cursorx];
                                    row2[cursorx] = 0;
                                    Console.Write(" ");
                                    cursorx = cursorx + 1;
                                    Console.SetCursorPosition(cursorx, cursory);
                                    Console.Write(row2[cursorx]);
                                    Console.SetCursorPosition(cursorx, cursory);

                                }
                                else if (cursory == 2 && row2[cursorx + 1] != 0)
                                {
                                    break;
                                }
                            }



                            if (cursory == 3 && row3[cursorx + 1] == 0 && row3[cursorx] != 0)
                            {
                                if (row3[cursorx - 1] == 0 && row3[cursorx + 1] == 0)
                                {

                                    if (cursorx == 1)
                                        break;
                                    row3[cursorx + 1] = row3[cursorx];
                                    row3[cursorx] = 0;
                                    Console.Write(" ");
                                    cursorx = cursorx + 1;
                                    Console.SetCursorPosition(cursorx, cursory);
                                    Console.Write(row3[cursorx]);
                                    Console.SetCursorPosition(cursorx, cursory);

                                }
                                else if (cursory == 3 && row3[cursorx + 1] != 0)
                                {
                                    break;
                                }
                            }


                        }

                    }





                }


            }

            /*Console.SetCursorPosition(1, 5);
            Console.WriteLine("kontrol amaçlı yazıldı,her satırın 2. elemanını alıyor. doğru oldu");
            Console.SetCursorPosition(1, 6);
            Console.WriteLine(row1[2]);
            Console.SetCursorPosition(1, 7);
            Console.WriteLine(row2[2]);
            Console.SetCursorPosition(1, 8);
            Console.WriteLine(row3[2]);*/







        }
    }
}
