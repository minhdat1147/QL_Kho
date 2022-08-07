using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Kho
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

      

      

       


        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào " + Program.ten;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHoaDon a = new frmHoaDon();
            this.Hide();
            a.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmPhieuNhap a = new frmPhieuNhap();
            this.Hide();
            a.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
