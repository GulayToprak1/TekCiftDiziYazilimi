using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekCiftDiziYazilimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int[] tekdizi = new int[sayi / 2 + 1];
            int[] ciftdizi = new int[sayi / 2 + 1];

            int tek = 0;
            int cift = 0;

            for (int i = 0; i < sayi; i++)
            {
                if (i % 2 == 0)
                {
                    ciftdizi[cift] = i;
                    cift++;
                }
                else
                {
                    tekdizi[tek] = i;
                    tek++;
                }
            }
            Array.Sort(tekdizi, 0, tek);
            Array.Sort(ciftdizi, 0, cift, Comparer<int>.Create((a, b) => b.CompareTo(a)));

            Console.WriteLine("Tek Sayılar: ");
            for (int i = 0; i < tek; i++)
            {
                Console.Write(tekdizi[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Cift Sayılar: ");
            for (int i = 0; i < cift; i++)
            {
                Console.Write(ciftdizi[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
