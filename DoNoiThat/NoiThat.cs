using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNoiThat
{
    public class NoiThat
    {
        private string ma;
        private string ten;
        private string maLoai;
        private string maKieu;
        private string maMau;
        private string maChatLieu;
        private string maNuocSX;
        private int soLuong;
        private double donGiaNhap;
        private double donGiaXuat;
        private string picturePath;
        private string thoiGianBH;

        public NoiThat(string ma, string ten, string maLoai, string maKieu, string maMau, string maChatLieu, string maNuocSX, int soLuong, double donGiaNhap, double donGiaXuat, string picturePath, string thoiGianBH)
        {
            Ma = ma;
            Ten = ten;
            MaLoai = maLoai;
            MaKieu = maKieu;
            MaMau = maMau;
            MaChatLieu = maChatLieu;
            MaNuocSX = maNuocSX;
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;
            DonGiaXuat = donGiaXuat;
            PicturePath = picturePath;
            ThoiGianBH = thoiGianBH;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string MaKieu { get => maKieu; set => maKieu = value; }
        public string MaMau { get => maMau; set => maMau = value; }
        public string MaChatLieu { get => maChatLieu; set => maChatLieu = value; }
        public string MaNuocSX { get => maNuocSX; set => maNuocSX = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public double DonGiaXuat { get => donGiaXuat; set => donGiaXuat = value; }
        public string PicturePath { get => picturePath; set => picturePath = value; }
        public string ThoiGianBH { get => thoiGianBH; set => thoiGianBH = value; }
    }
}
