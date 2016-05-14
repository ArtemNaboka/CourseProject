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
    public partial class Edit : Form
    {

        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            MajorForm major_form = Owner as MajorForm;
            int index = major_form.MainList.SelectedIndex;
            NameOfEmp.Text = major_form.emps[index].name;
            AddressOfEmp.Text = major_form.emps[index].address;
            FormOfOwn.Text = major_form.emps[index].FormOfOwn;
            special.Text = major_form.emps[index].specialization;
            FirstDigs.Text = major_form.emps[index].phone.Substring(9,3);
            SecondDigs.Text = major_form.emps[index].phone.Substring(13, 2);
            ThirdDigs.Text = major_form.emps[index].phone.Substring(16, 2);
            HoursOfStart.Text = major_form.emps[index].timeOfStart.hours.ToString();
            MinutesOfStart.Text = major_form.emps[index].timeOfStart.minutes.ToString();
            HoursOfFinish.Text = major_form.emps[index].timeOfFinish.hours.ToString();
            MinutesOfFinish.Text = major_form.emps[index].timeOfFinish.minutes.ToString();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            MajorForm major_form = Owner as MajorForm;
            int index = major_form.MainList.SelectedIndex;
            if (NameOfEmp.TextLength == 0 || AddressOfEmp.TextLength == 0 || FirstDigs.TextLength == 0
                || SecondDigs.TextLength == 0 || ThirdDigs.TextLength == 0 || HoursOfStart.TextLength == 0
                || HoursOfFinish.TextLength == 0 || MinutesOfStart.TextLength == 0 || MinutesOfFinish.TextLength == 0
                || (OtherFormBox.Visible == true && OtherFormBox.TextLength == 0) || (OtherSpec.Visible == true && OtherSpec.TextLength == 0))
            {
                MessageBox.Show("Заполните все поля");
            }
            else if (FormOfOwn.Text == "Выберите форму собственности")
            {
                MessageBox.Show("Выберите форму собственности");
            }
            else if (special.Text == "Выберите специализацию")
            {
                MessageBox.Show("Выберите специализацию");
            }
            else if (NotNumbers(FirstDigs.Text) || NotNumbers(SecondDigs.Text) || NotNumbers(ThirdDigs.Text) || NotNumbers(HoursOfStart.Text)
                || NotNumbers(HoursOfFinish.Text) || NotNumbers(MinutesOfStart.Text) || NotNumbers(MinutesOfFinish.Text))
            {
                MessageBox.Show("Номер телефона и время работы должны иметь числовые значения");
            }
            else
            {
                major_form.emps[index].name = NameOfEmp.Text.Trim();
                major_form.emps[index].address = AddressOfEmp.Text.Trim();
                major_form.emps[index].phone = "+38(057)-" + FirstDigs.Text + "-" + SecondDigs.Text + "-" + ThirdDigs.Text;
                major_form.emps[index].specialization = (OtherSpec.Visible == true) ? OtherSpec.Text.Trim() : special.Text;
                major_form.emps[index].FormOfOwn = OtherFormOfOwn.Visible == true ? OtherFormOfOwn.Text.Trim() : FormOfOwn.Text;
                    major_form.emps[index].timeOfStart = new Emporium.TimeOfStart()
                    {
                        hours = Convert.ToInt32(HoursOfStart.Text),
                        minutes = Convert.ToInt32(MinutesOfStart.Text)
                    };
                major_form.emps[index].timeOfFinish = new Emporium.TimeOfFinish()
                {
                    hours = Convert.ToInt32(HoursOfFinish.Text),
                    minutes = Convert.ToInt32(MinutesOfFinish.Text)
                };


                string[] readText = System.IO.File.ReadAllLines("Information.txt");
                using (System.IO.StreamWriter stream = new System.IO.StreamWriter("Information.txt", false, Encoding.UTF8))
                {
                    for (int i = 0; i < readText.Length; i++)
                    {
                        if (i != index)
                        {
                            stream.WriteLine(readText[i]);

                        }
                        else
                        {
                            stream.WriteLine(major_form.emps[index].name + ";" + major_form.emps[index].address + ";" + major_form.emps[index].phone + ";" + major_form.emps[index].specialization + ";"
                                + major_form.emps[index].FormOfOwn + ";" +
                    major_form.emps[index].timeOfStart.hours + ";" + TrueOutput(major_form.emps[index].timeOfStart.minutes) + ";" + major_form.emps[index].timeOfFinish.hours + ";"
                    + TrueOutput(major_form.emps[index].timeOfFinish.minutes));
                        }
                    }
                    stream.Close();
                }
                this.Close();
                major_form.MainList.Items.RemoveAt(index);
                major_form.MainList.Items.Insert(index, major_form.emps[index]);
                
                

            }
        }

        string TrueOutput(int n)
        {
            return (n < 10 ? "0" : "") + n;
        }
        bool NotNumbers(string str)
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
    }
}
