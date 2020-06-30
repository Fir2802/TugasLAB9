using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab9.ClassInduk
{
    public abstract class Karyawan
    {
        public string NIK;
        public string Nama;
        public string JenisKaryawan;
        public abstract double Gaji();
    }
}