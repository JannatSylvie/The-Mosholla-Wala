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


namespace The_Mosholla_Wala__Version_3_
{
    public partial class SignIn : Form
    {
		public static string PassingText;
		public SignIn()
        {
            InitializeComponent();
        }

		//public object DataGridView1 { get; private set; }

		private void SignIn_Load(object sender, EventArgs e)
        {
		
		}
		private void clear()
		{
			textBoxUsername.Text = "";
			textBoxPassword.Text = "";
		}

		private void labelSignin_Click(object sender, EventArgs e)
        {
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");
			try
			{
				DataTable dts = new DataTable();
				if (radioButtonAdmin.Checked)
				{
					string query1 = "select * from AdminInfo where UserName ='" + textBoxUsername.Text + "' and Password = '" + textBoxPassword.Text + "'";
					SqlDataAdapter sd = new SqlDataAdapter(query1, con);
					sd.Fill(dts);

				}
				else if (radioButtonCustomer.Checked)
				{
					string query2 = "select * from SignUpTable where UserName ='" + textBoxUsername.Text + "' and Password = '" + textBoxPassword.Text + "'";
					SqlDataAdapter sd = new SqlDataAdapter(query2, con);
					sd.Fill(dts);
				}
				if (con.State != ConnectionState.Open)
				{
					con.Open();
				}
				//con.Open();

				

				con.Close();

				//if (textBoxUsername.Text == "admin" || textBoxUsername.Text == "Admin" || textBoxUsername.Text == "ADMIN")
				//{
				//	if (textBoxPassword.Text == "1234")
				//	{
				//		AdminHome ah1 = new AdminHome();
				//		ah1.Show();
				//		clear();
				//		this.Visible = false;
				//	}
				//	else
				//	{
				//		MessageBox.Show("Invalid password for Admin Access!");
				//		clear();
				//	}
				//}
				//else 
               if (dts.Rows.Count == 1)
				{
					if (radioButtonAdmin.Checked)
					{
						PassingText = textBoxUsername.Text;
						AdminHome ah = new AdminHome();
						ah.Show();
						this.Visible = false;
					}
					else if (radioButtonCustomer.Checked)
					{
						PassingText = textBoxUsername.Text;
						SpiceInfo si1 = new SpiceInfo();
						si1.Show();
						this.Visible = false;
					}
					

				}
				else if (textBoxUsername.Text == "" && textBoxPassword.Text == "")
				{
					MessageBox.Show("Enter Username and Password.");
				}
				else if (textBoxUsername.Text == "")
				{
					MessageBox.Show("Enter Username.");
				}
				else if (textBoxPassword.Text == "")
				{
					MessageBox.Show("Enter Password.");
				}
				else
				{
					MessageBox.Show("Invalid Username or Password!");
					clear();
				}


			}
			catch (Exception ex)
			{
				MessageBox.Show("Database Connection Error +", ex.ToString());
			}


		}

		private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SignUp f1 = new SignUp();
			f1.Show();
			this.Visible = false;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void labelUsername_Click(object sender, EventArgs e)
		{

		}

		private void labelThemoshollawal_Click(object sender, EventArgs e)
		{

		}

		private void textBoxPassword_TextChanged(object sender, EventArgs e)
		{
			textBoxPassword.UseSystemPasswordChar = true;
		}

		private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxShow.Checked)
			{
				textBoxPassword.UseSystemPasswordChar = false;
			}
			else
			{
				textBoxPassword.UseSystemPasswordChar = true;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}			
	}
}
