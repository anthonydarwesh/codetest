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
            FileInfo fi = new FileInfo(@"C:\Users\shum\Documents\Freelancer\Code Test\names.txt");
            try
            {
                using(StreamReader sr = fi.OpenText())
                {
                    string content = sr.ReadToEnd();
                    //split the string into an array of strings
                    string[] stringArray = content.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    //remove the quotes from the string
                    List<string> stringList = new List<string>();
                    foreach(string st in stringArray)
                    {
                        stringList.Add(st.Replace("\"", ""));
                    }
                    //sort the list
                    //stringList.OrderBy(x => x.ToLower).Select();
                    stringList.Sort();
                    //find collin
                    int count = 1;
                    foreach (string st in stringList)
                    {
                        if(st.ToLower() == "colin")
                        {
                            Console.WriteLine("Index is {0}", count);
                            Console.ReadLine();
                            return;
                        }
                        count++;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
