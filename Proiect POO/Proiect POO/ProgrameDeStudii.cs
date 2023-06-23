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
    public partial class ProgrameDeStudii : Form
    {
        public ProgrameDeStudii()
        {
            InitializeComponent();
        }

        private void programeDeStudiiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.programeDeStudiiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDBDataSet);

        }

        private void ProgrameDeStudii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet.ProgrameDeStudii' table. You can move, or remove it, as needed.
            this.programeDeStudiiTableAdapter.Fill(this.projectDBDataSet.ProgrameDeStudii);

        }
    }
}
