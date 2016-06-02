using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CourseProject.Model
{
    /// <summary>
    /// Класс предназначен для хранения в коллекциии
    /// всех торговых точек и совершения действий над ними
    /// </summary>
    public class EmporiumCollection : IEnumerable
    {
        BindingList<Emporium> _emporiums = new BindingList<Emporium>();


        // Конструктор по умолчанию
        public EmporiumCollection()
        {

        }


          /// <summary>
          /// Конструктор с параметром.
          /// </summary>
          /// <param name="path">Путь к файлу, из которого считываются данные
          /// </param>
        public EmporiumCollection(string path)
        {
            DataBase.FillCollection(_emporiums, path);
        }


        // Индексатор. Возвращает элемент по его индексу в коллекции.
        public Emporium this[int i]
        {
            get
            {
                if (i >= 0 && i < _emporiums.Count)
                {
                    return _emporiums[i];
                }
                return null;
            }
        }


        // Добавление элемента в коллекцию.  
        public void Add(Emporium emp)
        {
            emp.Id = _emporiums.Count == 0 ? 1 
                : _emporiums[_emporiums.Count - 1].Id + 1; 
            _emporiums.Add(emp);
        }


        // Поиск элемента коллекции по значению.
        public int Find(Emporium emp)
        {
            
            for(int i = 0; i < _emporiums.Count; i++)
            {
                if(_emporiums[i].Equals(_emporiums))
                {
                    return i;
                }
            }
            return -1;
        }


        // Удаление элемента по значению.
        public void Remove(Emporium emp)
        {
            _emporiums.Remove(emp);
        }


        // Удаление элемента по индексу.
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < length())
            {
                _emporiums.RemoveAt(index);
            }
        }


        // Удаление торговой точки по Id
        public void RemoveById(int id)
        {
            var foundComp = _emporiums.SingleOrDefault(x => x.Id == id);
            if (foundComp != null)
                _emporiums.Remove(foundComp);
            else
                throw new KeyNotFoundException("Id wasn't found");
        }


        // Количество элементов в коллекции.
        public int length()
        {
            return _emporiums.Count;
        }


        // Реализация интерфейса IEnumerable.
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < _emporiums.Count; i++)
            {
                yield return _emporiums[i];
            }
        }


        // Обновление/редактирование определенной торговой точки.
        public void UpdateEmporium(Emporium emp_before, Emporium emp_after)
        {
            for(int i = 0; i < _emporiums.Count; i++)
            {
                if(_emporiums[i].Equals(emp_before))
                {
                    _emporiums[i] = emp_after;
                }
            }
        }


        // Получение торговой точки по Id.
        public Emporium GetEmpById(int Id)
        {
            foreach(Emporium emp in _emporiums)
            {
                if(emp.Id == Id)
                {
                    return emp;
                }
            }
            return null;
        }


        /// <summary>
        /// Поиск торговых точек, свойства которых совпадают
        /// со свойствами объекта - "критерия поиска".
        /// </summary>
        /// <param name="emp">критерий поиска</param>
        /// <returns></returns>
        public List<Emporium> Search(Emporium emp)
        {
            List<Emporium> emporiums = new List<Emporium>();
            foreach(Emporium emporium in _emporiums)
            {
                if(emporium.Name.ToLower().Contains(emp.Name.ToLower()) &&
                    emporium.Address.ToLower().Contains(emp.Address)
                    && emporium.Phone.Contains(emp.Phone) &&
                    emporium.FormOfOwn.Contains(emp.FormOfOwn) &&
                    emporium.Specialization.Contains(emp.Specialization) &&
                    (emp.TimeOfEmpWork.StartIsNotEqualEnd() ?
                    emporium.TimeOfEmpWork.IsSameTime(emp.TimeOfEmpWork) 
                    : true))
                {
                    emporiums.Add(emporium);
                } 
            }
            return emporiums;
        }
    }
}
