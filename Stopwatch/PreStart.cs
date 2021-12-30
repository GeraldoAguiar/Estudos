using System;
using System.Threading;

namespace Stopwatch
{
    public static class PreStart
    {
        public static void PreInicio(int time)
        {
            Console.Clear();

            Console.WriteLine("You Ready ? ...");
            Thread.Sleep(3000);
            Console.WriteLine("LETS GO ? ...");
            Thread.Sleep(2500);

            Start.Go(time);
        }
    }
}