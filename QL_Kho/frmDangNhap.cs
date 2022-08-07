using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_Kho
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "QL01" && textBox2.Text == "123456")
            {
                Program.ten = comboBox1.Text;
                frmMain fn = new frmMain();
                this.Hide();
                fn.Show();
            }
            else if (comboBox1.Text == "NV01" && textBox2.Text == "123456")
            {
                Program.ten = comboBox1.Text;
                Program.TK = "NV";

                frmMain fn = new frmMain();
                this.Hide();
                fn.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại tài khoản hoặc mật khẩu", "Thông Báo");
            }
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_KHODIENTUDataSet5.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_KHODIENTUDataSet5.NHANVIEN);
            comboBox1.SelectedIndex = 1;
        }
    }
}
