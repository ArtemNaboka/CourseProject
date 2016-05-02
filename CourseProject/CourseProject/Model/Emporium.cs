using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    class Emporium
    {
        public string name;
        public string address;
        public string phone;
        public string specialization;
        public string FormOfOwn;
        public struct TimeOfStart
        {
            public int hours;
            public int minutes;
        }
        public struct TimeOfFinish
        {
            public int hours;
            public int minutes;
        }

        public TimeOfStart timeOfStart;
        public TimeOfFinish timeOfFinish;

        /*public Emporium(string name, string address, string phone, string specialization, string FormOfOwn, TimeOfStart TOS, TimeOfFinish TOF)
        {
            this.name = name;
            this.address = address;
            this.specialization = specialization;
            this.FormOfOwn = FormOfOwn;
            timeOfStart = TOS;
            timeOfFinish = TOF;
        }*/
    }
}
