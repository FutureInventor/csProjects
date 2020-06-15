using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp3
{

    class Program
    {

        static void Main(string[] args)
        {

            //amount of particles

            int rows1 = 1;
            int columns1 = 3;
            string[] tab1 = File.ReadAllLines("data.txt");
            int[,] matrix1 = new int[rows1, columns1];
            for (int i = 0; i < 1; i++)
            {
                string[] tmp1 = tab1[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < tmp1.Length; j++)
                {
                    matrix1[i, j] = int.Parse(tmp1[j]);
                }
            }

            //vector S

            int startIndex1 = 1;
            int lenght1 = 125000;
            int rows2 = 125000;
            int columns2 = 3;
            string[] tab_2 = File.ReadAllLines("data.txt");
            var tab2 = tab_2.Skip(startIndex1).Take(lenght1).ToArray();
            double[,] matrix2 = new double[rows2, columns2];
            for (int i = 0; i < 125000; i++)
            {
                string[] tmp2 = tab2[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < tmp2.Length; j++)
                {
                    matrix2[i, j] = Double.Parse(tmp2[j], CultureInfo.InvariantCulture);
                }
            }


            //position

            int startIndex2 = 125001;
            int lenght2 = 125000;
            int rows3 = 125000;
            int columns3 = 3;
            string[] tab_3 = File.ReadAllLines("data.txt");
            var tab3 = tab_3.Skip(startIndex2).Take(lenght2).ToArray();
            double[,] matrix3 = new double[rows3, columns3];
            for (int i = 0; i < 125000; i++)
            {
                string[] tmp3 = tab3[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < tmp3.Length; j++)
                {
                    matrix3[i, j] = Double.Parse(tmp3[j], CultureInfo.InvariantCulture);
                }
            }


            //vector K 

            int startIndex3 = 250001;
            int lenght3 = 125000;
            int rows4 = 125000;
            int columns4 = 3;
            string[] tab_4 = File.ReadAllLines("data.txt");
            var tab4 = tab_4.Skip(startIndex3).Take(lenght3).ToArray();
            double[,] matrix4 = new double[rows4, columns4];
            for (int i = 0; i < 125000; i++)
            {
                string[] tmp4 = tab4[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < tmp4.Length; j++)
                {
                    matrix4[i, j] = Double.Parse(tmp4[j], CultureInfo.InvariantCulture);
                }
            }


            // vector S, K 

            int startIndex4 = 375001;
            int lenght4 = 125000;
            int rows5 = 125000;
            int columns5 = 2;
            string[] tab_5 = File.ReadAllLines("data.txt");
            var tab5 = tab_5.Skip(startIndex4).Take(lenght4).ToArray();
            double[,] matrix5 = new double[rows5, columns5];
            for (int i = 0; i < 125000; i++)
            {
                string[] tmp5 = tab5[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < tmp5.Length; j++)
                {
                    matrix5[i, j] = Double.Parse(tmp5[j], CultureInfo.InvariantCulture);
                }
            }


            // vector I 

            int startIndex5 = 500001;
            int lenght5 = 125000;
            int rows6 = 125000;
            int columns6 = 6;
            string[] tab_6 = File.ReadAllLines("data.txt");
            var tab6 = tab_6.Skip(startIndex5).Take(lenght5).ToArray();
            double[,] matrix6 = new double[rows6, columns6];
            for (int i = 0; i < 125000; i++)
            {
                string[] tmp6 = tab6[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < tmp6.Length; j++)
                {
                    matrix6[i, j] = Double.Parse(tmp6[j], CultureInfo.InvariantCulture);
                }
            }

            //S
            int count = matrix2.Length;
            Console.WriteLine(count);
            //position
            int count2 = matrix3.Length;
            Console.WriteLine(count2);
            //K
            int count3 = matrix4.Length;
            Console.WriteLine(count3);
            //S, K
            int count4 = matrix5.Length;
            Console.WriteLine(count4);
            //I
            int count5 = matrix6.Length;
            Console.WriteLine(count5);
            Console.ReadKey();



        }
    }
}
