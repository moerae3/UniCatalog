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
    public partial class PlanInvatamant : Form
    {
        public PlanInvatamant()
        {
            InitializeComponent();
        }

        private void planInvatamantBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planInvatamantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDBDataSet);

        }

        private void PlanInvatamant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet.PlanInvatamant' table. You can move, or remove it, as needed.
            this.planInvatamantTableAdapter.Fill(this.projectDBDataSet.PlanInvatamant);

        }
    }
}
