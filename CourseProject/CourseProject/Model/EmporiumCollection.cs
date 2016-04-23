using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    class EmporiumCollection
    {
        List<Emporium> emporiums = new List<Emporium>();
        public Emporium this[int i]
        {
            get
            {
                return emporiums[i];
            }
        }
       

        //LIST
        
        public void Addd(Emporium emp)
        {
            emporiums.Add(emp);
        }
        public int Findd(Emporium emp)
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
        public void Delete(Emporium emp)
        {
            emporiums.Remove(emp);
        }
    }
}
