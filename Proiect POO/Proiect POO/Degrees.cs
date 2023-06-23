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
    public partial class Degrees : Form
    {
        public Degrees()
        {
            InitializeComponent();
        }

        private void Degrees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet.Degrees' table. You can move, or remove it, as needed.
            this.degreesTableAdapter.Fill(this.projectDBDataSet.Degrees);

        }

        private void degreesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.degreesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDBDataSet);

        }
    }
}
