using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2481
{
    class Karyawan
    {
        public int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        public Karyawan()
        {

        }

        public Karyawan(int nik, string nama, int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
        }

        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
    }
}
