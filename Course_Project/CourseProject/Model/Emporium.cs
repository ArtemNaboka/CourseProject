using System;

namespace CourseProject.Model
{
    // Класс Торговая Точка.
    public class Emporium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Specialization { get; set; }
        public string FormOfOwn { get; set; }
        public TimeOfWork TimeOfEmpWork;


        public override string ToString()
        {
            return Name;
        }

        

        
       
    }

    // Cтруктура, хранящая время работы торговой точки.
    public struct TimeOfWork
    {
        public DateTime StartTime;
        public DateTime FinishTime;
        public TimeOfWork(DateTime start, DateTime finish)
        {
            StartTime = start;
            FinishTime = finish;
        }
        public string FullInfo
        {
            get
            {
                return StartTime.ToShortTimeString() + " - "
                    + FinishTime.ToShortTimeString();
            }
        }

        // Возвращает true, 
        // если две торговые точки имеют одинаковое время работы.
        public bool IsSameTime(TimeOfWork otherTime)
        {
            return StartTime.ToShortTimeString() ==
                otherTime.StartTime.ToShortTimeString() &&
                FinishTime.ToShortTimeString() ==
                otherTime.FinishTime.ToShortTimeString();
        }


        // Возвращает true,
        // если время окончания работы не совпадает с временем начала работы. 
        public bool StartIsNotEqualEnd()
        {
            return StartTime.ToShortTimeString() != FinishTime.ToShortTimeString();
        }
    }


}
