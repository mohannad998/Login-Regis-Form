using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LoginAndRegistrationForm
{
    public partial class Signup : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mohannad\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30");
        public Signup()
        {
            InitializeComponent();
        }

        private void signup_Login_Click(object sender, EventArgs e)
        {
            Form1 lForm = new Form1();
            lForm.Show();
            this.Hide();
        }

        private void signup_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_Button_Click(object sender, EventArgs e)
        {
            if (signup_Email.Text == "" || signup_Username.Text == "" || signup_Password.Text == "")
            {
                MessageBox.Show("Please Fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '"
                            + signup_Username.Text.Trim() + "'";
                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adpater = new SqlDataAdapter(checkUser);
                            DataTable dataTable = new DataTable();

                            adpater.Fill(dataTable);
                            if (dataTable.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_Username.Text + "is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insetData = "INSERT INTO admin(email , username , passowrd , date_created)" +
                                    "VALUES(@email,@username,@pass,@date)";
                                DateTime date = DateTime.Today;
                                using (SqlCommand cmd = new SqlCommand(insetData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_Email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_Username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_Password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);


                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully", "Infromation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    Form1 lForm = new Form1();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            
        }

        private void signup_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_ShowPassword.Checked)
            {
                signup_Password.PasswordChar = '\0';
            }
            else
            {
                signup_Password.PasswordChar = '*';
            }
        }
    }
}
