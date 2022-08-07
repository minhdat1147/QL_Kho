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
using DAO;
using POJO;
using BUS;
namespace QL_Kho
{
    public partial class frmPhieuNhap : Form
    {
        DBConnect1 Conn = new DBConnect1();
        BUS.BUS_PN hdd = new BUS.BUS_PN();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            Program.mapn = int.Parse(txtMaCTHD.Text);
            frmXuatPN a = new frmXuatPN();
            this.Hide();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSQL = "insert into phieunhap values('" + Program.ten + "',null,getdate(),0)";
            Conn.updateDatabase(strSQL);
            phieunhap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCTHD.Text != "" && cboTen.Text != "" && numericUpDown1.Text != "" && txtGia.Text != "" && txtTT.Text != "")
            {
                int hd = int.Parse(txtMaCTHD.Text);
                int sl = int.Parse(numericUpDown1.Text);
                int dg = int.Parse(txtGia.Text);
                int tt = int.Parse(txtTT.Text);
                POJO.DTO_CTPN sp = new POJO.DTO_CTPN(hd, cboTen.Text, sl, dg, tt);
                if (hdd.them(sp))
                {
                    MessageBox.Show("Thêm thành công");
                    loadDL();
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
        public void phieunhap()
        {

            string strSQL = "select mapn from phieunhap";
            SqlDataReader rdr = Conn.getDataReader(strSQL);
            while (rdr.Read())
            {
                txtMaCTHD.Text = (rdr["mapn"].ToString());

            }

            rdr.Close();

        }

        private void cboTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGia.Text = cboTen.SelectedValue.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int sl = Int32.Parse(numericUpDown1.Value.ToString());
            int gia = int.Parse(txtGia.Text);
            int tt = sl * gia;
            txtTT.Text = tt.ToString();
        }
        public void loadDL()
        {
            dgvHD.DataSource = hdd.timkiem1(int.Parse(txtMaCTHD.Text));
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_KHODIENTUDataSet4.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qL_KHODIENTUDataSet4.SANPHAM);
            // TODO: This line of code loads data into the 'qL_KHODIENTUDataSet3.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.qL_KHODIENTUDataSet3.NHACUNGCAP);
            txtGia.Enabled = false;
            txtTT.Enabled = false;
            txtMaCTHD.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain a = new frmMain();
            this.Hide();
            a.ShowDialog();
        }
    }
}
