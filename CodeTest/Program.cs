using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sort sorter = new Sort(@"C:\Users\shum\Documents\Freelancer\Code Test\names.txt");
                //SortItem st = sorter.items.Where(x => x.word == "COLIN").FirstOrDefault();
                //if(st == null)
                //{
                //    Console.Write("NULL");
                //}
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
