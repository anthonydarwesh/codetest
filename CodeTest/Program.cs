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
                using(StreamReader st = fi.OpenText())
                {
                    string content = st.ReadToEnd();
                    string[] stringArray = content.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
