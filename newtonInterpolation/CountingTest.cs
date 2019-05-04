using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtonInterpolation
{
    class CountingTest
    {
        public float inter2_1;
        public float inter2_2;
        public float inter2_3;
        public float inter3_1;
        public float inter3_2;
        public float inter4_1;
        

        public CountingTest(float number1, float number2, float number3, float number4)
        {

            inter2_1 = number2 - ((number2 - number1) / 3);
            inter2_2 = number3 - ((number3 - number2) / 3);
            inter2_3 = number4 - ((number4 - number3) / 3);

            inter3_1 = inter2_2 - ((inter2_2 - inter2_1) / 3);
            inter3_1 = inter2_2 - ((inter2_2 - inter2_1) / 3);
            inter3_1 = inter2_2 - ((inter2_2 - inter2_1) / 3);
            inter3_1 = inter2_2 - ((inter2_2 - inter2_1) / 3);
            inter3_2 = inter2_3 - ((inter2_3 - inter2_2) / 3);

            inter4_1 = inter3_2 - ((inter3_2 - inter3_1) / 3);
           
        }
    }
}
