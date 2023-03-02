using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FacAsync(n);
        }
        static void Fac(int n)
        {
            int f = 1;
            for (int i = 1; i < n; i++)
            {
                f *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(f);
        }
        static async void FacAsync(int n)
        {
            await Task.Run(() => Fac(n));
        }
    }
}