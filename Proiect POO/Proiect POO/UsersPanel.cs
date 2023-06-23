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
    public partial class UsersPanel : Form
    {
        public UsersPanel()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDBDataSet);

        }

        private void UsersPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.projectDBDataSet.Users);

        }
    }
}
