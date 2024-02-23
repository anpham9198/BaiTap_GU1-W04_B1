using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_GU1_W04_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 7, 8, 9 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write("Tong cac phan tu = " + sum);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
