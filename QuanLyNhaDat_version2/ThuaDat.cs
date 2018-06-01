using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaDat_version2
{
    public class ThuaDat
    {
        private string diaChi, chuSoHuu, loaiNha, mucDichSuDung;
        private double dienTich, giaTien;

        public ThuaDat()
        {
        }

        public ThuaDat(string diaChi, double dienTich, string chuSoHuu, string loaiNha, string mucDichSuDung, double giaTien)
        {
            this.diaChi = diaChi;
            this.chuSoHuu = chuSoHuu;
            this.dienTich = dienTich;
            this.loaiNha = loaiNha;
            this.mucDichSuDung = mucDichSuDung;
            this.giaTien = giaTien;
        }


        public string ChuSoHuu
        {
            get
            {
                return chuSoHuu;
            }

            set
            {
                chuSoHuu = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public double DienTich
        {
            get
            {
                return dienTich;
            }

            set
            {
                dienTich = value;
            }
        }

        public double GiaTien
        {
            get
            {
                return giaTien;
            }

            set
            {
                giaTien = value;
            }
        }

        public string LoaiNha
        {
            get
            {
                return loaiNha;
            }

            set
            {
                loaiNha = value;
            }
        }

        public string MucDichSuDung
        {
            get
            {
                return mucDichSuDung;
            }

            set
            {
                mucDichSuDung = value;
            }
        }
    }

    public class Phuong
    {
        private int id;
        private string tenPhuong;
        private int thuocQuan;

        public Phuong(DataRow row)
        {
            this.id = (int)row["id"];
            this.tenPhuong = row["tenPhuong"].ToString();
            this.thuocQuan = (int)row["thuocQuan"];
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string TenPhuong
        {
            get
            {
                return tenPhuong;
            }

            set
            {
                tenPhuong = value;
            }
        }

        public int ThuocQuan
        {
            get
            {
                return thuocQuan;
            }

            set
            {
                thuocQuan = value;
            }
        }
    }

    public class Quan
    {
        private int id;
        private string tenQuan;

        public Quan(DataRow row)
        {
            this.id = (int)row["id"];
            this.tenQuan = row["tenQuan"].ToString();
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string TenQuan
        {
            get
            {
                return tenQuan;
            }

            set
            {
                tenQuan = value;
            }
        }
    }
}
