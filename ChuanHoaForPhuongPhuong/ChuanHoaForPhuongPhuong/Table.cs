using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanHoaForPhuongPhuong
{
    public class Table
    {
        public Table()
        {
        }

        private string[] first;
        private string[] second;
        
        //boi den alt + enter
        public Table(string[] first, string[] second)
        {
            this.First = first;
            this.Second = second;
        }
        //boi den ctr + r + e
         public string[] First { get => first; set => first = value; }
         public string[] Second { get => second; set => second = value; }
    }
}
