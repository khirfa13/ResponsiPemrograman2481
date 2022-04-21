using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2481
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;

            Karyawan karyawan3 = new Karyawan();

            Karyawan karyawan1 = new Karyawan(190302123, "Paijo", 3000000);
            CetakHasil(karyawan1);

            Console.WriteLine();


            Karyawan karyawan2 = new Karyawan(190302124, "Jono", 2000000);
            CetakHasil(karyawan2);

            hasil = karyawan3.Penjumlahan(3000000, 300000);
            CetakHasil2("Naik gaji: " + hasil);

            Console.ReadKey();

        }

        static void CetakHasil(Karyawan kryn)
        {
            Console.WriteLine("Nik: {0}", kryn.Nik);
            Console.WriteLine("Nama: {0}", kryn.Nama);
            Console.WriteLine("Gaji Bulanan: {0}", kryn.GajiBulanan);
        }
        static void CetakHasil2(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
