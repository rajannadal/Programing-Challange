using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call below method to explore this operations

        }

        // Get Primer Number From Given array
        static void GetPrimeNumber(int input1)
        {
            string[] strings = new string[] { "77", "4", "5", "2", "3", "7", "9" };
            int[] intarray = Array.ConvertAll<string, int>(strings, int.Parse);
            bool isprime = true;
            foreach (var input in intarray)
            {


                for (int i = 2; i <= input / 2; i++)
                {
                    var result = input % i;
                    if (result == 0)
                    {
                        Console.WriteLine(input + " divide by number is " + i);
                        isprime = false;

                        break;
                    }
                }
                if (isprime)

                    Console.WriteLine(input + " This is Prime Number");
                else
                    Console.WriteLine(input + " This is not an Prime Number");
                isprime = true;
            }

        }
        // Sort the Given array
        static void SortGivenArray()
        {
            string[] strings = new string[] { "77", "4", "5", "2", "3", "7", "9" };
            int[] arrayint = Array.ConvertAll<string, int>(strings, int.Parse);
            int temp = 0;
            for (int i = 0; i <= arrayint.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayint.Length; j++)
                {
                    if (arrayint[i] < arrayint[j])
                    {
                        temp = arrayint[i];
                        arrayint[i] = arrayint[j];
                        arrayint[j] = temp;
                    }

                }
            }
            foreach (var dat in arrayint)
            {
                Console.WriteLine(dat);
            }

        }
        // sum of Previous Number
        static void GetSumofPreviousNumber(int input1)
        {
            int sum = 0;
            for (int i = 1; i <= input1; i++)
            {
                sum = sum + i;

            }

            Console.WriteLine("The sum of number is " + sum);
        }

        // String Reverse

        static void Gestringreverse()
        {
            string strval = "Hi this is rajan";
            string rev = "";
            for (int i = strval.Length - 1; i >= 0; i--)
            {
                rev = rev + strval[i];

            }

            Console.WriteLine(rev);
        }

        // Given A[] Sum check with given input X
        private static void GetSumcheck(int[] A, int x)
            {

                for (int i = 0; i <= A.Length-1; i++)
                {
                    for (int j = i + 1; j <= A.Length-1; j++)
                    {
                        int sum = A[i] + A[j];
                        if (x == sum)
                        {
                            Console.WriteLine("Output:" +A[i] + "," + A[j]);
                        }
                    }
                }
                Console.ReadLine();
            }

        // Get Fibno SeriesNumber input X
        static void GetFibnoSeriesNumber(int input1) // 1,1,2,3,5,8,13...
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            for (int i = 0; i < input1; i++)
            {
                //n3 = n1;
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;

            }
        }

        // Sum the value without using arithmetic operation
        static int Addwithoutathirmetic(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return Addwithoutathirmetic(x ^ y, (x & y) << 1);
        }
    }


  
    
}
