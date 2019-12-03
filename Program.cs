using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            {
                do
                {
                    Console.WriteLine("Введите размер массива:");
                    var length_str = Console.ReadLine();
                    if (int.TryParse(length_str, out length))
                        break;
                    Console.WriteLine("Неверный формат числа");
                }
                while (true);

                var data = new int[length];
                var Rnd = new Random();
                for (int i = 0; i < length; i++)
                    data[i] = Rnd.Next(0, 101);
                PrintArray(data);
                SortArray(data);
                PrintArray(data);
            }
            static void PrintArray(int[] data)
            {
                Console.WriteLine("Размер массива {0}", data.Length);
                Console.WriteLine(new string('-', 20));
                for (var i = 0; i < data.Length; i++)
                    Console.WriteLine("data[{0}] = {1}", i, data[i]);
            }

            static void SortArray(int[] data)
            {
                var work = true;
                while (work)
                {
                    work = false;
                    for (var i = 0; i < data.Length - 1; i++)
                        if (data[i] > data[i + 1])
                        {
                            work = true;
                            var temp = data[i];
                            data[i] = data[i + 1];
                            data[i + 1] = temp;
                        }
                }
            }
        }
    }
}

