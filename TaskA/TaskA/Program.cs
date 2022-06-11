using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskA
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            static List<int> generateRandomList(int n)
            {
                Random random = new Random();
                int stopCondition = 0;
                List<int> randomList = new List<int> { };

                while (stopCondition <= n)
                {
                    randomList.Add(random.Next(1, n+1));
                    stopCondition++;
                }

                return randomList;
            }

            static void findRepeatedNumbers(int n) {

                var randomList = generateRandomList(n);

                Console.WriteLine("List created with length of: " + n + "\n");

                foreach (int number in randomList) {
                    Console.WriteLine(number);
                }

                var repeatedList = randomList.GroupBy(x => x)
                    .Where(g => g.Count() > 1)
                    .Select(y => y.Key)
                    .ToList();

                if (repeatedList.Count > 0)
                {
                    Console.WriteLine("\nList of repeated elements:\n");

                    foreach (int number in repeatedList)
                    {
                        Console.WriteLine(number);
                    }

                }
                else {
                    Console.WriteLine("No repeated numbers found.");
                }

                }
            findRepeatedNumbers(5);
            }
            
        }

    }
