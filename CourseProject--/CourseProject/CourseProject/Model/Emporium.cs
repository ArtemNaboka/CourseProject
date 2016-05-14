using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class Emporium
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


        public override string ToString()
        {
            return "Название : " + name + "\n" + "Адрес : " + address + Environment.NewLine + "Телефон : " + phone + Environment.NewLine
                    + "Специализация : " + specialization + Environment.NewLine + "Форма собственности : " + FormOfOwn + Environment.NewLine + "Время работы : " +
                    timeOfStart.hours + ":" + timeOfStart.minutes + " - " + timeOfFinish.hours + ":" + timeOfFinish.minutes + Environment.NewLine + " "; ;
        }


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
