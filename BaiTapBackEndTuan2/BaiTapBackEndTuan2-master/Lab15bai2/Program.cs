using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15bai2
{
    class Program
    {
            static void Main()
            {
                List<Hinh> danhSachHinh = new List<Hinh>();

                // Thêm một số hình vào danh sách
                danhSachHinh.Add(new HinhTron(5));
                danhSachHinh.Add(new HinhVuong(4));
                danhSachHinh.Add(new HinhChuNhat(3, 6));
                danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

                double tongChuVi = 0, tongDienTich = 0;

                foreach (var hinh in danhSachHinh)
                {
                    tongChuVi += hinh.TinhChuVi();
                    tongDienTich += hinh.TinhDienTich();
                }

                Console.WriteLine($"Tổng chu vi các hình: {tongChuVi:F2}");
                Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");
            }
        }
}
