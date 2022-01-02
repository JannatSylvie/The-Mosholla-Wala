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
	public partial class ViewProfile : Form
	{
		public ViewProfile()
		{
			InitializeComponent();
		}

		private void labelSignOut_Click(object sender, EventArgs e)
		{
			SignIn si = new SignIn();
			si.Show();
			this.Hide();
		}

		private void ViewProfile_Load(object sender, EventArgs e)
		{
			labelUserName.Text = SignIn.PassingText;


			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");

			try
			{
				if (con.State != ConnectionState.Open)
				{
					con.Open();

					string query = "select * from SignUpTable where UserName='" + labelUserName.Text + "'";


					SqlCommand cmd = new SqlCommand(query, con);
					SqlDataReader reader = cmd.ExecuteReader();
					reader.Read();
					if (reader.HasRows)
					{
						labelShowFirstName.Text = reader[0].ToString();
						labelShowLastName.Text = reader[1].ToString();
						labelShowUserName.Text = reader[2].ToString();
						labellabelShowPassword.Text = reader[3].ToString();
						labelShowPhone.Text = reader[4].ToString();
						labelShowAddress.Text = reader[5].ToString();

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				//clear();
			}


		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			EditUserProfile eup = new EditUserProfile();
			eup.Show();
			this.Hide();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			SpiceInfo si = new SpiceInfo();
			si.Show();
			this.Hide();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
