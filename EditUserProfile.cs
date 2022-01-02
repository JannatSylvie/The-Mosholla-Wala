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

namespace The_Mosholla_Wala__Version_3_
{
	public partial class EditUserProfile : Form
	{
		public EditUserProfile()
		{
			InitializeComponent();
		}

		private void labelSignOut_Click(object sender, EventArgs e)
		{
			SignIn si = new SignIn();
			si.Show();
			this.Hide();
		}

		private void labelUserName_Click(object sender, EventArgs e)
		{

		}

		private void linklabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SpiceInfo si = new SpiceInfo();
			si.Show();
			this.Hide();
		}

		private void linkLabelSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{


			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");
			if (textBoxPassword.Text != "" && textBoxPhone.Text != "" && textBoxAddress.Text != "")
			{

				try
				{

					DataTable dts = new DataTable();
					con.Open();
					if (con.State == ConnectionState.Open)
					{
						if (MessageBox.Show("Are you sure to update profle?", "update", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							string query = "update SignUpTable SET Password = '" + textBoxPassword.Text + "' , Phone = '" + textBoxPhone.Text + "' , Address = '" + textBoxAddress.Text + "' where UserName = '" + labelShowUserName.Text + "'";
							SqlCommand sqcom = new SqlCommand(query, con);
							int value = sqcom.ExecuteNonQuery();
							MessageBox.Show("Profile updated");
							ViewProfile vp = new ViewProfile();
							vp.Show();
							this.Hide();
						}
					}
					else
					{
						MessageBox.Show("Spice could not be added");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			else
			{
				MessageBox.Show("All required fields are not filled up.");
			}

		}

		private void EditUserProfile_Load(object sender, EventArgs e)
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
		

					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				//clear();
			}

		}

		private void pictureBoxProfile_Click(object sender, EventArgs e)
		{
			ViewProfile vp = new ViewProfile();
			vp.Show();
			this.Hide();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
