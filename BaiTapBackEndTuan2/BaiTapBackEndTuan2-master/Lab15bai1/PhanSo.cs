using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15bai1
{
    class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        // Constructor
        public PhanSo(int tuSo = 0, int mauSo = 1)
        {
            TuSo = tuSo;
            MauSo = mauSo != 0 ? mauSo : 1;
            RutGon();
        }

        // Nhập phân số
        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
            if (MauSo == 0)
            {
                Console.WriteLine("Mẫu số không được bằng 0. Gán mẫu số = 1.");
                MauSo = 1;
            }
            RutGon();
        }

        // Hiển thị phân số
        public void HienThi()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

        // Rút gọn phân số
        private void RutGon()
        {
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln;
            MauSo /= ucln;
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        // Tính ước chung lớn nhất
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        // Cộng hai phân số
        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            int tu = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int mau = a.MauSo * b.MauSo;
            return new PhanSo(tu, mau);
        }
    }
}
