using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy_2
{
    class Cub
    {
        int nLenght;
        string strColor;

        public Cub()
        {
            this.nLenght = 0;
            this.strColor = "";
        }

        public Cub(int lenght, string color)
        {
            this.strColor = color;
            this.nLenght = lenght;
        }

        static void Main(string[] args)
        {
            List<Cub> tower = new List<Cub>();
            Console.WriteLine("Insert the height of the tower: ");
            int nHeight = Convert.ToInt32(Console.ReadLine());
            #region List Construction
            for (int i = 1; i<=nHeight; i++)
            {
                Console.WriteLine("Insert color: ");
                var isRead = Console.ReadLine();
                while(isRead == "" || (isRead.ToString() != "white" && isRead.ToString() != "black"))
                {
                    Console.WriteLine("Invalid entry for color. It must be a \"white\" or \"black\". Retry.");
                    isRead = Console.ReadLine();
                }

                string color = isRead;

                Console.WriteLine("Insert lenght: ");
                isRead = Console.ReadLine();
                while (Convert.ToInt32(isRead) <= 0)
                {
                    Console.WriteLine("Invalid entry for lenght. It must be a number > 0. Retry.");
                    isRead = Console.ReadLine();
                }

                int lenght = Convert.ToInt32(isRead);

                Cub temp = new Cub(lenght, color);
                tower.Add(temp);
#endregion
            }

            var orderedTower = tower.OrderBy(x => x.nLenght);

            foreach(Cub cub in tower)
            {
                Console.WriteLine("Lenght: " + cub.nLenght + " with Color: " + cub.strColor);
            }

            Console.WriteLine("\n\nOrdonat:");

            foreach (Cub cub in orderedTower)
            {
                Console.WriteLine("Lenght: " + cub.nLenght + " with Color: " + cub.strColor);
            }

            Console.ReadLine();
        }
    }
}
