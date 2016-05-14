using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class EmporiumCollection
    {
        List<Emporium> emporiums = new List<Emporium>();
        public EmporiumCollection()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("Information.txt", Encoding.UTF8);
            while ((line = file.ReadLine()) != null)
            {
                string[] formatted = line.Split(new string[] { ";" }, StringSplitOptions.None);
                emporiums.Add(new Emporium() {
                    name = formatted[0],
                    address = formatted[1],
                    phone = formatted[2],
                    specialization = formatted[3],
                    FormOfOwn = formatted[4],
                    timeOfStart = new Emporium.TimeOfStart()
                    {
                        hours = Convert.ToInt32(formatted[5]),
                        minutes = Convert.ToInt32(formatted[6])
                    },
                    timeOfFinish = new Emporium.TimeOfFinish()
                    {
                        hours = Convert.ToInt32(formatted[7]),
                        minutes = Convert.ToInt32(formatted[8])
                    }
                });
            }
            file.Close();
        }
        public Emporium this[int i]
        {
            get
            {
                if (i >= 0 && i < emporiums.Count)
                {
                    return emporiums[i];
                }
                return null;
            }
        }               
        public void Add(Emporium emp)
        {
            emporiums.Add(emp);
        }
        public int Find(Emporium emp)
        {
            
            for(int i = 0; i < emporiums.Count; i++)
            {
                if(emporiums[i].Equals(emporiums))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Remove(Emporium emp)
        {
            emporiums.Remove(emp);
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < length())
            {
                emporiums.RemoveAt(index);
            }
        }

        public int length()
        {
            return emporiums.Count;
        }
    }
}
