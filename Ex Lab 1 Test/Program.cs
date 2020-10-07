using System;

namespace Ex_Lab_1_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // se dau 5 nr si se cere suma celor mai mari 3 dintre ele 
            // 2 3 5 3 7 => suma =14
            int a, b, c, d, e;

            Console.WriteLine("Introduceti numarul natural a");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            int max1, max2, max3, aux, aux2;

            max1 = a;
            max2 = b;
            max3 = c;
             // sortam cele 3 maxime
            if (max1 <= max2)

            {
                aux = max1;
                max1 = max2;
                max2 = aux;
            }

            if (max1 <= max3)
            {
                aux = max1;
                max1 = max3;
                max3 = aux;
            }

          

            if (max2 <= max3)
            {
                aux = max2;
                max2 = max3;
                max3 = aux;
            }

        // verificam sa vedem daca unul dintre nr d sau e este mai mare decat max, 
        //daca este mai mare decat max vom face interschimbarea intre max.

            if (max1 < d)
            {
                aux = max1;
                max1 = d;
                aux2 = max2;
                max2 = aux;
                max3 = aux2;
            }
            else
                if(max2 < d)
            {
                aux = max2;
                max2 = d;
                max3 = aux;
            }
            else
                if (max3 < d)
            {
                max3 = d;
            }
          
            if (max1 < e)
            {
                aux = max1;
                max1 = e;
                aux2 = max2;
                max2 = aux;
                max3 = aux2;
            }
            else
                if (max2 < e)
            {
                aux = max2;
                max2 = e;
                max3 = aux;
            }
            else
                if(max3 < e)
            {
                max3 = e;
            }
         // afisam de verificare cele 3 max finale
            Console.WriteLine("Maximul 1 = {0}", max1);
            Console.WriteLine("Maximul 2 = {0}", max2);
            Console.WriteLine("Maximul 3 = {0}", max3);
            // calculam suma celor 3 maxime din sir
            Console.WriteLine("Suma maximelor sirului este = {0}", max1 + max2 + max3);
        }

        }

    }

