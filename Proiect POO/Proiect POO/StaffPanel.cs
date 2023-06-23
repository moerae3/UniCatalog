using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_POO
{
    public partial class StaffPanel : Form
    {
        public StaffPanel()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDBDataSet);

        }

        private void StaffPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.projectDBDataSet.Staff);

        }
    }
}
