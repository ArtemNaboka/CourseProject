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
    public partial class AddEmp : Form
    {
        
        public AddEmp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MajorForm major_form = Owner as MajorForm;
            
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
            else if(NotNumbers(FirstDigs.Text) || NotNumbers(SecondDigs.Text) || NotNumbers(ThirdDigs.Text) || NotNumbers(HoursOfStart.Text) 
                || NotNumbers(HoursOfFinish.Text) || NotNumbers(MinutesOfStart.Text) || NotNumbers(MinutesOfFinish.Text))
            {
                MessageBox.Show("Номер телефона и время работы должны иметь числовые значения");
            }
            else
            {
                Emporium emporium = new Emporium()
                {
                    name = NameOfEmp.Text.Trim(),
                    address = AddressOfEmp.Text.Trim(),
                    phone = "+38(057)-" + FirstDigs.Text + "-" + SecondDigs.Text + "-" + ThirdDigs.Text,
                    specialization = (OtherSpec.Visible == true) ? OtherSpec.Text.Trim() : special.Text,
                    FormOfOwn = OtherFormOfOwn.Visible == true ? OtherFormOfOwn.Text.Trim() : FormOfOwn.Text,  
                    timeOfStart = new Emporium.TimeOfStart()
                    {
                        hours = Convert.ToInt32(HoursOfStart.Text),
                        minutes = Convert.ToInt32(MinutesOfStart.Text)
                    },
                    timeOfFinish = new Emporium.TimeOfFinish()
                    {
                        hours = Convert.ToInt32(HoursOfFinish.Text),
                        minutes = Convert.ToInt32(MinutesOfFinish.Text)
                    }
                };
                
                System.IO.StreamWriter sw = new System.IO.StreamWriter("Information.txt", true, Encoding.UTF8);
                sw.WriteLine(emporium.name + ";" + emporium.address + ";" + emporium.phone + ";" + emporium.specialization + ";" + emporium.FormOfOwn + ";" + 
                    emporium.timeOfStart.hours + ";" + TrueOutput(emporium.timeOfStart.minutes) + ";" + emporium.timeOfFinish.hours + ";"
                    + TrueOutput(emporium.timeOfFinish.minutes));
                sw.Close();
                this.Close();
                major_form.MainList.Items.Add(emporium);
                major_form.emps.Add(emporium);
                //Application.Restart();
                
            }
        }
        
        string TrueOutput(int n)
        {
            return (n < 10 ? "0" : "") + n;
        }
        bool NotNumbers(string str)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void special_Click(object sender, EventArgs e)
        {

        }

        private void электроникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            special.Text = elctronics.Text;
            OtherSpec.Visible = false;
        }

        private void SelHoz_Click(object sender, EventArgs e)
        {
            special.Text = SelHoz.Text;
            OtherSpec.Visible = false;
        }

        private void другоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            special.Text = other.Text;
            OtherSpec.Visible = true;
            OtherSpec.Focus();
        }

        private void Nation_Click(object sender, EventArgs e)
        {
            FormOfOwn.Text = Nation.Text;
        }

        private void Municipal_Click(object sender, EventArgs e)
        {
            FormOfOwn.Text = Municipal.Text;
        }

        private void Partial_Click(object sender, EventArgs e)
        {
            FormOfOwn.Text = Partial.Text;
        }

        private void OtherFormOfOwn_Click(object sender, EventArgs e)
        {
            FormOfOwn.Text = OtherFormOfOwn.Text;
            OtherFormBox.Visible = true;
            OtherFormBox.Focus();
        }

        private void AddEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
