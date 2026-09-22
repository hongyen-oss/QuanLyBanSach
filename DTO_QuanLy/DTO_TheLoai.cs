using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_TheLoai
    {
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }

        public DTO_TheLoai(string ma, string ten)
        {
            this.MaTheLoai = ma;
            this.TenTheLoai = ten;
        }
    }
}