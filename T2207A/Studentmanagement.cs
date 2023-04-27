using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Studentmanagement
    {
        private List<Students> danhSachSinhVien;

        public Studentmanagement()
        {
            danhSachSinhVien = new List<Students>();
        }

        public void ThemSinhVien()
        {
            Console.Write("Nhap ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string gioiTinh = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            double diemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            double diemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            double diemHoa = double.Parse(Console.ReadLine());

            Students sv = new Students()
            {
                id = id,
                ten = ten,
                gioiTinh = gioiTinh,
                tuoi = tuoi,
                diemToan = diemToan,
                diemLy = diemLy,
                diemHoa = diemHoa
            };
            sv.TinhDiemTrungBinh();
            sv.TinhHocLuc();
            danhSachSinhVien.Add(sv);
            Console.WriteLine("Them sinh vien thanh cong!");
        }

        public void CapNhatSinhVien()
        {
            Console.Write("Nhap ID sinh vien can cap nhatt: ");
            int id = int.Parse(Console.ReadLine());
            Students sv = danhSachSinhVien.Find(x => x.id == id);
            if (sv != null)
            {
                Console.Write("Nhap ten: ");
                sv.ten = Console.ReadLine();
                Console.Write("Nhap gioi tinh: ");
                sv.gioiTinh = Console.ReadLine();
                Console.Write("Nhap tuoi: ");
                sv.tuoi = int.Parse(Console.ReadLine());
                Console.Write("Nhap diem toan: ");
                sv.diemToan = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem ly: ");
                sv.diemLy = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem hoa: ");
                sv.diemHoa = double.Parse(Console.ReadLine());
                sv.TinhDiemTrungBinh();
                sv.TinhHocLuc();
                Console.WriteLine("Cap nhat thong tin sinh vien thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
        }

        public void XoaSinhVien()
        {
            Console.Write("Nhap ID sinh vien can xoa: ");
            int id = int.Parse(Console.ReadLine());
            Students sv = danhSachSinhVien.Find(x => x.id == id);
            if (sv != null)
            {
                danhSachSinhVien.Remove(sv);
                Console.WriteLine("Xoa sinh vien thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
        }

        public void TimKiemSinhVien()
        {
            Console.Write("Nhap ten sinh vien can tim: ");
            string ten = Console.ReadLine();
            List<Students> dsTimKiem = danhSachSinhVien.Where(x => x.ten.Contains(ten)).ToList();
            if (dsTimKiem.Count > 0)
            {
                Console.WriteLine("Danh sach sinh vien:");
                Console.WriteLine("ID \tTen \tGioi tinh \tTuoi \tToan \tLy \tHoa \tĐiem TB \tHoc luc");
                foreach (Students sv in dsTimKiem)
                {
                    Console.WriteLine(sv.ToString());
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien!");
            }
        }

        public void SapXepTheoDiemTrungBinh()
        {
            danhSachSinhVien = danhSachSinhVien.OrderByDescending(x => x.diemTrungBinh).ToList();
            Console.WriteLine("Sap xep thanh cong!");
        }

        public void SapXepTheoTen()
        {
            danhSachSinhVien = danhSachSinhVien.OrderBy(x => x.ten).ToList();
            Console.WriteLine("Sap xep thanh cong!");
        }

        public void SapXepTheoID()
        {
            danhSachSinhVien = danhSachSinhVien.OrderBy(x => x.id).ToList();
            Console.WriteLine("Sap xep thanh cong!");
        }

        public void HienThiDanhSachSinhVien()
        {
            Console.WriteLine("Danh sach sinh vien:");
            Console.WriteLine("ID \tTen \tGioi tinh \tTuoi \tToan \tLy \tHoa \tĐiem TB \tHoc luc");
            foreach (Students sv in danhSachSinhVien)
            {
                Console.WriteLine(sv.ToString());
            }
        }
    }
}
