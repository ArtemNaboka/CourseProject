using CourseProject.Model;
using CourseProject.View;
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
    /// Форма предназначена для редактирования уже существующей
    /// торговой точки.
    /// </summary>
    public partial class Edit : Form
    {
        // Торговая точка, которая будет редактироваться
        public Emporium EmpToEdit;


        public Edit()
        {
            InitializeComponent();
            EmpToEdit = null;
        }


        // При загрузке формы заполняем все контроллеры значениями
        //свойств объекта, который редактируется.
        private void Edit_Load(object sender, EventArgs e)
        {
            MainForm main_form = Owner as MainForm;
            int key = Convert.ToInt32(main_form.dataGV
                [0, main_form.dataGV.SelectedRows[0].Index].Value);            
            foreach(Emporium emp in main_form.Emps)
            {
                if(emp.Id == key)
                {
                    EmpToEdit = emp;
                }
            }
            nameOfEmpTB.Text = EmpToEdit.Name;
            addressOfEmpTB.Text = EmpToEdit.Address;  
            ownBoxCB.Text = EmpToEdit.FormOfOwn;          
            specBoxCB.Text = EmpToEdit.Specialization;            
            firstDigsTB.Text = EmpToEdit.Phone.Substring(9, 3);
            secondDigsTB.Text = EmpToEdit.Phone.Substring(13, 2);
            thirdDigsTB.Text = EmpToEdit.Phone.Substring(16, 2);
            startDTP.Value = EmpToEdit.TimeOfEmpWork.StartTime;
            finishDTP.Value = EmpToEdit.TimeOfEmpWork.FinishTime;
        }


        // При нажатии на кнопку Сохранить будет проиcходить
        // проверка заполненности всех полей
        // и при положительном результате 
        // будет редактироваться существующий в коллекции объект.
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameOfEmpTB.TextLength == 0 || addressOfEmpTB.TextLength == 0 
                || firstDigsTB.TextLength == 0
                || secondDigsTB.TextLength == 0 
                || thirdDigsTB.TextLength == 0)
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
            else if (not_numbers(firstDigsTB.Text) 
                || not_numbers(secondDigsTB.Text) 
                || not_numbers(thirdDigsTB.Text))
            {
                MessageBox.Show("Номер телефона и время работы должны иметь числовые значения");
            }
            else if (firstDigsTB.TextLength < 3 
                || secondDigsTB.TextLength < 2 
                || thirdDigsTB.TextLength < 2)
            {
                MessageBox.Show("Введите корректный телефон");
            }
            else if (startDTP.Value.CompareTo(finishDTP.Value) != -1)
            {
                MessageBox.Show("Магазин не может закрыться до начала работы");
            }
            else
            {
                EmpToEdit.Name = nameOfEmpTB.Text.Trim();
                EmpToEdit.Address = addressOfEmpTB.Text.Trim();
                EmpToEdit.Phone = "+38(057)-" + firstDigsTB.Text + "-"
                    + secondDigsTB.Text + "-" + thirdDigsTB.Text;
                EmpToEdit.Specialization = specBoxCB.Text;
                EmpToEdit.FormOfOwn = ownBoxCB.Text;
                EmpToEdit.TimeOfEmpWork = new TimeOfWork(
                    startDTP.Value, finishDTP.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        // Проверка, является ли содерижимое строки числом.
        bool not_numbers(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if ((int)str[i] > 57 || (int)str[i] < 48)
                {
                    return true;
                }
            }
            return false;
        }


        // Закрытие формы.
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
