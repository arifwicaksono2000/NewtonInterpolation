using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtonInterpolation
{
    class CountingTest
    {
        
        public float fx { get; set; }
        

        public CountingTest(float number0, float number1, float number2, float number3, float f_number0, float f_number1, float f_number2, float f_number3, float newTarget)
        {
            Hitungb1 b10 = new Hitungb1(number0, number1, f_number0, f_number1);
            Hitungb1 b21 = new Hitungb1(number1, number2, f_number1, f_number2);
            Hitungb1 b32 = new Hitungb1(number2, number3, f_number2, f_number3);
            float newb10 = b10.b;
            float newb21 = b21.b;
            float newb32 = b32.b;

            float newb20 = (newb21 - newb10) / (number2 - number0);
            float newb31 = (newb32 - newb21) / (number3 - number1);

            float newb30 = (newb31 - newb20) / (number3 - number0);

            fx = f_number0 + 
                 newb10 * (newTarget - number0) + 
                 newb20 * (newTarget - number0) * (newTarget - number1) + 
                 newb30 * (newTarget - number0) * (newTarget - number1) * (newTarget - number2);

        }
    }
}
