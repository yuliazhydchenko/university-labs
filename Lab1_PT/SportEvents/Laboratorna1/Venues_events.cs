using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorna1
{
    public partial class Venues_events : Form
    {
        public Venues_events()
        {
            InitializeComponent();
        }

        private void venuesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.venuesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void Venues_events_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.mydbDataSet.events);
            // TODO: This line of code loads data into the 'mydbDataSet.venues' table. You can move, or remove it, as needed.
            this.venuesTableAdapter.Fill(this.mydbDataSet.venues);

        }

        private void venuesBindingNavigator_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(venuesBindingNavigator,"Навигаторрррр!");
        }

        private void venuesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
