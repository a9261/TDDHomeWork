using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
namespace TDDHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Instantiate delegate to reference ExtractWords method
            //Func<string, int, string[]> extractMethod = ExtractWords;
            //string title = "The Scarlet Letter";
            //// Use delegate instance to call ExtractWords method and display result
            //foreach (string word in extractMethod(title, 5))
            //    Console.WriteLine(word);

            MyData d = new MyData();
            //d.getSourceData().AsEnumerable().GroupBy(item => item.Field<int>("Id")/3)
            //    .Select(g=>g.OrderBy(r=>r.Field<int>("Id")))
            //    .Sum(item=>item.f);
            var result = from item in d.getSourceData().AsEnumerable()
                         group item by (((int)(item["Id"])-1) / 3) into g
                         select g;


            var Group4ItmesResult = from item in d.getSourceData().AsEnumerable()
                                    select item;
            var result1 = DataCalc.Sum(Group4ItmesResult, "Cost");
            for (int i = 0; i < result1.Count; i++)
            {
                Console.WriteLine(result1[i]);
            }

           Console.ReadKey();
           
        }
        private static string[] ExtractWords(string phrase, int limit)
        {
            char[] delimiters = new char[] { ' ' };
            if (limit > 0)
                return phrase.Split(delimiters, limit);
            else
                return phrase.Split(delimiters);
        }

    }
}
