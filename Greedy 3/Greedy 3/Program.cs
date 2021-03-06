﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrCoins = new List<int>();
            int nIsRead = -1;
            while(nIsRead != 0)
            {
                Console.WriteLine("Insert the coin value. ");
                Console.WriteLine("To end the reading process enter 0.");
                nIsRead = Convert.ToInt32(Console.ReadLine());
                if (nIsRead != 0 && arrCoins.Count == 0)
                {
                    arrCoins.Add(nIsRead);
                }
                else if (nIsRead != 0 && arrCoins.Count > 0)
                {
                    if (arrCoins.Last() % nIsRead != 0 || arrCoins.Last() < nIsRead || arrCoins.Contains(nIsRead))
                    {
                        Console.WriteLine("Wrong value. The coins can have only descending values and they have to be multiples.");
                        Console.WriteLine("Example: A = {10, 5, 1}; \n Retry:");
                        nIsRead = Convert.ToInt32(Console.ReadLine());

                        while (nIsRead == 0 || arrCoins.Last() % nIsRead != 0 || arrCoins.Last() < nIsRead || arrCoins.Contains(nIsRead))
                        {
                            Console.WriteLine("Wrong value. The coins can have only descending values and they have to be multiples.");
                            Console.WriteLine("Example: A = {10, 5, 1}; \n Retry:");
                            nIsRead = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    arrCoins.Add(nIsRead);
                }
            }

            Console.Write("\n\nThis is the coin array: A = {");
            foreach (int parser in arrCoins)
            {
                if (parser != arrCoins.Last())
                    Console.Write(parser + ", ");
                else
                    Console.Write(parser);
            }
            Console.Write("}");

            Console.WriteLine("\nGood. Now insert the sum of money you want to pay");

            nIsRead = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[arrCoins.Count];
            int nCounter = 0;

            foreach(int parser in arrCoins)
            {
                while(nIsRead - parser >= 0)
                {
                    nIsRead -= parser;
                    arr[arrCoins.IndexOf(parser)]++;
                }
            }

            Console.Write("You will pay this way:");
            
            foreach(int parser in arrCoins)
            {
                if (arr[arrCoins.IndexOf(parser)] != 0)
                {
                    if (arr[arrCoins.IndexOf(parser)] != arr.Last())
                        Console.Write(arr[arrCoins.IndexOf(parser)] + "x" + parser + "$  ");
                }
            }

                Console.ReadLine();
        }
    }
}