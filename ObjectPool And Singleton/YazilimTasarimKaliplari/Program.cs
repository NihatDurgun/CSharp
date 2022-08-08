using System;
using System.Collections.Generic;
using System.Threading;

namespace YazilimTasarimKaliplari
{

    class Program
    {
        static int[] GenerateResult;
        static void Main(string[] args)
        {
            GenerateResult = new int[15];
            Array.Clear(GenerateResult, 0, GenerateResult.Length);
            Queue<Singleton> list = Singleton.getQueue();

            List<Thread> threads = new List<Thread>();

            while(true) {
                for (int i = 0; i < 15; i++)
                {
                    if (GenerateResult[i] == 0)
                    {
                        Thread thread = new Thread(new ParameterizedThreadStart(generateSingleton));
                        thread.Start(i);
                        threads.Add(thread);
                    }
                }

                Thread.Sleep(5000);
                bool isAllTrue = true;
                foreach (var value in GenerateResult)
                {
                    if (value != 1)
                    {
                        isAllTrue = false;
                        break;
                    }
                }
                if(isAllTrue == true) { break; }
            }
        }

        static void generateSingleton(object arg)
        {
            bool result = Singleton.Generate();
            Console.WriteLine("Generating Result: "+result);

            if (result == true)
            {
                GenerateResult[(int) arg] = 1; 
                //Console.WriteLine("Obj" + arg);
                Thread.Sleep(3000);
                var item = Singleton.GetItem();
                Console.WriteLine("Queue'den ayrılan obje: "+item);
            }
            
        }
    }
}


