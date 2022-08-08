using System;
using System.Collections.Generic;

namespace YazilimTasarimKaliplari
{
    class Singleton
    {
        private static Singleton _instance;
        private static Object thisLock = new Object();
        private static Queue<Singleton> items;

        private static int MaxItem = 10;
        private static int WaitingThreadCount = 0;

        private Singleton()
        {
        }

        public static Queue<Singleton> getQueue()
        {
            if (items == null) {
                items = new Queue<Singleton>();
            }

            return items;
        }

        public static bool Generate()
        {
            lock (thisLock)
            {
                if (items.Count < MaxItem)
                {
                    _instance = new Singleton();
                    items.Enqueue(_instance);
                    Console.WriteLine("Queueliste yeni bir singleton objesi eklenmiştir.\nQueue'nun mevcut obje sayısı " + items.Count);
                    return true;
                }
                else
                {
                    WaitingThreadCount++;
                    Console.WriteLine("Queue maksimum obje sayısı olan "+items.Count+" sayısına ulaşmıştır. İstek bekletme listesine eklenmiştir.");
                    Console.WriteLine("Bekletilen thread sayısı:" + WaitingThreadCount);
                    return false;
                }
            }
        }

        public static Singleton GetItem()
        {
            if (0 < items.Count)
            {
                try
                {
                    return items.Dequeue();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Kuyruk Boş.");
                }
            }

            return null;
        }
    }
}
