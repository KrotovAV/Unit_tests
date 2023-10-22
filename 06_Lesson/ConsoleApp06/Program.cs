using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoListsCl twoLists00 = new TwoListsCl(
                new List<int>() { },
                new List<int>() { }
                );
            double av001 = twoLists00.AverageList1();
            Console.WriteLine(av001);

            double av002 = twoLists00.AverageList2();
            Console.WriteLine(av002);

            Console.WriteLine(twoLists00.ComparesAvgs());



            TwoListsCl twoLists = new TwoListsCl(
                new List<int>() { 1, 2, 3 },
                new List<int>() { 2, 3, 4 }
                );

            double av1 = twoLists.AverageList1();
            Console.WriteLine(av1);

            double av2 = twoLists.AverageList2();
            Console.WriteLine(av2);

            Console.WriteLine(twoLists.ComparesAvgs());

            TwoListsCl twoLists1 = new TwoListsCl(
                new List<int>() { 2, 3, 4 },
                new List<int>() { 1, 2, 3 }
                );

            double av11 = twoLists1.AverageList1();
            Console.WriteLine(av11);

            double av12 = twoLists1.AverageList2();
            Console.WriteLine(av12);

            Console.WriteLine(twoLists1.ComparesAvgs());

            TwoListsCl twoLists2 = new TwoListsCl(
                new List<int>() { 1, 2, 3, 4, 5 },
                new List<int>() { 1, 2, 3, 4, 5 }
                );

            double av21 = twoLists2.AverageList1();
            Console.WriteLine(av21);

            double av22 = twoLists2.AverageList2();
            Console.WriteLine(av22);

            Console.WriteLine(twoLists2.ComparesAvgs());
        }
    }
}
