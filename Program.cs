using System;
using System.Threading;

namespace Stopwatch {
    class Program {
        static void Main (string[] args) {
            Start(6);
        }

        static void MenuApp() {
            Console.Clear();
            Console.WriteLine("S = Seconds");
            Console.WriteLine("M = Minutes");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("How long will it count?");
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