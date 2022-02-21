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
namespace demaT6DatabaseUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\xatm\Desktop\WFPC2007L\demaT6DatabaseUser\UserDB.mdf;Integrated Security=True";
        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbActive.Checked) cbActive.Text = "Active";
            else cbActive.Text = "Inactive";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            //SqlCommand sCmd = new SqlCommand("SELECT * FROM Users", sqlCon);
            SqlCommand sqlCommand = sqlCon.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM Users";
            try
            {
                sqlCon.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                List<Users> list = new List<Users>();
                while (dr.Read()) {
                    list.Add(new Users() { 
                        Username = (string)dr["Username"],
                        Password = (string)dr["Password"],
                        FullName = (string)dr["FullName"],
                        Email = (string)dr["Email"],
                        RoleId = (int)dr["RoleId"],
                        Active = (bool)dr["Active"]
                    });
                }
                dataGridView1.DataSource = list;
            }
            catch (Exception ex) { }
            finally {
                if (sqlCon.State == ConnectionState.Open)
                    try { sqlCon.Close(); } catch (Exception ex1) { MessageBox.Show("Loi khong dong duoc CSDL: " + ex1.Message); }
            }
        }
    }
}
