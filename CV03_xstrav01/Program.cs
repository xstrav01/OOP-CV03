using System;

namespace CV03_xstrav01
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix a = new Matrix(new double[,] { { 1.0, 1.0, 1.0 }, { 1.0, 1.0, 1.0}, { 1.0, 1.0, 1.0} });
            Matrix b = new Matrix(new double[,] { { 2.0, 2.0, 2.0 }, { 2.0, 2.0, 2.0 }, { 2.0, 2.0, 2.0 } });
            Matrix c = new Matrix(new double[,] { { 3.0, 3.0, 3.0 }, { 4.0, 5.0, 6.0 }, { 1.0, 2.0, 1.0 } });
            Matrix d = new Matrix(new double[,] { { 1.0, 2.0 }, { 4.0, 5.0 } }); 
            Matrix e = new Matrix(new double[,] { { 10.0, 15.0, 3.5 }, { 4.0, 1.0, 7.0 }, { 5.0, 5.5, -1.0 } }); 

            Console.WriteLine("Matice A:");
            Console.WriteLine(a.ToString());
            Console.WriteLine("Matice B:");
            Console.WriteLine(b.ToString());
            Console.WriteLine("Matice C:");
            Console.WriteLine(c.ToString());
            Console.WriteLine("Matice D:");
            Console.WriteLine(d.ToString());
            Console.WriteLine("Matice E:");
            Console.WriteLine(e.ToString());

            Console.WriteLine("Součet matice A a B:");          // +
            Console.WriteLine((a + b).ToString());              
            Console.WriteLine("Rozdíl matice A a B:");          // -
            Console.WriteLine((a - b).ToString());  
            Console.WriteLine("Násobení matice A a B:");        // *           =  6 6 6
            Console.WriteLine((a * b).ToString());              //                6 6 6
            Console.WriteLine("Porovnání matice A a B: ");      //                6 6 6
            Console.WriteLine("Shodné ==: " + (a == b));        // ==
            Console.WriteLine("Neshodné !=: " + (a != b));      // !=    
            Console.WriteLine("\nNegace matice C:");            // negate
            Console.WriteLine((-c).ToString());
            Console.WriteLine("Determinant matice D(2D):");     // determinant = -3
            d.getDeterminant();
            Console.WriteLine("\nDeterminant matice E(3D):");   // determinant = 249,5
            e.getDeterminant();
            Console.WriteLine("\nVyjímka test: ");
            Console.WriteLine((a * d).ToString());
            



        }
    }
}
