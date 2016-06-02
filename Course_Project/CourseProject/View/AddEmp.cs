using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace CourseProject
{   

    /// <summary>
    /// Форма предназначена для добавления
    /// новой торговой точки в коллекцию.
    /// </summary>
    public partial class AddEmp : Form
    {
        // Объект, который будет добавлен.
        public Emporium EmpToAdd;


        public AddEmp()
        {
            InitializeComponent();
            EmpToAdd = null;
        }

        // При нажатии на кнопку Сохранить будет проиcходить 
        // проверка заполненности всех полей
        // и при положительном результате будет формироваться новый объект
        // для добавления в коллекцию
        private void saveBtn_Click(object sender, EventArgs e)
        { 
            if (nameOfEmpTB.TextLength == 0 || addressOfEmpTB.TextLength == 0)
            {
                MessageBox.Show("Заполните все поля");
            }
            else if (ownBoxCB.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите форму собственности");
            }
            else if (specBoxCB.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите специализацию");
            }
            else if(not_numbers(firstDigsTB.Text) 
                || not_numbers(secondDigsTB.Text) 
                || not_numbers(thirdDigsTB.Text))
            {
                MessageBox.Show(
                    "Номер телефон должен иметь числовое значение");
            }
            else if(firstDigsTB.TextLength < 3 
                || secondDigsTB.TextLength < 2 
                || thirdDigsTB.TextLength < 2)
            {
                MessageBox.Show("Введите корректный телефон");
            }
            else if(startDTP.Value.CompareTo(finishDTP.Value) != -1)
            {
                MessageBox.Show("Магазин не может закрыться до начала работы");
            }
            else
            {
                EmpToAdd = new Emporium()
                {
                    Name = nameOfEmpTB.Text.Trim(),
                    Address = addressOfEmpTB.Text.Trim(),
                    Phone = "+38(057)-" + firstDigsTB.Text + "-" 
                        + secondDigsTB.Text + "-" 
                        + thirdDigsTB.Text,
                    Specialization = specBoxCB.Text,
                    FormOfOwn =  ownBoxCB.Text,
                    TimeOfEmpWork = new TimeOfWork(
                        startDTP.Value, finishDTP.Value),  
                };

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        

        // Проверка на то, что содержимое строки - число
        bool not_numbers(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if((int)str[i] > 57 || (int)str[i] < 48)
                {
                    return true;
                }
            }
            return false;
        }


        // Закрытие формы без последующих действий
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
