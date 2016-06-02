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
using System.Xml;

namespace CourseProject
{
    /// <summary>
    /// Главная форма предназначена для поиска торговых точек
    /// и для управления ими.
    /// </summary>
    public partial class MainForm : Form
    {
        // Коллекция, в которой храняться все торговые точки.
        public EmporiumCollection Emps =
            new EmporiumCollection("Information.txt");
        
        public MainForm()
        {
            InitializeComponent();
        }


        //Метод для формирования объекта на основе данных, введенных/выбранных
        //в текстовых полях/выпадающих_списках, созданных для поиска.
        ////////////////////////////////////////////////////////////////////
        //В дальнейшем мы будем использовать этот объект, 
        //чтобы выбрать из общего списка объектов те, чьи свойства
        //будут содержать в себе свойства данного объекта(Contains()),
        // то есть будем выбирать объекты из общего списка, 
        //которые удовлетворяют критериям поиска.        
        private Emporium getEmporiumForSearchFromForm()
        {
            Emporium emp = new Emporium()
            {
                Name = nameTB.Text,
                Address = addressTB.Text,
                Phone = phoneTB.Text,
                Specialization = specCB.SelectedIndex == 0 || 
                    specCB.SelectedIndex == -1 ? "" : specCB.Text,
                FormOfOwn = ownCB.SelectedIndex == 0 || 
                    ownCB.SelectedIndex == -1 ? "" : ownCB.Text,
                TimeOfEmpWork = timePanel.Enabled == true ?                    
                    new TimeOfWork(startDTP.Value, finishDTP.Value) :
                    new TimeOfWork(new DateTime(), new DateTime())
            };
            return emp;
        }



        // Событие на элементе меню(menuStrip), 
        //при вызове которого осуществляется выход из приложения.
        private void exitTMS_Click(object sender, EventArgs e)
        {            
            DialogResult dialogResult = MessageBox.Show(
                "Вы уверены, что хотите выйти?", "Выход",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }


        // Подключаем источник данных при загрузке формы.
        private void Form1_Load(object sender, EventArgs e)
        {
            
            BindSource.DataSource = new BindingSource(Emps, null);    
            foreach (Control c in Controls)
                if(c is ComboBox)
                {
                    ComboBox com = (ComboBox)c;
                    com.SelectedIndex = 0;
                }        
        }


        // Событие главной формы, при котором выполняется 
        //перезапись всех элементов коллекции в текстовый файл,
        // если эта форма закрывается.
        private void MainForm_FormClosing(object sender,
            FormClosingEventArgs e)
        {
            DataBase.SaveDB(Emps, "Information.txt");
        }


        // Метод для привязки/перепривязки данных.
        public void Binding(EmporiumCollection emporiums)
        {
            BindSource.DataSource = new BindingSource(emporiums, null);
        }


        // Событие на элементе меню(menuStrip), 
        //которое выводит справку о программе.
        private void informationTMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Курсовая работа\nПрограмма \"Справочник покупателя\"" +
                " содержит базу данных торговых точек города. Возможен" +
                " поиск предприятий по произвольному шаблону. \nВыполнил:" +
                " Набока А.А.\nст.гр ПИ-15-1\n2016", "О программе");
        }


        // Элемент меню, при нажатии на который создается
        // и открывается форма добавления.
        private void AddEmporiumCMS_Click(object sender, EventArgs e)
        {
            AddEmp f = new AddEmp();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                Emps.Add(f.EmpToAdd);
                Binding(Emps);
            }
        }


        // Элемент меню, при нажатии на который фокусируется первое поле
        // для заполнения для поиска.
        private void findEmporiumCMS_Click(object sender, EventArgs e)
        {
            nameTB.Focus();
        }

        // Событие на элементе меню Удалить из меню
        //для удаления элемента из коллекции
        // При выделении определенного элемента таблицы, 
        // мы получаем его уникальный индекс(столбец индексов скрыт).
        // После этого мы ищем элемент с данным индексом в коллекции Emps
        //и при нахождении удаляем его.
        // В конце мы перепривязываем коллекцию к источнику данных .
        private void deleteEmporiumCMS_Click(object sender, EventArgs e)
        {                   
            int idOfSelectedEmp = Convert.ToInt32(dataGV[0,
            dataGV.SelectedRows[0].Index].Value);
            DialogResult dialogResult = MessageBox.Show("Вы уверены, " +
            "что хотите удалить " + dataGV[1,
            dataGV.SelectedRows[0].Index].Value +
            " из базы данных? ",
            "Удаление торговой точки", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Emps.RemoveById(idOfSelectedEmp);
                Binding(Emps);
            }
        }


        // Событие на элементе меню Редактировать,
        //которое вызывает форму для редактирования объекта.
        private void editEmporiumCMS_Click(object sender, EventArgs e)
        {
            Edit f = new Edit();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                for (int i = 0; i < Emps.length(); i++)
                {
                    if (Emps[i].Id.ToString() == dataGV
                        [0, dataGV.SelectedRows[0].Index].Value.ToString())
                    {
                        Emps.UpdateEmporium(Emps[i], f.EmpToEdit);
                    }
                }
                Binding(Emps);
            }
        }

        // Событие на кнопке формы Найти, 
        //которое вызывает метод для формирования объекта
        // с помощью метода getEmporiumForSearchFromForm()
        // Далее привязывает элемент BindingSource к новому источнику,
        // данных - коллекцие, в которой объекты удовлетворяют критерии поиска.
        private void findBtn_Click(object sender, EventArgs e)
        {
            if (Emps.Search(getEmporiumForSearchFromForm()).Count != 0)
                BindSource.DataSource = Emps.Search(
                    getEmporiumForSearchFromForm());
            else
            {
                DialogResult dialogRes =
               MessageBox.Show(
                   "Не одна из торговых точек не отвечает критериям поиска.",
                    "Поиск торговой точки", MessageBoxButtons.OK);
            }
        }


        // Cобытие на кнопке формы Показать_все, 
        //которое выводит в таблицу все элементы коллекции
        //Сбрасывает все критерии поиска.
        private void showAllBtn_Click_2(object sender, EventArgs e)
        {
            BindSource.DataSource = new BindingSource(Emps, null);
            foreach (Control control in Controls)
                if (control is TextBox)
                    ((TextBox)control).Text = "";
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = 0;
                else if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    if (dateTimePicker.Name == "startDTPicker")
                        dateTimePicker.Value =
                            Convert.ToDateTime("01/01/1800 " + "00:00" 
                            + ":00.00");
                    else if (dateTimePicker.Name == "endDTPicker")
                        dateTimePicker.Value =
                            Convert.ToDateTime("01/01/1800 " + "23:59"
                            + ":00.00");

                }
                else if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
        }

        // При нажатии открывается форма, 
        //в которой полностью показаны данные об объекте.
        private void infoOfEmp_Click(object sender, EventArgs e)
        {
            fullInfo form = new fullInfo();
            form.ShowDialog(this);
        }


        // Сохраняет все данные из коллекции, записывая их в текстовый файл.
        private void saveTStrM_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.SaveDB(Emps, "Information.txt");
            }
            catch(TypeInitializationException)
            {
                MessageBox.Show("Данный файл не существует");
            }
        }

        // Если чекбокс отмечен, то учитываем время при поиске.
        private void useTimeChB_CheckedChanged(object sender, EventArgs e)
        {
            timePanel.Enabled = useTimeChB.Checked ? true : false;
        }


        // При нажатии на элемент таблицы правой кнопкой мыши,
        // появляется меню Правки.
        private void dataGV_CellContextMenuStripNeeded(object sender,
            DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            dataGV[e.ColumnIndex, e.RowIndex].Selected = true;
            contextMenu.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
        }


        // Нажатие на Просмотреть в контекстном меню
        // после нажатия правой кнопки мыши.
        private void fullInfoCMS_Click(object sender, EventArgs e)
        {
            fullInfo form = new fullInfo();
            form.ShowDialog(this);
        }

        // Нажатие на Редактировать в контекстном меню
        // после нажатия правой кнопки мыши.
        private void editCMS_Click(object sender, EventArgs e)
        {
            Edit f = new Edit();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                for (int i = 0; i < Emps.length(); i++)
                {
                    if (Emps[i].Id.ToString() == dataGV[0, dataGV.
                        SelectedRows[0].Index].Value.ToString())
                    {
                        Emps.UpdateEmporium(Emps[i], f.EmpToEdit);
                    }
                }
                Binding(Emps);
            }
        }


        // Нажатие на Удалить в контекстном меню
        // после нажатия правой кнопки мыши.
        private void removeCMS_Click(object sender, EventArgs e)
        {
            int idOfSelectedEmp = Convert.ToInt32(dataGV[0,
            dataGV.SelectedRows[0].Index].Value);
            DialogResult dialogResult = MessageBox.Show("Вы уверены, " +
            "что хотите удалить " + dataGV[1,
            dataGV.SelectedRows[0].Index].Value + 
            " из базы данных? ",
            "Удаление торговой точки", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Emps.RemoveById(idOfSelectedEmp);
                Binding(Emps);
            }
        }
    }
}
