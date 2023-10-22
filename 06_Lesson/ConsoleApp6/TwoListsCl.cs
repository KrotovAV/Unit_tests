using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class TwoListsCl
    {
        public List<int> List1;
        public List<int> List2;

        //public TwoListsCl() { }

        public TwoListsCl(List<int> List1, List<int> List2)
        {
            this.List1 = List1;
            this.List2 = List2;
        }

        public double AverageList1()
        {
            if (List1.Count > 0) 
            { 
                return List1.Sum(x => x) / List1.Count;
            }
            else 
            {
                return 0; 
            }
        }
        public double AverageList2()
        {
            if (List2.Count > 0)
            {
                return List2.Sum(x => x) / List2.Count;
            }
            else 
            { 
                return 0; 
            }  
        }

        public string ComparesAvgs()
        {

            if (AverageList1() == AverageList2())
            {
                return "The averages of both lists are equal";
            }
            else
            {
                if (AverageList1() < AverageList2())
                {
                    return "The second list has a higher average value";
                }
                else
                {
                    return "The first list has a higher average value";
                }
            }

        }
    }
}
