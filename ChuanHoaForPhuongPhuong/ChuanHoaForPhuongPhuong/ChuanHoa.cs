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
        public void thucHienChuanHoa(string[] quanhe, Element[] khoa, int nKhoa, Element[] hamPhuThuocF, Element[] hamPhuThuocL, int nHamPhuThuoc, Element[] PrimaryKey, Element[] ForenceKey, int nKey)
        {
            int key1 = -1;
            for (int i = 0; i < nHamPhuThuoc - 1; i++)
            {
                for (int j = i + 1; j < nHamPhuThuoc; j++)
                {
                    int kt = kiemtrathuocLtoFL(hamPhuThuocL[i], hamPhuThuocF[j], hamPhuThuocL[j]);
                    if (kt == 1)
                    {
                        //++key1;
                        //Element elementPkey = new Element();
                        //addElement(elementPkey, hamPhuThuocF[j]);
                        //PrimaryKey[key1] = elementPkey;

                        //Element elementFkey = new Element();
                        //addElement(elementFkey, hamPhuThuocL[j]);
                        //ForenceKey[key1] = elementFkey;

                        deleteElement(hamPhuThuocL, nHamPhuThuoc, i, hamPhuThuocL[j]);
                    }


                }
            }
            for (int i = 0; i < nHamPhuThuoc; i++)
            {
                ++key1;
                Element elementPkey = new Element();
                addElement(elementPkey, hamPhuThuocF[i]);
                PrimaryKey[key1] = elementPkey;

                Element elementFkey = new Element();
                addElement(elementFkey, hamPhuThuocL[i]);
                ForenceKey[key1] = elementFkey;
            }
            Properties.Settings.Default.nkey = key1;
        }
        public void deleteElement(Element[] key,int nHamPhuThuoc, int stt,Element element)
        {
            int n = -1;
            string[] elementtest = new string[3];
            elementtest = key[stt].GetElement();
            for (int i = 0; i < nHamPhuThuoc; i++)
            {
                for (int j = 0; j < nHamPhuThuoc; j++)
                {
                    if (key[stt].GetElement()[i] == element.GetElement()[j])
                    {
                        elementtest[i] = null;
                    }
                }
            }
            key[stt].SetElement(elementtest);
        }
        public void addElement(Element key,Element element)
        {
            string[] str= element.GetElement();
            key.SetElement(str);
        }
        public int kiemtraKhoa(Element[] khoa,int nKhoa, Element chuoi)
        {
            for(int i=0;i< nKhoa; i++)
            {
                if(chuoi==khoa[i])
                {
                    return 1;
                }
            }
            return 0;
        }
        public void ganvaoKhoa(Element[] khoa,int nKhoa, Element chuoi)
        {
            for (int i = nKhoa-1; i < khoa.Length; i++)
            {
                if (khoa[i]==null)
                {
                    khoa[i] = chuoi;
                    return;
                }
            }
        }
        public int kiemtrathuocLtoFL(Element element1,Element element2, Element element3)
        {
            int dem1 = 0;
            int dem2 = 0;
            for (int i=0;i<element2.GetElement().Length;i++)
            {
                for (int j = 0; j < element2.GetElement().Length; j++)
                {
                    if (element2.GetElement()[i] != null) 
                    {
                        if (element1.GetElement()[j] != null)
                        {
                            if (element2.GetElement()[i].Trim().CompareTo(element1.GetElement()[j].Trim()) == 0)
                            {
                                dem1++;
                            }
                        }
                       
                    }
                }
                if (element2.GetElement()[i] != null)
                {
                    dem2++;
                }
            }
            if(dem1==dem2)
            {
                return 1;//bat cau
            }
            return 0;//ko bat cau
        }


    }
}
