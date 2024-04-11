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
            int a, b, ketqua;
            a = int.Parse(txt_so_a.Text.ToString());
            b = int.Parse(txt_so_b.Text.ToString());
            Calculation_21_Hai calculation_21_Hai = new Calculation_21_Hai(a, b);
            ketqua = calculation_21_Hai.Execute("+");
            txt_kq.Text = ketqua.ToString();
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_so_a.Text.ToString());
            b = int.Parse(txt_so_b.Text.ToString());
            Calculation_21_Hai calculation_21_Hai = new Calculation_21_Hai(a, b);
            ketqua = calculation_21_Hai.Execute("-");
            txt_kq.Text = ketqua.ToString();
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_so_a.Text.ToString());
            b = int.Parse(txt_so_b.Text.ToString());
            Calculation_21_Hai calculation_21_Hai = new Calculation_21_Hai(a, b);
            ketqua = calculation_21_Hai.Execute("*");
            txt_kq.Text = ketqua.ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt_so_a.Text.ToString());
            b = int.Parse(txt_so_b.Text.ToString());
            Calculation_21_Hai calculation_21_Hai = new Calculation_21_Hai(a, b);
            ketqua = calculation_21_Hai.Execute("/");
            txt_kq.Text = ketqua.ToString();
        }
    }
}
