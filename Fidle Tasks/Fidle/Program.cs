using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Fidle
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int numN = 5000;

            var list = new List<int>(numN);

            var sb = new StringBuilder(); //"1 2 1 2 1 2 4 2 6 3 2 1 4"
            for (int i = 0; i < numN; i++)
            {
                sb.Append($"{rand.Next(numN)} ");
            }

            //string inputString = "1 4 2 6 3 4";
            //string inputString = "1 1 1 1 1";
            //Console.WriteLine(inputString);
            string inputString = sb.ToString();
            Console.WriteLine("Input: " + inputString.Substring(0, 50));
            var watch = new System.Diagnostics.Stopwatch();

            List<int> resultSlow;
            List<int> resultFast;


            resultSlow = Program.slow(inputString);
            watch.Start();
            resultFast = Program.fast(inputString);
            watch.Stop();

            if (!Enumerable.SequenceEqual(resultSlow, resultFast))
            {
                Console.WriteLine("Error!!! Not Equal results!");
            }

            Console.WriteLine("Max Jumps: " + resultSlow.Max());
            Console.WriteLine("Jumps: " + string.Join(" ", resultSlow.Take(20)));

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        static new List<int> fast(String inputNumbers)
        {
            var numbers = inputNumbers.Trim().Split().Select(int.Parse).ToArray();
            int numN = numbers.Count();
            //
            //var jumplist = new List<int>(new int[numN]);
            //jumplist = Program.slow(inputNumbers);
            //
            //return jumplist;
            var jumps = new int[numN];
            int maxValue = numbers[numbers.Length - 1];
            for (int i = jumps.Length - 2; i >= 0; i--)
            {
                int current = numbers[i];
                bool stop = false;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int next = numbers[j];
                    if (current < next)
                    {
                        jumps[i] = jumps[j] + 1;
                        stop = true;
                    }
                    else if (current == next)
                    {
                        jumps[i] = jumps[j];
                        stop = true;
                    }

                    if (stop)
                    {
                        break;
                    }
                }
            }

            return jumps.ToList();
        }

        static new List<int> slow(String inputNumbers)
        {
            var numbers = inputNumbers.Trim().Split().Select(int.Parse).ToArray();
            int numN = numbers.Count();

            int initialJump = 0;
            int next = 0;

            var list = new List<int>(numN);

            int counter = 0, max = numbers.Max();
            for (int i = 0; i < numN; i++)
            {
                initialJump = numbers[i];
                // partial optimization
                if (initialJump == max)
                {
                    list.Add(0);
                    continue;
                }
                for (int j = i + 1; j < numN; j++)
                {
                    next = numbers[j];
                    if (initialJump < next)
                    {
                        counter++;
                        initialJump = next;
                    }
                }
                list.Add(counter);
                counter = 0;
            }

            return list;

        }

        /*
         Jumps
 
Given a sequence of elements(numbers), calculate the longest possible sequence of 'jumps' from each number.
 
Each 'jump' must be made according to the following rules:
 
    You can only 'jump' on a number that is greater than the current one;
    You can 'jump' on a number, only if there isn't one with a greater value between;
    You can 'jump' only from left to right;
 
Input
 
Read from the standard input
 
    On the first line, you will find the number N
        The number of elements
    On the second line you will find N numbers, separated by a space
        The elements themselves
 
The input will be correct and in the described format, so there is no need to check it explicitly.
Output
 
Print to the standard output
 
    On the first line, print the length of the longest sequence of jumps
    On the second line, print the lengths of the sequences, starting from each element
 
Constraints
 
    The N will always be less than 50000
 
Sample Tests
Input
 
1 4 2 6 3 4
 
Output
 
2 1 1 0 1 0
 
Explanation
 
    Element 1:
        1 -> 4 -> 6 (2 jumps)
    Element 2:
        4 -> 6 (1 jump)
    Element 3:
        2 -> 6 (1 jump)
    Element 4:
        6 (0 jumps)
    Element 5:
        3 -> 4 (1 jump)
    Element 6:
        4 -> (0 jumps)
 
Input
 
1 1 1 1 1
 
Output
 
0 0 0 0 0
         * */


    }
}

