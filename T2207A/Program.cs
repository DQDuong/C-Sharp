// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using T2207A;

public class Program
{
    public static void Main(string[] args)
    {
        Studentmanagement quanLySinhVien = new Studentmanagement();
        int chucNang = 0;
        do
        {
            Console.WriteLine("Chon chuc nang:");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Cap nhat thong tin sv boi ID");
            Console.WriteLine("3. Xoa sv boi ID");
            Console.WriteLine("4. Tim kiem sv theo ten");
            Console.WriteLine("5. Sap xep sv theo diem trung binh (GPA)");
            Console.WriteLine("6. Sap xep sv theo ten");
            Console.WriteLine("7. Sap xep sv theo ID");
            Console.WriteLine("8. Hien thi danh sach sv");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang: ");
            chucNang = int.Parse(Console.ReadLine());
            switch (chucNang)
            {
                case 1:
                    quanLySinhVien.ThemSinhVien();
                    break;
                case 2:
                    quanLySinhVien.CapNhatSinhVien();
                    break;
                case 3:
                    quanLySinhVien.XoaSinhVien();
                    break;
                case 4:
                    quanLySinhVien.TimKiemSinhVien();
                    break;
                case 5:
                    quanLySinhVien.SapXepTheoDiemTrungBinh();
                    break;
                case 6:
                    quanLySinhVien.SapXepTheoTen();
                    break;
                case 7:
                    quanLySinhVien.SapXepTheoID();
                    break;
                case 8:
                    quanLySinhVien.HienThiDanhSachSinhVien();
                    break;
                case 0:
                    Console.WriteLine("Ket thuc");
                    break;
                default:
                    Console.WriteLine("Chuc nang khong ton tai!");
                    break;
            }
            Console.WriteLine();
        } while (chucNang != 0);
    }
}
    //Console.WriteLine("Hello world");
    //    int x = 10;
    //    string s = "T2207A";
    //    double pi = 3.14159;
    //    if (x > 5)
    //    {
    //        x--;
    //    }
    //    else
    //    {
    //        x++;
    //    }
    //    int[] arr = new int[5];
    //    arr[0] = 1;
    //    arr[1] = 15;
    //    arr[2] = 9;
    //    arr[3] = 55;
    //    arr[4] = -16;

    //    foreach (int i in arr)
    //    {
    //        Console.WriteLine(i);
    //    }
    //    string cmd = Console.ReadLine();
    //    Console.WriteLine("Chuoi vua nhap: "+cmd);
    //    string cmd2 = Console.ReadLine();
    //    int n = Convert.ToInt32(cmd2);
    //    Console.WriteLine("So vua nhap: " + n);
    //    if ( isPrime(n) )
    //    {
    //        Console.WriteLine(n+ "la so nguyen to");
    //    }
    //    List<int> ints = new List<int>();
    //    ints.Add(4);
    //    ints.Add(19);

    //    Student st = new Student();
    //    st.Run();
    //    st.Learn("ABC");
    //    Console.WriteLine(st.Name);
    //    st.Name = "Nguyen Van A";

    //    Human h = new Human();
    //    Human h2 = new Human() { Telephone = "09876543"};

        


    //public static bool isPrime(int n)
    //{
    //    if (n < 2) return false;
    //    if (n < 4) return true;
    //    for (int i = 2; i <= n/2; i++) { 
    //    if (n % i == 0) return false;
    //    }
    //    return true;

    //    News news = new News();
    //    news.Id = 1;
    //    news.Title = "Hello World";
    //    news.PublishDate = "21-04-2023";
    //    news.Author = "Do Quang Duong";
    //    news.Content = "This is an example news.";
    //    int[] rateList = { 3, 4, 5 };
    //    news.Calculate(rateList);
    //    news.Display();
    //}
    
