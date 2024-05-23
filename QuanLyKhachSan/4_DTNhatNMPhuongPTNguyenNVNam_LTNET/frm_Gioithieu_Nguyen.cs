using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_Gioithieu_Nguyen : Form
    {
        public frm_Gioithieu_Nguyen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Gioithieu_Nguyen_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;

        }

        private void btn_truycap_Nguyen_Click(object sender, EventArgs e)
        {
            frm_Dangnhap_Nam frm = new frm_Dangnhap_Nam();
            this.Hide();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


    }

