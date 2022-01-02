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
using System.Data.Sql;

namespace The_Mosholla_Wala__Version_3_
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

		private void SignUp_Load(object sender, EventArgs e)
		{
			labelEnterfirstname.Visible = false;
			labelEnterlastname.Visible = false;
			labelEnterusername.Visible = false;
			labelEnterpassword.Visible = false;
			labelEnterphonenumber.Visible = false;
			labelEnteryouraddress.Visible = false;



		}
		private void clear()
		{
			textBoxFirstname.Text = "";
			textBoxLastname.Text = "";
			textBoxUsername.Text = "";
			textBoxPassword.Text = "";
			textBoxPhone.Text = "";
			textBoxAddress.Text = "";
		}

		private void textBoxFirstname_TextChanged(object sender, EventArgs e)
        {
			if (String.IsNullOrEmpty(textBoxFirstname.Text))
			{
				labelEnterfirstname.Visible = true;
			}
			else
			{
				labelEnterfirstname.Visible = false;
			}
		}
		private void textBoxLastname_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBoxLastname.Text))
			{
				labelEnterlastname.Visible = true;
			}
			else
			{
				labelEnterlastname.Visible = false;
			}
		}
		private void textBoxUsername_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBoxUsername.Text))
			{
				labelEnterusername.Visible = true;
			}
			else
			{
				labelEnterusername.Visible = false;
			}
		}

		private void textBoxPassword_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBoxPassword.Text))
			{
				labelEnterpassword.Visible = true;
			}
			else
			{
				labelEnterpassword.Visible = false;
			}
		}

		private void textBoxPhone_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBoxPhone.Text))
			{
				labelEnterphonenumber.Visible = true;
			}
			else
			{
				labelEnterphonenumber.Visible = false;
			}
		}

		private void textBoxAddress_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(textBoxAddress.Text))
			{
				labelEnteryouraddress.Visible = true;
			}
			else
			{
				labelEnteryouraddress.Visible = false;
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			SignIn f1 = new SignIn();
			f1.Show();
			this.Hide();
		}

		ToolTip t1 = new ToolTip();

		private void textBoxPassword_MouseHover(object sender, EventArgs e)
		{
						
				t1.Show("Minimum 8 characters long.", textBoxPassword);

		}

		private void buttonSiginUp_MouseHover(object sender, EventArgs e)
		{
			buttonSiginUp.BackColor = Color.PaleGoldenrod;
		}

		private void buttonSiginUp_MouseLeave(object sender, EventArgs e)
		{
			buttonSiginUp.BackColor = Color.Khaki;
		}

		private void buttonSiginUp_Click(object sender, EventArgs e)
		{

			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");
			if (textBoxFirstname.Text != "" && textBoxLastname.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "" && textBoxPhone.Text != "" && textBoxFirstname.Text != "")
			{
				try
				{

					DataTable dts = new DataTable();
					con.Open();
					if (con.State == ConnectionState.Open)
					{
						string query = "insert into SignUpTable (FirstName,LastName,UserName,Password,Phone,Address)values('" + textBoxFirstname.Text + "','" + textBoxLastname.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "','" + textBoxPhone.Text + "','" + textBoxAddress.Text + "')";

						SqlCommand sqcom = new SqlCommand(query, con);
						int value = sqcom.ExecuteNonQuery();
						MessageBox.Show("account created");
						clear();
					}
					else
					{
						MessageBox.Show("account could not be created");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			else
			{
				MessageBox.Show("All the required fields are not filled up.");
			}

		}
		
	}

	
}
