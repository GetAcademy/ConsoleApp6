using System;

namespace ConsoleApp6
{
    class Stats
    {
        public int Sum;
        public int N;
        public int Avg => Sum / N;

        public void AddNumber(int tall)
        {
            Sum += tall;
            N++;
        }

        public void Show(int personIndex)
        {
            Console.WriteLine($"Person {personIndex} Sum={Sum} Ant={N} Snitt={Avg}");
        }
    }
}
