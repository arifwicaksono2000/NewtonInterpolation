using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtonInterpolation
{
    class Counting
    {
        private float inter2_1;
        private float inter2_2;
        private float inter2_3;
        private float inter3_1;
        private float inter3_2;
        private float inter4_1;
        //public string interThrow { get; set; }

        public bool loadScenarioNumberExecuted = false;
        Counting count1;
        Counting count2;

        public Counting(float number1, float number2, float number3, float number4)
        {
            
            inter2_1 = number2 - ((number2 - number1) / 3);
            inter2_2 = number3 - ((number3 - number2) / 3);
            inter2_3 = number4 - ((number4 - number3) / 3);
            
            count1 = new Counting(inter2_1, inter2_2, inter2_3);

        }

        public Counting(float number1, float number2, float number3)
        {
            
            inter3_1 = number2 - ((number2 - number1) / 3);
            inter3_2 = number3 - ((number3 - number2) / 3);
            loadScenarioNumberExecuted = true;
            count2 = new Counting(inter3_1, inter3_2);
        }

        public Counting(float number1, float number2)
        {

            inter4_1 = number2 - ((number2 - number1) / 3);
            //interThrow = inter4_1.ToString();
            
        }

        //public float CountingNumber1(float number1, float number2, float number3, float number4)
        //{
        //    float a = number1 + number2 + number3 + number4;
        //    return a;
        //}

        //public float CountingNumber2(float number1, float number2, float number3, float number4)
        //{
        //    float a = number1 + number2 + number3 + number4;
        //    return a;
        //}
        
        //public float CountingNumber3(float number1, float number2, float number3, float number4)
        //{
        //    float a = number1 + number2 + number3 + number4;
        //    return a;
        //}

        //public float CountingNumber4(float number1, float number2, float number3, float number4)
        //{
        //    float a = number1 + number2 + number3 + number4;
        //    return a;
        //}
    }
}
