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

namespace CourseProject.View
{
    public partial class fullInfo : Form
    {
        /// <summary>
        /// Форма предназначена для отображения на ней
        /// полной информации о торговой точке.
        /// </summary>
        public fullInfo()
        {
            InitializeComponent();
        }


        // При нажатии на кнопку OK форма закрывается.
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        // При загрузке формы в коллекции находится по ID выбранный 
        // в таблице элемент и будут показанны все его данные.
        private void FullInfo_Load(object sender, EventArgs e)
        {
            MainForm main_form = Owner as MainForm;
            Emporium emporium = main_form.Emps.GetEmpById(Convert.ToInt32(
                main_form.dataGV
                [0, main_form.dataGV.SelectedRows[0].Index].Value));

            NameLabel.Text = emporium.Name;
            AddressLabel.Text = emporium.Address;
            PhoneLabel.Text = emporium.Phone;
            OwnLabel.Text = emporium.FormOfOwn;
            SpecialLabel.Text = emporium.Specialization;
            TimeOfWorkLabel.Text = emporium.TimeOfEmpWork.FullInfo;
        }

    }
}
