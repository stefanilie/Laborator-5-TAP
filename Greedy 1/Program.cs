using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int>();
            List<int> B = new List<int>();
            int nALimit, nBLimit, aux;

            #region declaratii & citire variabile
            Console.WriteLine("Limita lui A:");
            nALimit = Convert.ToInt32(Console.ReadLine());
            aux = nALimit;
            while (nALimit > 0)
            {
                A.Add(Convert.ToInt32(Console.ReadLine()));
                nALimit--;
            }
            nALimit = aux;
            Console.WriteLine("Limita lui B:");
            nBLimit = Convert.ToInt32(Console.ReadLine());
            aux = nBLimit;
            while (nBLimit > 0)
            {
                B.Add(Convert.ToInt32(Console.ReadLine()));
                nBLimit--;
            }
            nBLimit = aux;
            #endregion

            int nSum = 0;
            int nSumLimit;
            #region sortarile
            var descendingA = A.OrderByDescending(c => c);
            var descendingB = B.OrderByDescending(i => i);
            Console.Write("A:");
            foreach (int i in descendingA)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nB:");
            foreach (int i in descendingB)
            {
                Console.Write(i + " ");
            }

            #endregion

            if (nALimit > nBLimit)
            {
                nSumLimit = nBLimit;
            }
            else
            {
                nSumLimit = nALimit;
            }

            for (int i = 0; i < nSumLimit; i++)
            {
                int aX =descendingA.ToArray<int>()[i];
                int bX = descendingB.ToArray<int>()[i];
                Console.WriteLine("nSum = " + nSum + "+" + aX + "*" + bX + ";");
                nSum = nSum + aX * bX;
            }

            Console.WriteLine(nSum);
                Console.ReadLine();
        }
    }
}
