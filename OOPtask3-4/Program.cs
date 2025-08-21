using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3rdOOPtasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
             point3d point1 = new point3d(5, 3, 6);
             point3d point2 = new point3d();
             point2.x = Convert.ToInt32(Console.ReadLine());
             point2.y = Convert.ToInt32(Console.ReadLine());
             point2.z = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine(point1.ToString());

             Console.WriteLine(point2.ToString());

             if (point1 == point2)
                 Console.WriteLine("the two objects are equal");
             else
                 Console.WriteLine("the two objects are not equal");

             point3d.arr = new point3d[] { point1, point2 };

             Array.Sort(point3d.arr);
             for(int i =0;i<2;i++)
             Console.WriteLine(point3d.arr[i].ToString());
               

            Duration D1 = new Duration(1, 45, 3);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            Console.WriteLine("\n--- Operators ---");

            D3 = D1 + D2;
            Console.WriteLine("D3 = D1 + D2 → " + D3);

            D3 = D1 + 7800;
            Console.WriteLine("D3 = D1 + 7800 → " + D3);

            D3 = 666 + D3;
            Console.WriteLine("D3 = 666 + D3 → " + D3);

            D3 = ++D1;
            Console.WriteLine("D3 = ++D1 (add 1 minute) → " + D3);

            D3 = --D2;
            Console.WriteLine("D3 = --D2 (subtract 1 minute) → " + D3);

  

            // Comparisons
            Console.WriteLine("\n--- Comparisons ---");

            if (D1 > D2) Console.WriteLine("D1 is greater than D2");
            if (D1 <= D2) Console.WriteLine("D1 is less than or equal to D2");


            // DateTime
            Console.WriteLine("\n--- Casting ---");

            DateTime obj = (DateTime)D1;
            Console.WriteLine("DateTime from D1: " + obj);

        }

    }
}
