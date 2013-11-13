using System;
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
                        //TODO: aici e buba. Vezi ca nu iti intra pe while dupa ciire si iti baga reziduu in lista.
                        while (arrCoins.Last() % nIsRead != 0 && arrCoins.Last() < nIsRead)
                        {
                            Console.WriteLine("Wrong value. The coins can have only descending values and they have to be multiples.");
                            Console.WriteLine("Example: A = {10, 5, 1}; \n Retry:");
                            nIsRead = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    arrCoins.Add(nIsRead);
                }
            }

            Console.WriteLine("\n\nThis is the coin array: A = {");
            foreach (int parser in arrCoins)
            {
                if (parser != arrCoins.Last())
                    Console.Write(parser + ", ");
                else
                    Console.Write(parser);
            }
            Console.Write("}");
            Console.ReadLine();
        }
    }
}
