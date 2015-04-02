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
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
