using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    using System.IO;
    class Sort
    {
        string filePath { get; set; }
        List<string> stringList { get; set; }
        List<SortItem> items { get; set; }
        public Sort(string filePath)
        {
            this.filePath = filePath;
            FileInfo fi = new FileInfo(filePath);
            //throw exception if file doesn't exist
            if (!fi.Exists) throw new FileNotFoundException("The specified file was not found");
            using (StreamReader sr = fi.OpenText())
            {
                string content = sr.ReadToEnd();
                //split the string into an array of strings
                string[] stringArray = content.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                //remove the quotes from the string
                this.stringList = new List<string>();
                foreach (string st in stringArray)
                {
                    this.stringList.Add(st.Replace("\"", ""));
                }
                //sort the list
                this.stringList.Sort();                
            }
            //add the sortitems from the list
            int index = 0;
            foreach(string st in this.stringList)
            {
                SortItem si = new SortItem();
                si.word = st;
                si.index = index;
                //calculate the score
                si.setScore();
                index++;
            }
        }
    }
}
