using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanHoaForPhuongPhuong
{
    public class KhoaChinh
    {
        private string[] primary;

        public KhoaChinh(string[] primary)
        {
            this.Primary = primary;
        }

        public string[] Primary { get => primary; set => primary = value; }
    }
}
