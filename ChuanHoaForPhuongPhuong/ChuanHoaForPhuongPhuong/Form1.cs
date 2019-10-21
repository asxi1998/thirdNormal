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
            txt.Location = new Point(locationX, locationY);
            txt.Size = new Size(121, 20);

            panelNhapQuanHe.Controls.Add(txt);
            //tạo ra button
            Button btn = new Button();
            btn.Location = new Point(locationX + 127, locationY);
            btn.Text = "Xóa";

            panelNhapQuanHe.Controls.Add(btn);

            //bat su kien click cua button
            btn.Click += Btn_Click;



            btnthem1quanhe.Location = new Point(locationX, locationY + 26);


        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            foreach (Control textbox in panelNhapQuanHe.Controls)
            {
                if (textbox.GetType() == typeof(TextBox))
                    if (textbox.Location.Y == btn.Location.Y)
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
                if (txtF.Text.Length > 0)
                {
                    string[] quanhe = new string[10];
                    Element[] khoa = new Element[6];
                    Element[] phuthuoc = new Element[6];
                    Element[] phuthuoc1 = new Element[6];

                   

                    string chuoi = txtF.Text;
                    if (chuoi.Length > 0)
                    {
                        string[] arrListStr = chuoi.Split(';');
                        for (int i = 0; i < arrListStr.Length; i++)
                        {
                            string[] arrListStrChild = arrListStr[i].ToString().Split('-');

                            string[] str = new string[10];
                            int j = -1;
                            while (arrListStrChild[0].Length > 0)
                            {
                                //lấy add vào str
                                str[++j] = arrListStrChild[0].Substring(0, 1).ToString();
                                //cắt chuổi arrListStrChild[0].Substring(0,1).ToString()
                                arrListStrChild[0] = arrListStrChild[0].Replace(str[j].ToString(), string.Empty);
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
                                strHam[++k] = arrListStrChild[1].Substring(0, 1).ToString();
                                //cắt chuổi
                                arrListStrChild[1] = arrListStrChild[1].Replace(strHam[k].ToString(), string.Empty);
                            }
                            Element elementphuthuocham = new Element();
                            elementphuthuocham.SetElement(strHam);
                            phuthuoc1[i] = elementphuthuocham;
                        }
                    }

                    

                    //--------------------------------------------------
                    Element[] First = new Element[10];
                    Element[] Last = new Element[10];

                    Properties.Settings.Default.nkey = 10;

                    chuanhoa.thucHienChuanHoa(phuthuoc, phuthuoc1, nHamPhuThuoc, First, Last, Properties.Settings.Default.nkey);

                    xuatElement(First, Last, Properties.Settings.Default.nkey);
                }
            }
            btnThirdnormal.Enabled = true;
        }

        int num = 10;
        private int ktchuoiNull(string[] str1)
        {
            string[] str2 = new string[10];
            for (int i = 0; i < str1.Count(); i++)
            {
                if (str1[i] != str2[i])
                    return 0;
            }
            return 1;
        }
        int positionResultfX = 477;
        int positionResultfY = 328;
        public void xuatElement(Element[] resultF, Element[] resultL, int nKey)
        {
            Label labelKhoa = new Label();
            Label labelThuoctinh = new Label();

            labelKhoa.Location = new Point(positionResultfX, positionResultfY);
            labelThuoctinh.Location = new Point(positionResultfX + 127, positionResultfY);

            labelKhoa.Text = "KHOA CHINH";
            labelThuoctinh.Text = "THUOC TINH";

            panel1.Controls.Add(labelKhoa);
            panel1.Controls.Add(labelThuoctinh);
            int minuscount = 0;
            for (int i = 0; i <= nKey; i++)
            {
                if (resultF[i] != null)
                {
                    if (ktchuoiNull(resultF[i].GetElement()) == 0 && ktchuoiNull(resultL[i].GetElement()) == 0)
                    {
                        Label labelR = new Label();
                        labelR.Location = new Point(positionResultfX - 100, positionResultfY + 26);
                        labelR.Text = "R" + (i + 1- minuscount).ToString();
                        panel1.Controls.Add(labelR);


                        Label label1 = new Label();
                     
                        Label label4 = new Label();
                       
                        label1.Location = new Point(positionResultfX, positionResultfY + 26);
                      
                        label4.Location = new Point(positionResultfX + 127, positionResultfY + 26);
                     


                        label1.Font = new Font(label1.Font, FontStyle.Underline);
                      

                        Element element1 = new Element();
                        element1.SetElement(resultF[i].GetElement());
                        Element element2 = new Element();
                        element2.SetElement(resultL[i].GetElement());


                        for (int p = 0; p < num; p++)
                        {
                            if (element1.GetElement()[p] == null)
                            {
                            }
                            else
                            {
                                label1.Text += element1.GetElement()[p].Trim().ToString();
                            }
                        }
                        for (int p = 0; p < num; p++)
                        {
                            if (element2.GetElement()[p] == null)
                            {
                            }
                            else
                            {
                                label4.Text += element2.GetElement()[p].Trim().ToString();
                            }
                        }
                      


                        panel1.Controls.Add(label1);
                      
                        panel1.Controls.Add(label4);
                       
                        positionResultfY += 26;
                    }
                    else
                    {
                        //giảm khi có hàm R rổng
                        minuscount += 1;
                    }
                }
            }
        }



        public void addcombo(ComboBox abc)
        {
            for (int i = 0; i < combo.Count; i++)
                abc.Items.Add(combo[i]);
        }

    }
}
