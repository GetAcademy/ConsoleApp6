using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var allStats = new[]
            {
                new Stats(),
                new Stats(),
            };

            while (true)
            {
                Console.WriteLine("Skriv inn en person: ");
                var personIndex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv inn et tall: ");
                var tall = Convert.ToInt32(Console.ReadLine());
                var obj = allStats[personIndex];
                //AddNumber(obj, tall);
                obj.AddNumber(tall);

                //Show(personIndex, obj);
                obj.Show(personIndex);
            }

            //var ting = new Ting();
            //ting.a = 5;
            //Console.WriteLine(ting.a);

            //ting.SetA(5);
            //Console.WriteLine(ting.GetA());
        }


    }
}
