using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2276
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kr1 = new Karyawan();

            kr1.Nik = "190302123";
            kr1.Nama = "Paijo";
            kr1.GajiBulanan = 3000000;

            Karyawan kr2 = new Karyawan();

            kr2.Nik = "190302124";
            kr2.Nama = "Jono";
            kr2.GajiBulanan = 2000000;

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("No.\tNik/Nama\t\t\tGaji Bulanan");
            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kr1.Nik, kr1.Nama, kr1.GajiBulanan);
            Console.WriteLine("2.\t{0}  {1}\t\t\t{2}", kr2.Nik, kr2.Nama, kr2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Asyiik Kenaikan Gaji 10%");
            Console.WriteLine("\n");
            Console.WriteLine("No.\tNik/Nama\t\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kr1.Nik, kr1.Nama, kr1.GajiBulanan + (kr1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0}  {1}\t\t\t{2}", kr2.Nik, kr2.Nama, kr2.GajiBulanan + (kr2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
