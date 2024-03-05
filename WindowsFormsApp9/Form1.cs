using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arsalan Aslam\source\repos\WindowsFormsApp9\Database1.mdf;Integrated Security=True");
            try
            {
                connection.Open();
                string Query = "INSERT INTO [TABLE] VALUES(@id, @name, @email)";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@id", textBox1.Text);
                command.Parameters.AddWithValue("@name", textBox2.Text);
                command.Parameters.AddWithValue("@email", textBox3.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Data entered successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
