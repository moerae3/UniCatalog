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
    public partial class DisciplinePanel : Form
    {
        public DisciplinePanel()
        {
            InitializeComponent();
        }

        private void disciplineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplineBindingSource.EndEdit();


        }

        private void DisciplinePanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet1.Discipline' table. You can move, or remove it, as needed.
            this.disciplineTableAdapter.Fill(this.projectDBDataSet1.Discipline);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanInvatamant newForm = new PlanInvatamant();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProgrameDeStudii newForm = new ProgrameDeStudii();
            newForm.Show();
        }

        private void disciplineBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDBDataSet1);

        }
    }
}
