using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanHoaForPhuongPhuong
{
    public partial class Form1 : Form
    {
        ChuanHoa chuanhoa = new ChuanHoa();


        int flag = 0;

        int locationX = 0;
        int locationY = 0;

        List<string> combo = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem1quanhe_Click(object sender, EventArgs e)
        {
            //tạo ra textbox
            locationY += 26;
            TextBox txt = new TextBox();
            txt.Location=new Point(locationX,locationY);
            txt.Size = new Size(121, 20);
            
            panelNhapQuanHe.Controls.Add(txt);
            //tạo ra button
            Button btn = new Button();
            btn.Location = new Point(locationX+127,locationY);
            btn.Text = "Xóa";

            panelNhapQuanHe.Controls.Add(btn);

            //bat su kien click cua button
            btn.Click += Btn_Click;

           

            btnthem1quanhe.Location = new Point(locationX, locationY+26);

            
        }

       
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach(Control textbox in panelNhapQuanHe.Controls)
            {
                if(textbox.GetType()==typeof(TextBox))
                    if(textbox.Location.Y==btn.Location.Y)
                    {
                        panelNhapQuanHe.Controls.Remove(textbox);
                        panelNhapQuanHe.Controls.Remove(btn);
                    }
            }
        }


        int nHamPhuThuoc = 0;


        //int locationX1 = 0;
        //int locationY1 = 0;

        int flagFirst = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {

                //locationY1 += 26;

                //ComboBox comboBox1 = new ComboBox();
                //comboBox1.Location = new Point(locationX1, locationY1);
                //ComboBox comboBox2 = new ComboBox();
                //comboBox2.Location = new Point(locationX1 + 127, locationY1);
                //ComboBox comboBox3 = new ComboBox();
                //comboBox3.Location = new Point(locationX1 + 254, locationY1);

                //Label label = new Label();
                //label.Location = new Point(locationX1 + 381, locationY1);
                //label.Text = "->";

                //ComboBox comboBox4 = new ComboBox();
                //comboBox4.Location = new Point(locationX1, locationY1);
                //ComboBox comboBox5 = new ComboBox();
                //comboBox5.Location = new Point(locationX1 + 127, locationY1);
                //ComboBox comboBox6 = new ComboBox();
                //comboBox6.Location = new Point(locationX1 + 254, locationY1);

                //addcombo(comboBox1);
                //addcombo(comboBox2);
                //addcombo(comboBox3);
                //addcombo(comboBox4);
                //addcombo(comboBox5);
                //addcombo(comboBox6);


                //panelphuthuocham.Controls.Add(comboBox1);
                //panelphuthuocham.Controls.Add(comboBox2);
                //panelphuthuocham.Controls.Add(comboBox3);
                //panelphuthuocham2.Controls.Add(comboBox4);
                //panelphuthuocham2.Controls.Add(comboBox5);
                //panelphuthuocham2.Controls.Add(comboBox6);
                //panelphuthuocham.Controls.Add(label);

                //button1.Location = new Point(locationX1, locationY1 + 26);

                //nHamPhuThuoc++;

                //-----------------------------------------------------------------------
                if (comboBox1.Text.Length > 0 || comboBox2.Text.Length > 0 || comboBox3.Text.Length > 0 || comboBox4.Text.Length > 0 || comboBox5.Text.Length > 0 || comboBox6.Text.Length > 0)
                {
                    if (flagFirst == 0)
                    {
                        //thêm đầu tiên không có ';'

                        if (comboBox1.Text.Length > 0)
                            txtF.Text += comboBox1.Text.Trim();
                        if (comboBox2.Text.Length > 0)
                            txtF.Text += comboBox2.Text.Trim();
                        if (comboBox3.Text.Length > 0)
                            txtF.Text += comboBox3.Text.Trim();

                        txtF.Text += comboBox3.Text.Trim() + '-';

                        if (comboBox4.Text.Length > 0)
                            txtF.Text += comboBox4.Text.Trim();
                        if (comboBox5.Text.Length > 0)
                            txtF.Text += comboBox5.Text.Trim();
                        if (comboBox6.Text.Length > 0)
                            txtF.Text += comboBox6.Text.Trim();

                        flagFirst = 1;
                    }
                    else
                    {
                        //thêm sau có ';' 
                        txtF.Text += comboBox3.Text.Trim() + ';';

                        if (comboBox1.Text.Length > 0)
                            txtF.Text += comboBox1.Text.Trim();
                        if (comboBox2.Text.Length > 0)
                            txtF.Text += comboBox2.Text.Trim();
                        if (comboBox3.Text.Length > 0)
                            txtF.Text += comboBox3.Text.Trim();

                        txtF.Text += comboBox3.Text.Trim() + '-';

                        if (comboBox4.Text.Length > 0)
                            txtF.Text += comboBox4.Text.Trim();
                        if (comboBox5.Text.Length > 0)
                            txtF.Text += comboBox5.Text.Trim();
                        if (comboBox6.Text.Length > 0)
                            txtF.Text += comboBox6.Text.Trim();

                    }
                    //clear combobox
                    comboBox1.Text = null;
                    comboBox2.Text = null;
                    comboBox3.Text = null;
                    comboBox4.Text = null;
                    comboBox5.Text = null;
                    comboBox6.Text = null;
                    //đếm xem có bao nhiu hàm F
                    nHamPhuThuoc++;
                }
            }
        }


        //kiểm tra các textbox còn trống hay ko
        private void button2_Click(object sender, EventArgs e)
        {
            flag = 1;
            combo.Add("");
            foreach (Control textbox in panelNhapQuanHe.Controls)
            {
                if (textbox.GetType() == typeof(TextBox))
                {
                    if (textbox.Text.Length == 0)
                    {
                        MessageBox.Show("Nhập cho đủ Quan hệ");
                        return;
                    }
                    else
                    {
                        combo.Add(textbox.Text);
                    }
                }
            }
            addcombo(comboBox1);
            addcombo(comboBox2);
            addcombo(comboBox3);
            addcombo(comboBox4);
            addcombo(comboBox5);
            addcombo(comboBox6);


            foreach (Control button in panelNhapQuanHe.Controls)
            {
                if (button.GetType() == typeof(Button))
                {
                    button.Visible = false;
                }
            }
            button2.Enabled = false;
            btnthem1quanhe.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnThirdnormal_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (txtF.Text.Length>0)
                {
                    string[] quanhe=new string[10];
                    Element[] khoa = new Element[6];
                    Element[] phuthuoc = new Element[6];
                    Element[] phuthuoc1 = new Element[6];

                    //Element elementphuthuoc0 = new Element();
                    //Element elementphuthuoc1 = new Element();
                    //Element elementphuthuoc2 = new Element();
                    //Element elementphuthuoc3 = new Element();
                    //Element elementphuthuoc4 = new Element();
                    //Element elementphuthuoc5 = new Element();

                    //string[] str1 = new string[3];
                    //string[] str2 = new string[3];
                    //string[] str3 = new string[3];
                    //string[] str4 = new string[3];
                    //string[] str5 = new string[3];
                    //string[] str6 = new string[3];
                    //int a1 = -1;
                    //int a2 = -1;
                    //int a3 = -1;
                    //int a4 = -1;
                    //int a5 = -1;
                    //int a6 = -1;
                    //foreach (Control control in panelphuthuocham.Controls)
                    //{
                    //    if (control.GetType() == typeof(ComboBox) && control.Text.Trim().Length > 0)
                    //    {
                    //        if (control.Location.Y < 5)
                    //        {
                    //            str1[++a1] = control.Text.Trim().ToString();
                                
                    //        }
                    //        else
                    //        {
                    //            if (control.Location.Y < 32)
                    //            {
                    //                str2[++a2] = control.Text.Trim().ToString();
                    //            }
                    //            else
                    //            {
                    //                if (control.Location.Y < 59)
                    //                {
                    //                    str3[++a3] = control.Text.Trim().ToString();
                    //                }
                    //                else
                    //                {
                    //                    if (control.Location.Y < 86)
                    //                    {
                    //                        str4[++a4] = control.Text.Trim().ToString();
                                           
                    //                    }
                    //                    else
                    //                    {
                    //                        if (control.Location.Y < 113)
                    //                        {
                    //                            str5[++a5] = control.Text.Trim().ToString();
                    //                        }
                    //                        else
                    //                        {
                    //                            str6[++a6] = control.Text.Trim().ToString();
                    //                        }
                    //                    }
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                    //elementphuthuoc0.SetElement(str1);
                    //elementphuthuoc1.SetElement(str2);
                    //elementphuthuoc2.SetElement(str3);
                    //elementphuthuoc3.SetElement(str4);
                    //elementphuthuoc4.SetElement(str5);
                    //elementphuthuoc5.SetElement(str6);

                    //phuthuoc[0] = elementphuthuoc0;
                    //phuthuoc[1] = elementphuthuoc1;
                    //phuthuoc[2] = elementphuthuoc2;
                    //phuthuoc[3] = elementphuthuoc3;
                    //phuthuoc[4] = elementphuthuoc4;
                    //phuthuoc[5] = elementphuthuoc5;

                    string chuoi = txtF.Text;
                    if(chuoi.Length>0)
                    {
                        string[] arrListStr = chuoi.Split(';');
                        for( int i=0;i<arrListStr.Length;i++)
                        {
                            string[] arrListStrChild = arrListStr[i].ToString().Split('-');

                            string[] str = new string[10];
                            int j = -1;
                            while (arrListStrChild[0].Length>0)
                            {
                                //lấy add vào str
                                str[++j]= arrListStrChild[0].Substring(0,1).ToString();
                                //cắt chuổi arrListStrChild[0].Substring(0,1).ToString()
                                arrListStrChild[0]=arrListStrChild[0].Replace(str[j].ToString(), string.Empty);
                            }
                            Element elementphuthuoc = new Element();
                            elementphuthuoc.SetElement(str);
                            phuthuoc[i] = elementphuthuoc;
                            //--------------------------------------------------
                            int k = -1;
                            string[] strHam = new string[10];
                            while (arrListStrChild[1].Length > 0)
                            {
                                //lấy add vào str
                                strHam[++k] = arrListStrChild[1].Substring(0,1).ToString();
                                //cắt chuổi
                                arrListStrChild[1]=arrListStrChild[1].Replace(strHam[k].ToString(), string.Empty);
                            }
                            Element elementphuthuocham = new Element();
                            elementphuthuocham.SetElement(strHam);
                            phuthuoc1[i] = elementphuthuocham;
                        }
                    }

                    //--------------------------------------------------------------------------


                    //Element elementphuthuocham0 = new Element();
                    //Element elementphuthuocham1 = new Element();
                    //Element elementphuthuocham2 = new Element();
                    //Element elementphuthuocham3 = new Element();
                    //Element elementphuthuocham4 = new Element();
                    //Element elementphuthuocham5 = new Element();

                    //string[] str11 = new string[3];
                    //string[] str22 = new string[3];
                    //string[] str33 = new string[3];
                    //string[] str44 = new string[3];
                    //string[] str55 = new string[3];
                    //string[] str66 = new string[3];

                    //int aa1 = -1;
                    //int aa2 = -1;
                    //int aa3 = -1;
                    //int aa4 = -1;
                    //int aa5 = -1;
                    //int aa6 = -1;
                    //foreach (Control control in panelphuthuocham2.Controls)
                    //{
                    //    if (control.GetType() == typeof(ComboBox) && control.Text.Trim().Length > 0)
                    //    {
                    //        if (control.Location.Y < 5)
                    //        {
                    //            str11[++aa1] = control.Text.Trim().ToString();
                    //        }
                    //        else
                    //        {
                    //            if (control.Location.Y < 32)
                    //            {
                    //                str22[++aa2] = control.Text.Trim().ToString();
                    //            }
                    //            else
                    //            {
                    //                if (control.Location.Y < 59)
                    //                {
                    //                    str33[++aa3] = control.Text.Trim().ToString();
                    //                }
                    //                else
                    //                {
                    //                    if (control.Location.Y < 86)
                    //                    {
                    //                        str44[++aa4] = control.Text.Trim().ToString();
                    //                    }
                    //                    else
                    //                    {
                    //                        if (control.Location.Y < 113)
                    //                        {
                    //                            str55[++aa5] = control.Text.Trim().ToString();
                    //                        }
                    //                        else
                    //                        {
                    //                            str66[++aa6] = control.Text.Trim().ToString();
                    //                        }
                    //                    }
                    //                }
                    //            }
                    //        }
                    //    }
                    //}
                    //elementphuthuocham0.SetElement(str11);
                    //elementphuthuocham1.SetElement(str22);
                    //elementphuthuocham2.SetElement(str33);
                    //elementphuthuocham3.SetElement(str44);
                    //elementphuthuocham4.SetElement(str55);
                    //elementphuthuocham5.SetElement(str66);

                    //phuthuoc1[0] = elementphuthuocham0;
                    //phuthuoc1[1] = elementphuthuocham1;
                    //phuthuoc1[2] = elementphuthuocham2;
                    //phuthuoc1[3] = elementphuthuocham3;
                    //phuthuoc1[4] = elementphuthuocham4;
                    //phuthuoc1[5] = elementphuthuocham5;

                    
                    //----------------------------------------------
                    //int c = -1;
                    //foreach (Control control in panelNhapQuanHe.Controls)
                    //{
                    //    if(control.GetType()==typeof(TextBox)&& control.Text.Trim().Length>0)
                    //    {
                    //        quanhe[++c] = control.Text.Trim().ToString();
                    //    }
                    //}

                    //--------------------------------------------------
                    Element[] First = new Element[10];
                    Element[] Last = new Element[10];

                    Properties.Settings.Default.nkey = 10;

                    chuanhoa.thucHienChuanHoa(phuthuoc,phuthuoc1,nHamPhuThuoc, First, Last, Properties.Settings.Default.nkey);

                    xuatElement(First, Last, Properties.Settings.Default.nkey);
                }
            }
            btnThirdnormal.Enabled = true;
        }


        int positionResultfX=477;
        int positionResultfY = 328;
        public void xuatElement(Element[] resultF, Element[] resultL,int nKey)
        {
            Label labelKhoa = new Label();
            Label labelThuoctinh = new Label();

            labelKhoa.Location = new Point(positionResultfX, positionResultfY);
            labelThuoctinh.Location = new Point(positionResultfX + 127 +  127 + 127, positionResultfY);

            labelKhoa.Text = "KHOA CHINH";
            labelThuoctinh.Text = "THUOC TINH";

            panel1.Controls.Add(labelKhoa);
            panel1.Controls.Add(labelThuoctinh);

            for (int i = 0; i <= nKey; i++)
            {
                if (resultF[i] != null)
                {
                    Label labelR = new Label();
                    labelR.Location = new Point(positionResultfX-100, positionResultfY + 26);
                    labelR.Text = "R" + (i+1).ToString();
                    panel1.Controls.Add(labelR);


                    Label label1 = new Label();
                    Label label2 = new Label();
                    Label label3 = new Label();
                    Label label4 = new Label();
                    Label label5 = new Label();
                    Label label6 = new Label();

                    label1.Location = new Point(positionResultfX, positionResultfY + 26);
                    label2.Location = new Point(positionResultfX + 127, positionResultfY + 26);
                    label3.Location = new Point(positionResultfX + 127 + 127, positionResultfY + 26);
                    label4.Location = new Point(positionResultfX + 127 + 127 + 127, positionResultfY + 26);
                    label5.Location = new Point(positionResultfX + 127 + 127 + 127 + 127, positionResultfY + 26);
                    label6.Location = new Point(positionResultfX + 127 + 127 + 127 + 127 + 127, positionResultfY + 26);

                    

                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                    label2.Font = new Font(label2.Font, FontStyle.Underline);
                    label3.Font = new Font(label3.Font, FontStyle.Underline);

                    Element element1 = new Element();
                    element1.SetElement(resultF[i].GetElement());
                    Element element2 = new Element();
                    element2.SetElement(resultL[i].GetElement());



                    if(element1.GetElement()[0]==null)
                    {
                        label1.Text = "";
                    }
                    else
                    {
                        label1.Text = element1.GetElement()[0].Trim().ToString();
                    }
                    if (element1.GetElement()[1] == null)
                    {
                        label2.Text = "";
                    }
                    else
                    {
                        label2.Text = element1.GetElement()[1].Trim().ToString();
                    }
                    if (element1.GetElement()[2] == null)
                    {
                        label3.Text = "";
                    }
                    else
                    {
                        label3.Text = element1.GetElement()[2].Trim().ToString();
                    }
                    if (element2.GetElement()[0] == null)
                    {
                        label4.Text = "";
                    }
                    else
                    {
                        label4.Text = element2.GetElement()[0].Trim().ToString();
                    }
                    if (element2.GetElement()[1] == null)
                    {
                        label5.Text = "";
                    }
                    else
                    {
                        label5.Text = element2.GetElement()[1].Trim().ToString();
                    }
                    if (element2.GetElement()[2] == null)
                    {
                        label6.Text = "";
                    }
                    else
                    {
                        label6.Text = element2.GetElement()[2].Trim().ToString();
                    }
                    

                    panel1.Controls.Add(label1);
                    panel1.Controls.Add(label2);
                    panel1.Controls.Add(label3);
                    panel1.Controls.Add(label4);
                    panel1.Controls.Add(label5);
                    panel1.Controls.Add(label6);
                }

                positionResultfY += 26;
            }
        }

       
      
        public void addcombo(ComboBox abc)
        {
            for (int i = 0; i < combo.Count; i++)
                abc.Items.Add(combo[i]);
        }

    
    }
}
