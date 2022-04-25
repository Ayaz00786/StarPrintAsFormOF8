using System;
using System.Collections.Generic;
using System.Text;

namespace StarPrintAsFormOF8
{
    internal class Class1
    {
        public static void starpattern()
        {
            for (int i = 1; i <= 7; i++)
            {
                if (i==1 || i==4 ||i==7)
                {
                    for (int j = 1; j <= 8; j++)
                    {
                        Console.Write("*");
                    }
                }
                if(i==2 || i==3 || i==5 || i==6)
                {
                    for (int j = 1; j <= 8; j++)
                    {
                        if(j==1 || j==8)
                        {
                            Console.Write("*");
                        }
                        else if (j>=2 && j<=7)
                        {
                            Console.Write(" ");
                        }


                    }
                }
                Console.WriteLine();
            }
           
            Console.ReadLine();
        }
    }
}
