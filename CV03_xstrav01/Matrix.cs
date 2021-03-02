using System;
using System.Collections.Generic;
using System.Text;

namespace CV03_xstrav01
{
    class Matrix
    {
        protected double[,] matrix = null;

        public Matrix(double[,] matice)
        {
            this.matrix = matice;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {


            Matrix sum = new Matrix(new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
            try
            {
                if (a.matrix.GetLength(0) == b.matrix.GetLength(0) && a.matrix.GetLength(1) == b.matrix.GetLength(1))  // ověření stejných rozměrů matic
                {
                    for (int i = 0; i < a.matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.matrix.GetLength(1); j++)
                        {
                            sum.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];                                       // součet hodnot matic
                        }
                    }
                }
                else
                    new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("Dimenze matic se nerovnají! " + e.StackTrace);
            }

            return sum;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {


            Matrix sum = new Matrix(new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
            try
            {
                if (a.matrix.GetLength(0) == b.matrix.GetLength(0) && a.matrix.GetLength(1) == b.matrix.GetLength(1))
                {
                    for (int i = 0; i < a.matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.matrix.GetLength(1); j++)
                        {
                            sum.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                        }
                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Dimenze matic se nerovnají!");
            }

            return sum;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {

            Matrix c = new Matrix(new double[a.matrix.GetLength(0), b.matrix.GetLength(1)]);
            try
            {
                if (a.matrix.GetLength(0) == b.matrix.GetLength(1))
                {
                    for (int i = 0; i < a.matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < b.matrix.GetLength(1); j++)
                        {
                            c.matrix[i, j] = 0;
                            for (int k = 0; k < a.matrix.GetLength(1); k++)
                            {
                                c.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                            }
                        }
                    }
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Dimenze matic se nerovnají!");

            }

            return c;
        }

        public static Matrix operator -(Matrix a)
        {
            Matrix negate = new Matrix(a.matrix);
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    negate.matrix[i, j] = -negate.matrix[i, j];
                }
            }
            return negate;

        }

        //kontroluje rozměry a hodnoty
        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.matrix.GetLength(0) == b.matrix.GetLength(0) && a.matrix.GetLength(1) == b.matrix.GetLength(1))   // kontrola rozměrů
            {
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < b.matrix.GetLength(1); j++)
                    {
                        if (a.matrix[i, j] != b.matrix[i, j])                                                       // v případě, že se hdonoty matic nerovnají, vrací false                                                
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            return false;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0:F1}   ", matrix[i, j]));
                }
                Console.WriteLine("\n");
            }

            return "";
        }


        public void getDeterminant()
        {
            try
            {
                if (matrix.GetLength(0) == matrix.GetLength(1))
                {


                    switch (matrix.GetLength(0))
                    {

                        case 3:
                            double det3 = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[0, 2] * matrix[1, 0] * matrix[2, 1] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[0, 0] * matrix[1, 2] * matrix[2, 1] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2];
                            Console.WriteLine(string.Format("Determinant: {0:F1}", det3));

                            break;
                        case 2:
                            double det2 = matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
                            Console.WriteLine(string.Format("Determinant: {0:F1}", det2));
                            break;
                        case 1:
                            double det1 = matrix[0, 0];
                            Console.WriteLine(string.Format("Determinant: {0:F1}", det1));
                            break;
                        default:
                            Console.WriteLine("Matice má větší rozměry než umím spočítat.");
                            break;
                    }

                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Matice není čtvercová.");
                throw;
            }




        }


    }
}
