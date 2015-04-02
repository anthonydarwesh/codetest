using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class SortItem
    {
        public string word { get; set; }
        public int score { get; set; }
        public int index { get; set; }
        public void setScore()
        {
            this.score = 0;
            int total = 0;
            foreach(char c in this.word)
            {
                int index = (int)c % 32;
                total += index;
            }
            //score = position * character total
            this.score = this.index * total;
        }

    }
}
