using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n;
            Console.Write("Введите размер массива: ");
            n = byte.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Вводите элементы массива: ");
            for (byte i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Четные элементы массива: ");
            for (byte i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.WriteLine(arr[i]);                
            }

            Console.Write("Нечетные элементы массива: ");
            for (byte i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.WriteLine(arr[i]);
            }

        }
    }
}
