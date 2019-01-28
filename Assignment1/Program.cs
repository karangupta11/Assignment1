using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 15;
            PrintPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);

            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);

            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);

            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
        }

        /* THIS WAS A GREAT INTRODUCTORY ASSIGNMENT WHEREIN I WAS ABLE TO BRUSH UP MY 
        PROGRAMMING SKILLS AND LEARNT HOW TO USE VISUAL STUDIO DOT NET FRAMEWORK AND 
        APPLIED VARIOUS TOOLS ASSOCIATED WITH IT. I ALSO LEARNT TO CREATE METHODS AND CALL THEM WHENEVER REQUIRED.
        ALSO THROUGH THIS ASSIGNMENT I GOT ACQUAINTED WITH VARIOUS DIFFERENT SYNTAXES USED IN C SHARP PROGRAMMING LANGUAGE.*/


        public static void PrintPrimeNumbers(int x, int y)
        {
            try
            {
                int num, i, ctr;
                Console.WriteLine("The prime numbers between {0} & {1} are:", x, y);
                for (num = x; num <= y; num++)
                {
                    ctr = 0;
                    for (i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            ctr++;
                            break;
                        }
                    }
                    if (ctr == 0 && num != 1)
                        Console.WriteLine("{0}", num);

                }
                Console.ReadKey();


            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }

        }
        //-----------------------------------------------------------------------------------------------------------------
        public static double factorial(long f) //THIS IS THE METHOD TO CALCULATE FACTORIAL OF A NUMBER 
        {
            int i, fact = 1;

            for (i = 1; i <= f; i++)
            {
                fact = fact * i;
            }

            return fact;
        }
        public static double getSeriesResult(int n)
        {
            try
            {
                double ev = 0, od = 0;
                for (int i = 1; i <= n; i = i + 2)
                {
                    double r1 = factorial(i) / (i + 1); //CALLED THE FACTORIAL METHOD
                    ev = ev + r1;
                }
                for (int i = 2; i <= n; i = i + 2)
                {
                    double r2 = factorial(i) / (i + 1); //CALLING THE FACTORIAL METHOD
                    od = od + r2;
                }
                double result = ev - od;

                return Math.Round(result, 3); //THIS FUNCTION RETURNS THE OUTPUT VALUE IN EXACTLY UPTO 3 PLACES OF DECIMAL.

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return 0;
        }

        //------------------------------------------------------------------------------------------------------------------
        public static long decimalToBinary(long n)
        {
            string bin = "";

            try
            {
                long quot;
                string rem = "";
                while (n >= 1)
                {
                    quot = n / 2;
                    rem += (n % 2).ToString();
                    n = quot;
                }
                for (int i = rem.Length - 1; i >= 0; i--)
                {
                    bin = bin + rem[i];
                }
                Console.ReadKey();
            }

            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }
            return Convert.ToInt64(bin);
        }

        //------------------------------------------------------------------------------------------------------------------
        public static long binaryToDecimal(long n)
        {
            long dec = 0;
            try
            {
                long bin, base_val = 1, rem;
                bin = n;
                while (n > 0)
                {
                    rem = n % 10;
                    dec = dec + (rem * base_val);
                    n = n / 10;
                    base_val = base_val * 2;
                }

                Console.ReadKey();


            }

            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }
            return dec;

        }
        //---------------------------------------------------------------------------------------------------------------

        public static void printTriangle(int n)
        {
            try
            {
                int Space, Number;

                for (int i = 1; i <= n; i++) // TOTAL NUMBER OF LAYERS FOR THE TRIANGLE PATTERN  
                {
                    for (Space = 1; Space <= (n - i); Space++) // LOOP FOR SPACE  
                        Console.Write(" ");
                    for (Number = 1; Number <= i; Number++) //INCREASES THE VALUE  
                        Console.Write('*');
                    for (Number = (i - 1); Number >= 1; Number--) //DECREASES THE VALUE  
                        Console.Write('*');
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        //------------------------------------------------------------------------------------------------------------

        public static void computeFrequency(int[] a)
        {
            try
            {

                int[] fr = new int[100];
                int i, j, ctr;
                Console.WriteLine("Number  Frequency");

                for (i = 0; i < a.Length; i++)
                {
                    fr[i] = -1;
                }
                for (i = 0; i < a.Length; i++)
                {
                    ctr = 1;
                    for (j = i + 1; j < a.Length; j++)
                    {

                        if (a[i] == a[j])
                        {
                            ctr++;
                            fr[j] = 0;
                        }
                    }


                    if (fr[i] != 0)
                    {
                        fr[i] = ctr;

                    }
                }
                for (i = 0; i < a.Length; i++)
                {
                    if (fr[i] != 0)
                    {
                        Console.WriteLine(a[i] + "           " + fr[i]);
                        ctr = 0;

                    }



                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

