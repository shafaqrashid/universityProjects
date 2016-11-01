using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_length
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "one", "two", "three" };
            ShowArrayInfo(array);
            
            string[,] arrayTwo = { { " zero", "0" }, { "one", "1" }, { "two", "2" } };
            ShowArrayInfo(arrayTwo);
            Console.ReadKey();

        }
        public static void ShowArrayInfo(Array arr)
        {
            Console.WriteLine("length of array : {0,3}", arr.Length);
            Console.WriteLine("number of dimension :{0,3} ", arr.Rank);
            if(arr.Rank>1)
            {
                for(int dimension=1; dimension <=arr.Rank;dimension++)
                    Console.WriteLine("Dimension{0}:{1,3}",dimension,arr.GetUpperBound(dimension-1)+1);
            }
            Console.WriteLine();
        }
       
    }
}
        

