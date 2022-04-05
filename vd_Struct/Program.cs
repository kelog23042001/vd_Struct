using System;

namespace vd_Struct
{
    class Program
    {
        struct SinhVien
        {
            public int MaSV_232;
            public string HoTen_232;
            public string GioiTinh_232;
            public double DiemToan_232;
            public double DiemLy_232;
            public double DiemHoa_232;
            public double DiemAnh_232;
            public double DiemTB_232;
        }
        enum Gender { NAM_232 = 0, NU_232 = 1, KHAC_232 = 2 }
        static void NhapTTSV(out SinhVien sv_232)
        {
            sv_232.DiemTB_232 = 0;
            Console.Write("Nhap ma sinh vien: ");
            sv_232.MaSV_232 = int.Parse(Console.ReadLine());
            Console.Write("Ho va ten: ");
            sv_232.HoTen_232 = Console.ReadLine();
            Console.Write("Gioi tinh: ");
            int Choose = int.Parse(Console.ReadLine());
            if (Choose == (int)Gender.NAM_232)
                sv_232.GioiTinh_232 = "Nam";
            else  if (Choose == (int)Gender.NU_232)
                sv_232.GioiTinh_232 = "Nu";
            else
                sv_232.GioiTinh_232 = "Khac";
            Console.Write("Diem toan: ");
            sv_232.DiemToan_232 = Double.Parse(Console.ReadLine());
            Console.Write("Diem ly: ");
            sv_232.DiemLy_232 = Double.Parse(Console.ReadLine());
            Console.Write("Diem hoa: ");
            sv_232.DiemHoa_232 = Double.Parse(Console.ReadLine());
            Console.Write("Diem anh: ");
            sv_232.DiemAnh_232 = Double.Parse(Console.ReadLine());
        }
        static void XuatTTSV(SinhVien sv_232)
        {
            Console.WriteLine("Ma sinh vien: " + sv_232.MaSV_232);
            Console.WriteLine("Ho va ten: " + sv_232.HoTen_232);
            Console.WriteLine("Gioi tinh: " + sv_232.GioiTinh_232);
            Console.WriteLine("Diem toan: " + sv_232.DiemToan_232);
            Console.WriteLine("Diem ly: " + sv_232.DiemLy_232);
            Console.WriteLine("Diem hoa: " + sv_232.DiemHoa_232);
            Console.WriteLine("Diem anh: " + sv_232.DiemAnh_232);
            Console.WriteLine("Diem trung binh: " + DiemTB(sv_232));
        }
        static void NhapNhieuSinhVien(SinhVien[] sv_232, int n_232)
        {
            for (int i_232 = 0; i_232 < n_232; i_232++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu " + (i_232+1) );
                NhapTTSV(out sv_232[i_232]);
            }
        }
        static void XuatNhieuSinhVien(SinhVien[] sv_232)
        {
            foreach(SinhVien item in sv_232)
            {
                XuatTTSV(item);
            }
        }
        static  double DiemTB(SinhVien sv_232)
        {
            return (sv_232.DiemAnh_232 + sv_232.DiemHoa_232 + sv_232.DiemLy_232 + sv_232.DiemToan_232) / 4;
        }

       static void TimKiemSV(SinhVien[] sv_232, string name_232)
        {
            for(int i_232 = 0; i_232 < sv_232.Length; i_232++)
            {
                if (sv_232[i_232].HoTen_232.Equals(name_232))
                    XuatTTSV(sv_232[i_232]);
            }
        }
        
       
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n_232 = int.Parse(Console.ReadLine());
            SinhVien[] sv_232 = new SinhVien[n_232];
            
            NhapNhieuSinhVien(sv_232, n_232);
          
            Console.WriteLine("=======Thong tin sinh vien=======");
            XuatNhieuSinhVien(sv_232);

            Console.Write("Nhap ten sinh vien tim kiem: ");
            string name = Console.ReadLine();
            Console.WriteLine("Sinh vien can tim: ");
            TimKiemSV(sv_232, name);
        
        }
    }
}
