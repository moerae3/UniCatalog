using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_POO
{
    public partial class Login : Form
    {
        //MultipleActiveResultSets=true;
        public static String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Users where Username=@UserName and Password =@Password", conn);
            cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (dt.Rows.Count == 1)
            {
                this.SetDesktopLocation(1600, 700);
                string id = dt.Rows[0]["Id"].ToString();
                bool isStudent = Convert.ToBoolean(dt.Rows[0]["Student"]);
                Dashboard main = new Dashboard(id, isStudent);
                main.Show();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
        }
    }
}
