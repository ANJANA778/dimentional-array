using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimentional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,s;
            Console.WriteLine("enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("enter the array elements");
            for(int i=0;i<n;i++)//index
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
                s = s + ar[i];
            }
            Console.WriteLine("the array elements");
            for(int i=0;i<n;i++)//index
            {
                Console.WriteLine(ar[i]);
            }
            Console.WriteLine("sum is:{0}");
            Console.ReadKey();
        }
    }
}
