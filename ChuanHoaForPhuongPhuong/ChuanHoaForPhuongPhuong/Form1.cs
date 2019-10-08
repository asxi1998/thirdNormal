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

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void BtnThem1_Click(object sender, EventArgs e)
        {

        }

        int locationX1 = 0;
        int locationY1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {

            locationY1 += 26;

            ComboBox comboBox1 = new ComboBox();
            comboBox1.Location = new Point(locationX1 , locationY1);
            ComboBox comboBox2 = new ComboBox();
            comboBox2.Location = new Point(locationX1 + 127, locationY1);
            ComboBox comboBox3 = new ComboBox();
            comboBox3.Location = new Point(locationX1 + 254, locationY1);

            Label label = new Label();
            label.Location = new Point(locationX1 + 381, locationY1);
            label.Text = "->";
            
            ComboBox comboBox4 = new ComboBox();
            comboBox4.Location = new Point(locationX1 + 408, locationY1);
            ComboBox comboBox5 = new ComboBox();
            comboBox5.Location = new Point(locationX1 + 535, locationY1);
            ComboBox comboBox6 = new ComboBox();
            comboBox6.Location = new Point(locationX1 + 662, locationY1);

            panelphuthuocham.Controls.Add(comboBox1);
            panelphuthuocham.Controls.Add(comboBox2);
            panelphuthuocham.Controls.Add(comboBox3);
            panelphuthuocham.Controls.Add(comboBox4);
            panelphuthuocham.Controls.Add(comboBox5);
            panelphuthuocham.Controls.Add(comboBox6);
            panelphuthuocham.Controls.Add(label);


            button1.Location = new Point(locationX1, locationY1 +26);

            comboBox1.DataSource = combo;
            comboBox2.DataSource = combo;
            comboBox3.DataSource = combo;
            comboBox4.DataSource = combo;
            comboBox5.DataSource = combo;
            comboBox6.DataSource = combo;

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
                    if(textbox.Text.Length==0)
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
            comboBox1.DataSource = combo;
            comboBox2.DataSource = combo;
            comboBox3.DataSource = combo;
            comboBox4.DataSource = combo;
            comboBox5.DataSource = combo;
            comboBox6.DataSource = combo;

            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnThirdnormal_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (ktPhuThuocHam() == 1 && ktKhoa() == 1)
                {
                    string[] quanhe=new string[10];
                    string[] khoa = new string[10];
                    foreach (Control control in panelphuthuocham.Controls)
                    {
                        if (control.GetType() == typeof(ComboBox) && control.Text.Trim().Length > 0)
                        { 


                        }
                    }
                    int b = -1;
                    foreach (Control control in panelkhoa.Controls)
                    {
                        if (control.GetType() == typeof(ComboBox) && control.Text.Trim().Length > 0)
                        {
                            khoa[++b] = control.Text.Trim().ToString();
                        }
                    }
                    int c = -1;
                    foreach (Control control in panelNhapQuanHe.Controls)
                    {
                        if(control.GetType()==typeof(TextBox)&& control.Text.Trim().Length>0)
                        {
                            quanhe[++c] = control.Text.Trim().ToString();
                        }
                    }
                }
            }
        }
        public int ktPhuThuocHam()
        {
            foreach(Control control in panelphuthuocham.Controls)
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



                panelkhoa.Controls.Add(comboBox10);
                panelkhoa.Controls.Add(comboBox11);
                panelkhoa.Controls.Add(comboBox12);


                button4.Location = new Point(locationX2, locationY2 + 26);

                comboBox10.DataSource = combo;
                comboBox11.DataSource = combo;
                comboBox12.DataSource = combo;

            }
        }
    }
}
