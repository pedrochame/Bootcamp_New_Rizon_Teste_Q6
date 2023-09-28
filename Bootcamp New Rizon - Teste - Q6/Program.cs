using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_New_Rizon___Teste___Q6
{
    internal class Program
    {

        static string wallpaper(int a, int l)
        {
            string w = "";
            int p;
            for (int k = 1; k <= a; k++)
            {
                if (k % 2 == 0)
                {
                    p = 1;
                }
                else
                {
                    p = 0;
                }
                for (int i = 1; i <= l; i++)
                {
                    if (i == l)
                    {
                        w += p + "\n";
                    }
                    else
                    {
                        w += p;
                    }
                    if (k % 2 != 0) {
                        if (i % 2 == 0)
                        {
                            p--;
                        }
                        else
                        {
                            p++;
                        }
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            p++;
                        }
                        else
                        {
                            p--;
                        }
                    }
                }
            }
            return w;
        }
        static void Main(string[] args)
        {

            Console.Write("Altura: ");
            int altura = int.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            int largura = int.Parse(Console.ReadLine());
            Console.Write('\n' + wallpaper(altura, largura));
            Console.ReadLine();


        }
    }
}