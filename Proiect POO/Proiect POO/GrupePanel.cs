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

namespace Proiect_POO
{
    public partial class GrupePanel : Form
    {
        private Dictionary<string, int> programDictionary;
        private static string connectionString = Login.ConnectionString;

        public GrupePanel()
        {
            InitializeComponent();
            programDictionary = new Dictionary<string, int>();
            PopulateProgramsComboBox();
            PopulateDegreesComboBox();
        }

        private string GenerateGroupCode(int groupIndex, string cycle, string program, string admissionYear)
        {
            string groupCode = $"4{cycle[0]}F{program}{admissionYear}{groupIndex}";

            return groupCode;
        }

        private void btnGenerateGroups_Click(object sender, EventArgs e)
        {
            //codgrupa.Text = GenerateGroupCode(txtDesiredGroupCount.Text, comboBoxDegrees.SelectedItem.ToString(), programDictionary[comboBoxPrograms.Text].ToString(), textBox3.Text);
            for (int i = 1; i <= Convert.ToInt32(txtDesiredGroupCount.Text);i++)
            {
                AddGrupeEntry(GenerateGroupCode(i, comboBoxDegrees.SelectedItem.ToString(), programDictionary[comboBoxPrograms.Text].ToString(), textBox3.Text));
            }
        }
        

        private void GrupePanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet1.Grupe' table. You can move, or remove it, as needed.
            this.grupeTableAdapter.Fill(this.projectDBDataSet1.Grupe);

            int lastDigit = DateTime.Now.Year % 10;
            textBox3.Text = lastDigit.ToString();

        }

        private void grupeStudentiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.projectDBDataSet1);
        }

        private void PopulateProgramsComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id,Nume FROM ProgrameDeStudii";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nume = reader.GetString(1);
                                comboBoxPrograms.Items.Add(nume);
                                programDictionary.Add(nume, id);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateDegreesComboBox()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Tip FROM Degrees";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tip = reader.GetString(0);
                                comboBoxDegrees.Items.Add(tip);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void AddGrupeEntry(string cod)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Grupe (Cod) VALUES (@Cod)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cod", cod);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("New entry added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add new entry.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void GroupStudents(int groupCount)
        {
            List<Student> students = GetStudentsDescendingByMedie();

            if (students.Count == 0)
            {
                Console.WriteLine("No students found in the database.");
                return;
            }

            List<string> groupCodes = GetGroupCodes(groupCount);

            if (groupCodes.Count == 0)
            {
                Console.WriteLine("No group codes found in the database.");
                return;
            }

            List<Group> groups = new List<Group>();

            for (int i = 0; i < groupCount; i++)
            {
                Group group = new Group
                {
                    CodGrupa = groupCodes[i],
                    Students = new List<Student>()
                };

                groups.Add(group);
            }

            for (int i = 0; i < students.Count; i++)
            {
                Student student = students[i];
                Group currentGroup = groups[i % groupCount];
                currentGroup.Students.Add(student);
            }

            foreach (Group group in groups)
            {
                Console.WriteLine($"Group: {group.CodGrupa}");
                foreach (Student student in group.Students)
                {
                    Console.WriteLine($"Student ID: {student.Id}, Name: {student.Nume} {student.Prenume}");
                }
                Console.WriteLine();
            }

            UpdateDatabaseWithAssignedGroups(groups);
        }

        private static List<Student> GetStudentsDescendingByMedie()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students ORDER BY MedieInscriere DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                Id = reader.GetString(0),
                                Nume = reader.GetString(1),
                                Prenume = reader.GetString(2),
                                Initiala = reader.GetString(3),
                                CNP = reader.GetString(4),
                                DataInscriere = reader.GetDateTime(5),
                                CicluInvatamant = reader.GetString(6),
                                MedieInscriere = reader.GetDecimal(7)
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }

        private static List<string> GetGroupCodes(int groupCount)
        {
            List<string> groupCodes = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP (@GroupCount) Cod FROM Grupe ORDER BY Id DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GroupCount", groupCount);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string groupCode = reader.GetString(0);
                            groupCodes.Add(groupCode);
                        }
                    }
                }
            }

            return groupCodes;
        }

        private static void UpdateDatabaseWithAssignedGroups(List<Group> groups)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (Group group in groups)
                {
                    foreach (Student student in group.Students)
                    {
                        string query = "INSERT INTO GrupeStudenti (IdStudent, CodGrupa) VALUES (@IdStudent, @CodGrupa)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdStudent", student.Id);
                            command.Parameters.AddWithValue("@CodGrupa", group.CodGrupa);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupStudents(Convert.ToInt16(txtDesiredGroupCount.Text));
        }

        private void grupeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDBDataSet1);

        }
    }
    public class Student
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Initiala { get; set; }
        public string CNP { get; set; }
        public DateTime DataInscriere { get; set; }
        public string CicluInvatamant { get; set; }
        public decimal MedieInscriere { get; set; }
    }

    public class Group
    {
        public string CodGrupa { get; set; }
        public List<Student> Students { get; set; }
    }

}
