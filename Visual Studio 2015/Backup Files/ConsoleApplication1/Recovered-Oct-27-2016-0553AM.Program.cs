using System;
using System.Collections.Generic;
using System.Linq;
using System.service

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {

            using (ServiceContext svcContext = new serviceContext(_serviceProxy))
            {
                var query_where1 = Form a in svcContext.AccountSet
                      where a.Name.Contains("contoso")
            select a;
                foreach (var a in query_where1)
                {
                    system.Console.WriteLine(a.Name + " " + a.Address1_city);
                }
            }
        }
    }
}
            // string[] data = new[] { "H", "ello", "pagal" };
            //  var g = (from x in data where x.Length > 2 select x);
            // var g = data.Where(x => x.Length > 2).Reverse();
            //ye b linq he h bas ispe x => ak lambda expression hai 
            //.Reverse b linq ka h ye ulta krdega result kro .. 
            // x is the variable that will be looped through ab ye simple kehta hai jahan x ki length > 2 hai 
            // woh woh cheezain select kro 
            //ap jab b from lagaoge mtlb koi ap linq query apply kari ho 
            //from mangata hkonse dataset ko lena h x is the variable which will hold each and 
            //every wvalue iteration .. 
            //so apne bola mjhe data ka ak ak kark element nkl k dw and x pe dalo 
            //first element x pe aya maine kaha select karo uspe se first letter x[0]  x is "H" 
            //next iteration x = ello so ye x[e] select krlega ..  and so on .. jo isko data mila maine g pe daaldia  ab dekho 
            //ab maine ak condition b daaldi ak he saath 
            //sai ha ye hai linq query iski kafi commands hain maine cover krwana h apko sab :p 
            //iski tarha sirf Linq b hai jo extensions methods se bana wa h ab woh dekho 
            //  foreach (var item in g)
            // {
            //  Console.WriteLine(item);

            // }
            //  Console.ReadKey();
