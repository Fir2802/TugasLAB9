using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tugas_Lab9.ClassInduk;

namespace Tugas_Lab9.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam;
        public double JumlahJamKerja;
        public override double Gaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }
    }
}


