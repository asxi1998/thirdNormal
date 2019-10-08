using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanHoaForPhuongPhuong
{
    public class ChuanHoa
    {
        
        public ChuanHoa()
        {

        }
        public Table thucHienChuanHoa(string[] quanhe, string[] khoa, Table[] hamPhuThuoc)
        {
            Table tableEnd = new Table();
            for (int i=0;i< hamPhuThuoc.Length -1; i++)
            {
                Table table = new Table();
                for (int j = 1; j < hamPhuThuoc.Length; j++)
                {
                    int dem = 0;
                    
                    for (int k = 0; j < hamPhuThuoc[i].First.Length; k++)
                    {

                    }
                }
            }

            return tableEnd;
        }


    }
}
