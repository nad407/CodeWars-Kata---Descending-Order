using System;
using System.Collections.Generic;
using System.Linq;

namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
           int number = Descending(6457328);
           Console.WriteLine(number);
           Console.ReadKey();
        }

        public static int Descending(int n)
        {
            List<int> numbers = new List<int>();
            int result=0;
           

            if (n <= 0) 
            {
                return 0;
            }
            else
            {
                while (n > 0)
                {
                    int rem = n % 10;
                    numbers.Add(rem);
                    n = n / 10;
                }

                var listDesc =numbers.OrderByDescending(i => i);
                numbers = listDesc.ToList();
                foreach(int num in numbers)
                {
                    result = 10 * result + num;
                }
                return result;
                /*
                do
                {
                    swap = false;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if ((i + 1) < numbers.Count)
                        {
                            if (numbers[i] > numbers[i + 1])
                            {
                                temp = numbers[i];
                                swap = true;
                                numbers[i] = numbers[i + 1];
                                numbers[i + 1] = temp;
                            }
                        }
                    }
                } while (swap == true);

                int [] listAsArray = numbers.ToArray();
                int listAsInt = listAsArray.Length;
                return listAsInt;*/

            }

        }
    }
}
