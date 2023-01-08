using System;
using System.Threading;

namespace Stopwatch {
    class Program {
        static void Main (string[] args) {
            Start(6);
        }

        static void MenuApp() {
            Console.Clear();
            Console.WriteLine("S = Seconds => 10s = 10 seconds");
            Console.WriteLine("M = Minutes => 1m = 1 minute");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("How long will it count?");

            string data = Console.ReadLine().ToLower();
        }

        static void Start(int time) {
            int currentTime = 0;

            while(currentTime != time) {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finished... Returning to Menu");
        }

    }
}