using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // z 1
            //int[] array = new int[15];
            //Random rnd = new Random();
            //for(int i=0;i<array.Length;i++)
            //{
            //    array[i] = rnd.Next(-50, 50);
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //byte count = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i]%3==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Кол-во эл массива,кратных 3= {count}");

            //z2
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 100);
                Console.WriteLine($"array[{i}]={array[i]}");
            }
            int max = array[0]; int index1 = 0;
            int min = array[0]; int index2 = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index1 = i;
                }
            }
            Console.WriteLine($"max={max};index1= {index1}");
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index2 = i;
                }
            }
            Console.WriteLine($"min={min};index2={index2}");
            int p;
            p = array[index1];
            array[index1] = array[index2];
            array[index2] = p;
            for (int i = 0; i <= array.Length; i++)
            {
                Console.WriteLine($"array[{i}]= {array[i]}");
            }
            //z 3 
            //double[] array = new double[31];
            //Random rand = new Random();
            /////<summary>
            ///// Заполняем случайным образом
            ///// </summary>
            //for(byte i =0;i<array.Length;i++)
            //{
            //    array[i] = 60+5*rand.NextDouble();
            //    Console.WriteLine($"array[{i}]={array[i]:f2}");
            //}
            //double sum = 0;
            /////<summary>
            /////Накопление суммы 
            ///// </summary>
            //for (byte i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}
            //Console.WriteLine($"Среднее значения курса валюты= {(double)sum / array.Length:f2}");
            /////<summary>
            ///// Максимальный и минимальный 
            ///// </summary>
            //double min = array[0];
            //byte indexMin = 0;
            //double max = array[0];
            //byte indexMax = 0;
            //for (byte i = 1; i < array.Length; i++)
            //{
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //        indexMin = i;
            //    }
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //        indexMax = i;
            //    }

            //}
            //Console.WriteLine($"Самый низкий курс валюты= {min:f2}\t Дата:{indexMin}\nСамый высокий курс валюты= {max:f2}\t Дата:{indexMax}");
            //Console.ReadKey();
            // Сортировка по возратсанию
            //int[] array = { -5, 1, 9, 0, 4, -4, 3 };
            //for(int i=0;i<array.Length-1;i++)
            //{
            //    for(int j=i+1;j<array.Length;j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            int p = array[i];
            //            array[i] = array[j];
            //            array[j] = p;
            //        }
            //    }
            //}

            //Array.Sort(array);
            //foreach(int elem in array)
            //{
            //    Console.Write($"{elem}\t");
            //}
            //Console.WriteLine();
            //Array.Reverse(array);
            //foreach (int elem in array)
            //{
            //    Console.Write($"{elem}\t");
            //}
            Console.ReadKey();
        }
    }
}
