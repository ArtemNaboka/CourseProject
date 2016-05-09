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
using System.Xml;

namespace CourseProject
{
    public partial class MajorForm : Form
    {
        EmporiumCollection emps = new EmporiumCollection();
        public MajorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Полет нормальный");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmp f = new AddEmp();
            f.FormClosed += AddEmp_Closed;
            f.ShowDialog();
        }

        private void AddEmp_Closed(object sender, FormClosedEventArgs e)
        {
            var formAdd = (AddEmp)sender;
            
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            MainList.MeasureItem += lst_MeasureItem;
            MainList.DrawItem += lst_DrawItem;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("Information.txt", Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                string[] formatted = line.Split(new string[] {";"}, StringSplitOptions.None);
                string s = "Название : " + formatted[0] + "\n" + "Адрес : " + formatted[1] + Environment.NewLine + "Телефон : " + formatted[2] + Environment.NewLine
                    + "Специализация : " + formatted[3] + Environment.NewLine + "Форма собственности : " + formatted[4] + Environment.NewLine + "Время работы : " +
                    formatted[5] + ":" + formatted[6] + " - " + formatted[7] + ":" + formatted[8] + Environment.NewLine + " ";
                
                
                MainList.Items.Add(s);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Test_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OwnCol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(MainList.SelectedIndex != -1)
            {
                Remove.Enabled = true;
            }
        }

        private void MajorForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void MajorForm_Enter(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {
            string sample = Search.Text.Trim().ToLower();

        }

        

        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(MainList.Items[e.Index].ToString(), MainList.Font, MainList.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (MainList.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(MainList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {

        }
    }
}
