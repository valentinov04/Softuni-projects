using System;
using System.Collections.Generic;
using System.Linq;

namespace stack_and_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfClothes = Console.ReadLine()
                                 .Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>();
            int counter = 0;
            int sum = 0;
            for (int i = 0; i < numberOfClothes.Length; i++)
            {
                clothes.Push(numberOfClothes[i]);
            }
            for (int i = 0; i < numberOfClothes.Length; i++)
            {
                int currentsNumberOfClothes = clothes.Peek();
                int currentSum = sum + currentsNumberOfClothes;
                if (currentSum <= capacity)
                {

                    sum += clothes.Pop();
                    currentSum = 0;
                }
                else if (currentSum > capacity)
                {
                    sum = 0;
                    currentSum = 0;
                    sum += clothes.Pop();
                    counter++;
                }
            }
            Console.WriteLine(counter+1);
        }
    }
}
