using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    /// <summary>
    /// Этот класс предназначен для работы
    /// с текстовыми файлами, считывания и 
    /// записывания в них данных.
    /// </summary>
    class DataBase
    {
        // Элемент для считывания с файла/
        static StreamReader _reader;

        // Элемент для записи в файл/
        static StreamWriter _writer;


        /// <summary>
        /// Этот метод будет принимать коллекцию и заполнять ее
        /// данными из текстового файла с заданым путем.
        /// </summary>
        /// <param name="emporiums">Коллекция для наполнения данными</param>
        /// <param name="path">Путь к текстовому файлу</param>
        public static void FillCollection(BindingList<Emporium> emporiums,
            string path)
        {
            _reader = new StreamReader(path, Encoding.UTF8);
            string line;
            while ((line = _reader.ReadLine()) != null)
            {
                string[] formatted = line.Split(new string[] { ";" },
                    StringSplitOptions.None);
                emporiums.Add(new Emporium()
                {
                    Id = emporiums.Count == 0 ? 1 : emporiums[
                        emporiums.Count - 1].Id + 1,
                    Name = formatted[0],
                    Address = formatted[1],
                    Phone = formatted[2],
                    Specialization = formatted[3],
                    FormOfOwn = formatted[4],
                    TimeOfEmpWork = new TimeOfWork(Convert.ToDateTime(
                        formatted[5]), Convert.ToDateTime(formatted[6]))
                });
            }
            _reader.Close();
        }


        /// <summary>
        /// Этот метод предназначен для записи данных
        /// из коллекции в текстовый файл.
        /// </summary>
        /// <param name="emporiums">Коллекция, из которой будут считываться 
        /// данные</param>
        /// <param name="path">Путь к текстовому файлу, в который будут
       ///  записываться данные</param>
        public static void SaveDB(EmporiumCollection emporiums, string path)
        {
            _writer = new StreamWriter(path, false, Encoding.UTF8);
            foreach (Emporium emporium in emporiums)
            {
                _writer.WriteLine(emporium.Name + ";" + emporium.Address + ";" 
                    + emporium.Phone + ";" + emporium.Specialization + ";" +
                    emporium.FormOfOwn + ";" +
                    emporium.TimeOfEmpWork.StartTime + ";" 
                    + emporium.TimeOfEmpWork.FinishTime);
            }
            _writer.Close();
        }

    }
}
