using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_21_Hai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, ketqua;

                if (string.IsNullOrEmpty(txt_so1.Text) == false && string.IsNullOrEmpty(txt_so2.Text) == false)
                {
                    a = int.Parse(txt_so1.Text);
                    b = int.Parse(txt_so2.Text);
                    Calculation_21_Hai c = new Calculation_21_Hai(a, b);
                    ketqua = c.Execute("+");
                    txt_ketqua.Text = ketqua.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số a,b!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, ketqua;

                if (string.IsNullOrEmpty(txt_so1.Text) == false && string.IsNullOrEmpty(txt_so2.Text) == false)
                {
                    a = int.Parse(txt_so1.Text);
                    b = int.Parse(txt_so2.Text);
                    Calculation_21_Hai c = new Calculation_21_Hai(a, b);
                    ketqua = c.Execute("-");
                    txt_ketqua.Text = ketqua.ToString();
                }
                else
                {
                    MessageBox.Show("Cảnh báo", "Vui lòng nhập số a, b!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, ketqua;

                if (string.IsNullOrEmpty(txt_so1.Text) == false && string.IsNullOrEmpty(txt_so2.Text) == false)
                {
                    a = int.Parse(txt_so1.Text);
                    b = int.Parse(txt_so2.Text);
                    Calculation_21_Hai c = new Calculation_21_Hai(a, b);
                    ketqua = c.Execute("*");
                    txt_ketqua.Text = ketqua.ToString();
                }
                else
                {
                    MessageBox.Show("Cảnh báo", "Vui lòng nhập số a, b!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, ketqua;
                
                if (string.IsNullOrEmpty(txt_so1.Text) == false && string.IsNullOrEmpty(txt_so2.Text) == false)
                {
                    a = int.Parse(txt_so1.Text);
                    b = int.Parse(txt_so2.Text);
                    Calculation_21_Hai c = new Calculation_21_Hai(a, b);
                    ketqua = c.Execute("/");
                    txt_ketqua.Text = ketqua.ToString();
                }
                else
                {
                    MessageBox.Show("Cảnh báo", "Vui lòng nhập số a, b!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cảnh báo", "Lỗi chia cho không", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
