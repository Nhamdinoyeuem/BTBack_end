using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15bai1
{
    class Program
    {
        static void Main()
        {
            List<PhanSo> danhSachPhanSo = new List<PhanSo>();
            Console.Write("Nhập số lượng phân số: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập phân số thứ {i + 1}:");
                PhanSo ps = new PhanSo();
                ps.Nhap();
                danhSachPhanSo.Add(ps);
            }

            // Tính tổng các phân số
            PhanSo tong = new PhanSo(0, 1);
            foreach (var ps in danhSachPhanSo)
            {
                tong = PhanSo.Cong(tong, ps);
            }

            Console.Write("Tổng các phân số là: ");
            tong.HienThi();
        }
    }
}
