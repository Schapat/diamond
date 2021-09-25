using System;

namespace DiamondApp
{
    class DiamondApp
    {
        static void Main(string[] args)
        {
            Diamond(5);
        }
        /**
        *   Method to create a diamond as output on the console
        *   @param1 maximum width
        */
        public static void Diamond(int n)
        {
            int half = n / 2;

            for (int i = 0; i <= half; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (half + i >= j && half - i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.Write("\n");
            }

            for (int i = half - 1; i >= 0; i--)
            {
                for (int j = n; j > 0; j--)
                {
                    if (half + 1 + i >= j && half + 1 - i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.Write("\n");
            }

        }

    }
}

