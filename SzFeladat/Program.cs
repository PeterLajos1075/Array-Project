using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace SzFeladat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SingleArray();
            Console.WriteLine("");
            MultiArray();
            Console.ReadKey();
        }

        public static void SingleArray()
        {
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var totalElements = weekdays.Count();

            Console.Write("A tömb elemei: ");
            for (int i = 0; i < totalElements; i++)
            {
                Console.Write(weekdays[i] + "    ");
            }
            Console.WriteLine("");
        }

        public static void MultiArray()
        {
            string[] weekdays = { "X", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //var totalElements = weekdays.Count();

            int[] hour = new int[9];
            var totalhours = hour.Length;
            for (int i = 0; i < hour.Length; i++)
            {
                hour[i] = i;
            }

            string[] Subject = { "mathematics", "Physics", "Testnev.", "Informatics", "English", "History", "Literature", "Grammer", "Geography" };
            Random randomWithSeed = new Random();


            object[,] matrix = new object[9, 8];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 6 || j == 7)
                    {
                        matrix[i, j] = "X";
                    }

                    else
                    {
                       int randomNumberWithSeed = randomWithSeed.Next(0, 8);
                       matrix[i, j] = Subject[randomNumberWithSeed];
                    }
                }
            }
            for (int hours = 0; hours < totalhours ; hours++)
            {
                matrix[hours,0] = hour[hours];
            }
            


            Console.WriteLine("Órarend: ");
            Console.WriteLine(new string('-', weekdays.Length * 9 + 3));
            Console.WriteLine($"| {string.Join(" | ", weekdays)} |");
            Console.WriteLine(new string('-', weekdays.Length * 9 + 3));

            /*for (int i = 0; i <  matrix.GetLength(0); i++)
            {
                for (int j = 0;  j < matrix.GetLength(1) ; j++)
                {
                    Console.WriteLine(matrix[i,j]);

                }
            }*/

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine($"| {string.Join(" | ", GetRow(matrix, i))} |"); 
                Console.WriteLine(new string('-', weekdays.Length * 9 + 1));

            }
            /*HashSet<object> uniqueSubject = new HashSet<object>();
            foreach(var subject  in matrix)
            {
                if(uniqueSubject.Add(subject))
                {
                    Console.WriteLine(subject);
                }

            )*/



            Console.ReadLine();
        }

        static object[] GetRow(object[,] array, int row = 0)
        {
            object[] rowData = new object[array.GetLength(1)];
            for(int i = 0; i < array.GetLength(1); i++)
            {
                rowData[i] = array[row,i];
            }
            return rowData;
        }


        public static void ThreeDArray()
        {

            Console.WriteLine();
        }

    }
}
