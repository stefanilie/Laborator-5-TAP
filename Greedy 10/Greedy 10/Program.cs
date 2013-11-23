using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nList = new List<int>();
            Console.WriteLine("Insert the number of elements. It must be an even number! ");
            int nSize = Convert.ToInt32(Console.ReadLine());
            while(nSize%2 != 0)
            {
                Console.WriteLine("Wrong value. IT MUST BE EVEN! Try again: ");
                nSize = Convert.ToInt32(Console.ReadLine());
            }
            
            while(nSize != 0)
            {
                Console.WriteLine(nSize + " elements remaining to insert ");
                nList.Add(Convert.ToInt32(Console.ReadLine()));
                nSize--;
            }

            int nEvenSum = 0, nOddSum = 0;
            List<int> listEven = new List<int>();
            List<int> listOdd = new List<int>();


            foreach(int parser in nList)
            {
                nSize = nList.IndexOf(parser);
                if((nSize + 1)%2 == 0)
                {
                    nEvenSum += nSize;
                    listEven.Add(parser);
                }
                else
                {
                    nOddSum += nSize;
                    listOdd.Add(parser);
                }
            }
            #region ifCases
            if (nEvenSum > nOddSum)
            {
                Console.Write("\nThe first player will choose the following elements: ");
                foreach(int parser in listEven)
                {
                    Console.Write(parser + " ");
                }
                Console.Write("and the sum will be " + nEvenSum);
            }
            else if(nEvenSum < nOddSum)
            {
                Console.Write("\nThe first player will choose the following elements: ");
                foreach(int parser in listOdd)
                {
                    Console.Write(parser + " ");
                }
                Console.Write("and the sum will be " + nOddSum);
            }
            else if(nEvenSum == nOddSum)
            {
                Random rand = new Random();
                int nRand = rand.Next(1,100);
                if(nRand % 2 == 0)
                {
                    Console.Write("\nThe first player will choose the following elements: ");
                    foreach (int parser in listEven)
                    {
                        Console.Write(parser + " ");
                    }
                    Console.Write("and the sum will be " + nEvenSum);
                }
                else
                {
                    Console.Write("\nThe first player will choose the following elements: ");
                    foreach (int parser in listOdd)
                    {
                        Console.Write(parser + " ");
                    }
                    Console.Write("and the sum will be " + nOddSum);
                }
            }
            #endregion
            Console.Read();

        }
    }
}
