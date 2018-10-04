using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Soarc.Workshops.AlgorithmsAndDatastructures
{
    class Program
    {
        const int DATA_LENGHT = 100000000;
        async static Task Main(string[] args)
        {
            GraphAlgorithms.Run();
            Console.WriteLine($"Starting test Quick sort VS Bubble sort for {DATA_LENGHT} element array.");

            var random = new Random();
            var data1 = new int[DATA_LENGHT];
            var data2 = new int[DATA_LENGHT];
            for (var i = 0; i < data1.Length; i++)
            {
                data1[i] = data2[i] = random.Next();
            }
            var sw1 = new Stopwatch();
            var sw2 = new Stopwatch();
            var sw3 = new Stopwatch();
            var taskQuick = Task.Run(() =>
              {
                  Console.WriteLine("Quick sort testing started.");
                  sw1.Start();
                  QuickSort.DoSort(data1);
                  sw1.Stop();
                  Console.WriteLine($"Quick sort done: {sw1.ElapsedMilliseconds} milliseconds elapsed");
              });

            var taskBubble = Task.Run(() =>
            {
                Console.WriteLine("Bubble sort testing started.");
                sw2.Start();
                //BubbleSort.DoSort(data2);
                sw2.Stop();
                Console.WriteLine($"Bubble sort done: {sw2.ElapsedMilliseconds} milliseconds elapsed.");
            });

            //for (int i = 0; i < data.Length; i++)
            //{
            //    Console.Write($"{data[i]} ");

            //}

            await Task.WhenAll(taskBubble, taskQuick);
            Console.WriteLine("Sorting done. Checking results...");
            sw3.Start();
            for (int i = 0; i < DATA_LENGHT - 1; i++)
            {
                if (data1[i] > data1[i + 1])
                {
                    Console.WriteLine("Quick sort results are wrong. Check your implementation");
                    break;
                }
            }
            sw3.Stop();

            Console.WriteLine("Quick sort is OK.");
            sw3.Start();
            for (int i = 0; i < DATA_LENGHT - 1; i++)
            {
                if (data2[i] > data2[i + 1])
                {
                    Console.WriteLine("Bubble sort results are wrong. Check your implementation");
                    break;
                }

            }
            sw3.Stop();
            Console.WriteLine("Bubble sort is OK.");
            Console.WriteLine($"Checking done in {sw3.ElapsedMilliseconds} milliseconds.");
            Console.WriteLine("Testing done.");

            Console.ReadLine();
        }
    }
}
