
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15bai2
{
    class HinhChuNhat : Hinh 
    {
        public double Dai { get; set; }
        public double Rong { get; set; }

        public HinhChuNhat(double dai, double rong)
        {
            Dai = dai;
            Rong = rong;
        }

        public override double TinhChuVi()
        {
            return 2 * (Dai + Rong);
        }

        public override double TinhDienTich()
        {
            return Dai * Rong;
        }
    }
}
