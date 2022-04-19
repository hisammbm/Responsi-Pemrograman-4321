using System;

namespace ResponsiPemrograman4321
{
    class Program
    {
        static void Main(string[] args)
        {
        Karyawan Paijo = new Karyawan();
        Karyawan Jono  = new Karyawan();

        Paijo.NIK = "190302123";
        Paijo.Nama = "Paijo";
        Paijo.GajiBulanan = 3000000;

        Jono.NIK = "190302124";
        Jono.Nama = "Jono";
        Jono.GajiBulanan =  2000000;

        Console.WriteLine("No Nik/Nama              Gaji Bulanan");
        Console.WriteLine("----------------------------------------");
        Console.Write("1 ");Paijo.Tampilan();
        Console.Write("2 ");Jono.Tampilan();
        Console.WriteLine();

        Console.ReadKey();
        }
    }
}