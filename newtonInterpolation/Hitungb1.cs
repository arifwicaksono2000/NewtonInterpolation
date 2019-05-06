using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtonInterpolation
{
    class Hitungb1
    {
        private float atas;
        public float b { get; set; }

        public Hitungb1(float angka1, float angka2, float f_angka1, float f_angka2)
        {
            atas = f_angka2 - f_angka1;
            b = atas / (angka2 - angka1);
        }
    }
}
