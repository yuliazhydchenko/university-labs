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
    public partial class events : Form
    {
        public events()
        {
            InitializeComponent();
        }

        private void eventsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void events_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.mydbDataSet.events);

        }
    }
}
