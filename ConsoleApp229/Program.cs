using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp229
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1000);
            int[] a = new int[10];
            string[] b = new string[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                fillter(a[i], ref b[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
        static void fillter(int numb, ref string m)
        {
            if (numb > 5)
            {
                m = "good";
            }
           
      }
    }
}
