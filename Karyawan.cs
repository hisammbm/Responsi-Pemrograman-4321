using System;

namespace ResponsiPemrograman4321
{
    class Karyawan{
        public string Nama { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }

        public void Tampilan()
        {
            Console.WriteLine("{0} {1}              {2}", NIK, Nama, GajiBulanan); 
        }
    }
}