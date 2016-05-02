using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    class EmporiumCollection
    {
        public List<Emporium> emporiums = new List<Emporium>();
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
    }
}
