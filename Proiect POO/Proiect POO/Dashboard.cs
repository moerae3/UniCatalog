using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_POO
{
    public partial class Dashboard : Form
    { 
        string Id;
        bool isStudent;
        string table;
        public Dashboard(string Id, bool isStudent)
        {
            InitializeComponent();
            this.Id = Id;
            this.isStudent = isStudent;

            if (isStudent)
                 this.table = "Students";
            else
            {
                this.table = "Staff";
                button1.Visible = true; 
                button2.Visible = true; 
                button3.Visible = true;
                label4.Visible = true;
            }
      
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Login.ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from "+this.table+" where Id=@Id", conn);

            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Table",table) ;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            sda.Fill(dt);

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if(dt.Rows.Count > 0)
            {
                label1.Text = dt.Rows[0]["Nume"].ToString();
                label2.Text = dt.Rows[0]["Prenume"].ToString();
                label3.Text = isStudent ? "Student" : "";

                dataGridView1.DataSource = dt;

                if(!isStudent)
                {
                    label4.Text = dt.Rows[0]["Titlu"].ToString(); 
                    flowLayoutPanel1.Visible = true;
                   
                    if((bool)dt.Rows[0]["Admin"])
                    {
                        button4.Visible = true;
                        button5.Visible = true;
                        button6.Visible = true;
                    }
                    else if((bool)dt.Rows[0]["Secretar"])
                    {
                        button4.Visible = true;
                    }

                }
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Degrees newForm = new Degrees();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisciplinePanel newForm = new DisciplinePanel();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GrupePanel newForm = new GrupePanel();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsersPanel newForm = new UsersPanel();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentsPanel newForm = new StudentsPanel();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StaffPanel newForm = new StaffPanel();
            newForm.Show();
        }
    }
}
