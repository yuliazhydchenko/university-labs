using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Laboratorna1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.venues' table. You can move, or remove it, as needed.
           this.venuesTableAdapter.Fill(this.mydbDataSet.venues);
            // TODO: This line of code loads data into the 'mydbDataSet.country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.mydbDataSet.country);

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void сооружениеСобытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Venues_events().Show();
        }

        private void событиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new events().Show();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this,helpProvider1.HelpNamespace, HelpNavigator.TopicId, "11");
        }

        private void помощьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("D:/projectsharp/Laboratorna1/Laboratorna1/My.chm");
        }

        private void countryDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, "D:/projectsharp/Laboratorna1/Laboratorna1/My.chm", HelpNavigator.TopicId, "14");
        }

        private void venuesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, "D:/projectsharp/Laboratorna1/Laboratorna1/My.chm", HelpNavigator.TopicId, "15");
        }

        private void menuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, "D:/projectsharp/Laboratorna1/Laboratorna1/My.chm", HelpNavigator.TopicId, "11");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Process.Start("D:/projectsharp/Laboratorna1/Laboratorna1/My.chm");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void countryBindingNavigator_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(countryBindingNavigator,"Навигатор!");
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(menuStrip1, "F1 для подсказки");
        }

        private void countryDataGridView_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(countryDataGridView, "F1 для подсказки");
        }

        private void venuesDataGridView_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(venuesDataGridView, "Таблица сооружений");
        }

        private void countryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           
        }
        
        
    }
}
