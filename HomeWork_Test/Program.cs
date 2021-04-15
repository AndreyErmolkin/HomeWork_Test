using System;
using System.Collections.Generic;

namespace HomeWork_Test
{
    public class Array
    {
        public int[] array { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //Console.WriteLine("Введите размеры массива:");
            //int massive = int.Parse(Console.ReadLine());

            //Array array = new Array()
            //{
            //    array = new int[massive]
            //};
            //for (int i = 0; i < array.array.Length; i++)
            //{
            //    array.array[i] = random.Next(2, 101);
            //    for (int j = 0; j < array.array.Length; j++)
            //    {
            //        array.array[j] = random.Next(2, 101);
            //        if (array.array[i] % array.array[j] == 0)
            //        {
            //            Console.WriteLine($"Число номер {i} {array.array[i]} делится на число номер {j} {array.array[j]}");
            //        }

            //        if (array.array[j] % array.array[i] == 0)
            //        {
            //            Console.WriteLine($"Число номер {j} {array.array[j]} делится на число номер {i} {array.array[i]}");
            //        }
            //    }
            //    Console.WriteLine();
            var arr = new int[5] { 10, 15, 20, 40, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                  
                    if (arr[i] % arr[j] == 0)
                    {
                        Console.WriteLine($"Число номер {i} {arr[i]} делится на число номер {j} {arr[j]}");
                    }

                    if (arr[j] % arr[i] == 0)
                    {
                        Console.WriteLine($"Число номер {j} {arr[j]} делится на число номер {i} {arr[i]}");
                    }
                }
            }
        }
    }
}

