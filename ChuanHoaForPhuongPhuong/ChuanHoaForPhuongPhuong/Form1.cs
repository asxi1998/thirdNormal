﻿using System;
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


        int nHamPhuThuoc = 1;


        int locationX1 = 0;
        int locationY1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {

                locationY1 += 26;

                ComboBox comboBox1 = new ComboBox();
                comboBox1.Location = new Point(locationX1, locationY1);
                ComboBox comboBox2 = new ComboBox();
                comboBox2.Location = new Point(locationX1 + 127, locationY1);
                ComboBox comboBox3 = new ComboBox();
                comboBox3.Location = new Point(locationX1 + 254, locationY1);

                Label label = new Label();
                label.Location = new Point(locationX1 + 381, locationY1);
                label.Text = "->";

                ComboBox comboBox4 = new ComboBox();
                comboBox4.Location = new Point(locationX1, locationY1);
                ComboBox comboBox5 = new ComboBox();
                comboBox5.Location = new Point(locationX1 + 127, locationY1);
                ComboBox comboBox6 = new ComboBox();
                comboBox6.Location = new Point(locationX1 + 254, locationY1);

                addcombo(comboBox1);
                addcombo(comboBox2);
                addcombo(comboBox3);
                addcombo(comboBox4);
                addcombo(comboBox5);
                addcombo(comboBox6);
               

                panelphuthuocham.Controls.Add(comboBox1);
                panelphuthuocham.Controls.Add(comboBox2);
                panelphuthuocham.Controls.Add(comboBox3);
                panelphuthuocham2.Controls.Add(comboBox4);
                panelphuthuocham2.Controls.Add(comboBox5);
                panelphuthuocham2.Controls.Add(comboBox6);
                panelphuthuocham.Controls.Add(label);


                button1.Location = new Point(locationX1, locationY1 + 26);




                nHamPhuThuoc++;
            }
        }



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
            addcombo(comboBox10);
            addcombo(comboBox11);
            addcombo(comboBox12);


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
                if (ktPhuThuocHam() == 1 && ktKhoa() == 1)
                {
                    string[] quanhe=new string[10];
                    Element[] khoa = new Element[6];
                    Element[] phuthuoc = new Element[6];
                    Element[] phuthuoc1 = new Element[6];

                    Element elementphuthuoc0 = new Element();
                    Element elementphuthuoc1 = new Element();
                    Element elementphuthuoc2 = new Element();
                    Element elementphuthuoc3 = new Element();
                    Element elementphuthuoc4 = new Element();
                    Element elementphuthuoc5 = new Element();

                    string[] str1 = new string[3];
                    string[] str2 = new string[3];
                    string[] str3 = new string[3];
                    string[] str4 = new string[3];
                    string[] str5 = new string[3];
                    string[] str6 = new string[3];
                    int a1 = -1;
                    int a2 = -1;
                    int a3 = -1;
                    int a4 = -1;
                    int a5 = -1;
                    int a6 = -1;
                    foreach (Control control in panelphuthuocham.Controls)
                    {
                        if (control.GetType() == typeof(ComboBox) && control.Text.Trim().Length > 0)
                        {
                            if (control.Location.Y < 5)
                            {
                                str1[++a1] = control.Text.Trim().ToString();
                                
                            }
                            else
                            {
                                if (control.Location.Y < 32)
                                {
                                    str2[++a2] = control.Text.Trim().ToString();
                                }
                                else
                                {
                                    if (control.Location.Y < 59)
                                    {
                                        str3[++a3] = control.Text.Trim().ToString();
                                    }
                                    else
                                    {
                                        if (control.Location.Y < 86)
                                        {
                                            str4[++a4] = control.Text.Trim().ToString();
                                           
                                        }
                                        else
                                        {
                                            if (control.Location.Y < 113)
                                            {
                                                str5[++a5] = control.Text.Trim().ToString();
                                            }
                                            else
                                            {
                                                str6[++a6] = control.Text.Trim().ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    elementphuthuoc0.SetElement(str1);
                    elementphuthuoc1.SetElement(str2);
                    elementphuthuoc2.SetElement(str3);
                    elementphuthuoc3.SetElement(str4);
                    elementphuthuoc4.SetElement(str5);
                    elementphuthuoc5.SetElement(str6);

                    phuthuoc[0] = elementphuthuoc0;
                    phuthuoc[1] = elementphuthuoc1;
                    phuthuoc[2] = elementphuthuoc2;
                    phuthuoc[3] = elementphuthuoc3;
                    phuthuoc[4] = elementphuthuoc4;
                    phuthuoc[5] = elementphuthuoc5;


                    //--------------------------------------------------------------------------


                    Element elementphuthuocham0 = new Element();
                    Element elementphuthuocham1 = new Element();
                    Element elementphuthuocham2 = new Element();
                    Element elementphuthuocham3 = new Element();
                    Element elementphuthuocham4 = new Element();
                    Element elementphuthuocham5 = new Element();

                    string[] str11 = new string[3];
                    string[] str22 = new string[3];
                    string[] str33 = new string[3];
                    string[] str44 = new string[3];
                    string[] str55 = new string[3];
                    string[] str66 = new string[3];

                    int aa1 = -1;
                    int aa2 = -1;
                    int aa3 = -1;
                    int aa4 = -1;
                    int aa5 = -1;
                    int aa6 = -1;
                    foreach (Control control in panelphuthuocham2.Controls)
                    {
                        if (control.GetType() == typeof(ComboBox) && control.Text.Trim().Length > 0)
                        {
                            if (control.Location.Y < 5)
                            {
                                str11[++aa1] = control.Text.Trim().ToString();
                            }
                            else
                            {
                                if (control.Location.Y < 32)
                                {
                                    str22[++aa2] = control.Text.Trim().ToString();
                                }
                                else
                                {
                                    if (control.Location.Y < 59)
                                    {
                                        str33[++aa3] = control.Text.Trim().ToString();
                                    }
                                    else
                                    {
                                        if (control.Location.Y < 86)
                                        {
                                            str44[++aa4] = control.Text.Trim().ToString();
                                        }
                                        else
                                        {
                                            if (control.Location.Y < 113)
                                            {
                                                str55[++aa5] = control.Text.Trim().ToString();
                                            }
                                            else
                                            {
                                                str66[++aa6] = control.Text.Trim().ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    elementphuthuocham0.SetElement(str11);
                    elementphuthuocham1.SetElement(str22);
                    elementphuthuocham2.SetElement(str33);
                    elementphuthuocham3.SetElement(str44);
                    elementphuthuocham4.SetElement(str55);
                    elementphuthuocham5.SetElement(str66);

                    phuthuoc1[0] = elementphuthuocham0;
                    phuthuoc1[1] = elementphuthuocham1;
                    phuthuoc1[2] = elementphuthuocham2;
                    phuthuoc1[3] = elementphuthuocham3;
                    phuthuoc1[4] = elementphuthuocham4;
                    phuthuoc1[5] = elementphuthuocham5;


                    //-------------------------------------------------------

                    Element elementkhoa0 = new Element();
                    Element elementkhoa1 = new Element();
                    Element elementkhoa2 = new Element();
                    Element elementkhoa3 = new Element();
                    Element elementkhoa4 = new Element();
                    Element elementkhoa5 = new Element();

                    string[] str111 = new string[3];
                    string[] str222 = new string[3];
                    string[] str333 = new string[3];
                    string[] str444 = new string[3];
                    string[] str555 = new string[3];
                    string[] str666 = new string[3];

                    int b1 = -1;
                    int b2 = -1;
                    int b3 = -1;
                    int b4 = -1;
                    int b5 = -1;
                    int b6 = -1;
                    foreach (Control control in panelkhoa.Controls)
                    {
                        if (control.GetType() == typeof(ComboBox) && control.Text.Trim().Length > 0)
                        {
                            if (control.Location.Y < 5)
                            {
                                str111[++b1] = control.Text.Trim().ToString();
                            }
                            else
                            {
                                if (control.Location.Y < 32)
                                {
                                    str222[++b2] = control.Text.Trim().ToString();
                                }
                                else
                                {
                                    if (control.Location.Y < 59)
                                    {
                                        str333[++b3] = control.Text.Trim().ToString();
                                    }
                                    else
                                    {
                                        if (control.Location.Y < 86)
                                        {
                                            str444[++b4] = control.Text.Trim().ToString();
                                        }
                                        else
                                        {
                                            if (control.Location.Y < 113)
                                            {
                                                str555[++b5] = control.Text.Trim().ToString();
                                            }
                                            else
                                            {
                                                str666[++b6] = control.Text.Trim().ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    elementkhoa0.SetElement(str111);
                    elementkhoa1.SetElement(str222);
                    elementkhoa2.SetElement(str333);
                    elementkhoa3.SetElement(str444);
                    elementkhoa4.SetElement(str555);
                    elementkhoa5.SetElement(str666);

                    khoa[0] = elementphuthuocham0;
                    khoa[1] = elementphuthuocham1;
                    khoa[2] = elementphuthuocham2;
                    khoa[3] = elementphuthuocham3;
                    khoa[4] = elementphuthuocham4;
                    khoa[5] = elementphuthuocham5;

                    int c = -1;
                    foreach (Control control in panelNhapQuanHe.Controls)
                    {
                        if(control.GetType()==typeof(TextBox)&& control.Text.Trim().Length>0)
                        {
                            quanhe[++c] = control.Text.Trim().ToString();
                        }
                    }


                    Element[] First = new Element[6];
                    Element[] Last = new Element[6];

                    Properties.Settings.Default.nkey = 10;

                    chuanhoa.thucHienChuanHoa(quanhe,khoa,nKhoa,phuthuoc,phuthuoc1,nHamPhuThuoc, First, Last, Properties.Settings.Default.nkey);

                    MessageBox.Show(Properties.Settings.Default.nkey.ToString());
                    xuatElement(First, Last, Properties.Settings.Default.nkey);
                }
            }
        }


        int positionResultfX=477;
        int positionResultfY = 328;
        public void xuatElement(Element[] resultF, Element[] resultL,int nKey)
        {
            for (int i = 0; i <= nKey; i++)
            {
                if (resultF[i] != null)
                {


                    Label label1 = new Label();
                    Label label2 = new Label();
                    Label label3 = new Label();
                    Label label4 = new Label();
                    Label label5 = new Label();
                    Label label6 = new Label();

                    label1.Location = new Point(positionResultfX, positionResultfY);
                    label2.Location = new Point(positionResultfX + 127, positionResultfY);
                    label3.Location = new Point(positionResultfX + 127 + 127, positionResultfY);
                    label4.Location = new Point(positionResultfX + 127 + 127 + 127, positionResultfY);
                    label5.Location = new Point(positionResultfX + 127 + 127 + 127 + 127, positionResultfY);
                    label6.Location = new Point(positionResultfX + 127 + 127 + 127 + 127 + 127, positionResultfY);

                    

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

        public int ktPhuThuocHam()
        {
            foreach (Control control in panelphuthuocham.Controls)
            {
                if (control.GetType() == typeof(ComboBox) && control.Text.Trim().Length > 0)
                    return 1;
            }
            return 0;
        }
        public int ktKhoa()
        {
            foreach (Control control in panelkhoa.Controls)
            {
                if (control.GetType() == typeof(ComboBox) && control.Text.Trim().Length > 0)
                    return 1;
            }
            return 0;
        }

        int nKhoa = 1;

        int locationX2=0;
        int locationY2=0;

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                locationY2 += 26;

                ComboBox comboBox10 = new ComboBox();
                comboBox10.Location = new Point(locationX2, locationY2);
                ComboBox comboBox11 = new ComboBox();
                comboBox11.Location = new Point(locationX2 + 127, locationY2);
                ComboBox comboBox12 = new ComboBox();
                comboBox12.Location = new Point(locationX2 + 254, locationY2);


                addcombo(comboBox10);
                addcombo(comboBox11);
                addcombo(comboBox12);

                panelkhoa.Controls.Add(comboBox10);
                panelkhoa.Controls.Add(comboBox11);
                panelkhoa.Controls.Add(comboBox12);


                button4.Location = new Point(locationX2, locationY2 + 26);



                nKhoa++;
            }
        }

      
        public void addcombo(ComboBox abc)
        {
            for (int i = 0; i < combo.Count; i++)
                abc.Items.Add(combo[i]);
        }


    }
}
