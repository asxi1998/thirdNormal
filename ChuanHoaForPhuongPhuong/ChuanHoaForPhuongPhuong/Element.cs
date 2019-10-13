using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanHoaForPhuongPhuong
{
    public class Element
    {
        private string[] element;
        public Element()
        {

        }

        public Element(string[] element)
        {
            this.element = element;
        }

        public string[] GetElement()
        {
            return element;
        }

        public void SetElement(string[] value)
        {
            element = value;
        }
    }
}
