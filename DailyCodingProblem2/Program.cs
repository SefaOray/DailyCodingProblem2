using System;
using System.Collections.Generic;

namespace DailyCodingProblem2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] GetProduct(int[] numbers)
        {
            var resultList = new List<int>(numbers.Length);


            for (int i = 0; i < numbers.Length; i++)
            {
                int? product = null;
                
                for(int i2 = 0; i2 < numbers.Length; i2++)
                {
                    if (i2 == resultList.Count)
                        continue;

                    product = product.HasValue ? product * numbers[i2] : numbers[i2];
                }

                resultList.Add(product.Value);
            }

            return resultList.ToArray();
        }
    }
}
