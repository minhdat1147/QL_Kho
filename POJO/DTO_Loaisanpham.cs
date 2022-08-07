using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POJO
{
    public class DTO_Loaisanpham
    {
        private string maloai;

        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }
        private string tenloai;

        public string Tenloai
        {
            get { return tenloai; }
            set { tenloai = value; }
        }
        public DTO_Loaisanpham()
        {
        }
        public DTO_Loaisanpham(string maloai, string tenloai)
        {
            this.Maloai = maloai;
            this.Tenloai = tenloai;
        }
    }
}
