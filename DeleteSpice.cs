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
	public partial class DeleteSpice : Form
	{
		public DeleteSpice()
		{
			InitializeComponent();
		}

		private void clear()
		{
			textBoxSpiceId.Text = "";
		}

		private void buttonCustomerInfo_Click(object sender, EventArgs e)
		{
			CustomerInfo ci = new CustomerInfo();
			ci.Show();
			this.Hide();
		}

		private void buttonDeliveredSpices_Click(object sender, EventArgs e)
		{
			DeliveredSpices ds = new DeliveredSpices();
			ds.Show();
			this.Hide();
		}

		private void buttonOrderedSpices_Click(object sender, EventArgs e)
		{
			OrderedSpices os = new OrderedSpices();
			os.Show();
			this.Hide();
		}

		private void buttonDeleteSpice_Click(object sender, EventArgs e)
		{
			DeleteSpice dels = new DeleteSpice();
			dels.Show();
			this.Hide();
		}

		private void buttonAddSpice_Click(object sender, EventArgs e)
		{
			AddSpice ads = new AddSpice();
			ads.Show();
			this.Hide();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			AdminHome ah = new AdminHome();
			ah.Show();
			this.Hide();
		}

		private void labelThemoshollawal_Click(object sender, EventArgs e)
		{
			AdminHome ah = new AdminHome();
			ah.Show();
			this.Hide();
		}

		private void DeleteSpice_Load(object sender, EventArgs e)
		{
			labelUserName.Text = SignIn.PassingText;
		}

		private void buttonAddSpice_MouseHover(object sender, EventArgs e)
		{
			buttonAddSpice.BackColor = Color.BurlyWood;
			buttonAddSpice.ForeColor = Color.SaddleBrown;
		}

		private void buttonAddSpice_MouseLeave(object sender, EventArgs e)
		{
			buttonAddSpice.BackColor = Color.Wheat;
			buttonAddSpice.ForeColor = Color.Peru;

		}

		private void buttonDeleteSpice_MouseHover(object sender, EventArgs e)
		{
			//buttonDeleteSpice.BackColor = Color.BurlyWood;
			//buttonDeleteSpice.ForeColor = Color.SaddleBrown;
		}

		private void buttonDeleteSpice_MouseLeave(object sender, EventArgs e)
		{
			//buttonDeleteSpice.BackColor = Color.Wheat;
			//buttonDeleteSpice.ForeColor = Color.Peru;

		}

		private void buttonCustomerInfo_MouseHover(object sender, EventArgs e)
		{
			buttonCustomerInfo.BackColor = Color.BurlyWood;
			buttonCustomerInfo.ForeColor = Color.SaddleBrown;
		}

		private void buttonCustomerInfo_MouseLeave(object sender, EventArgs e)
		{
			buttonCustomerInfo.BackColor = Color.Wheat;
			buttonCustomerInfo.ForeColor = Color.Peru;

		}

		private void buttonOrderedSpices_MouseHover(object sender, EventArgs e)
		{
			buttonOrderedSpices.BackColor = Color.BurlyWood;
			buttonOrderedSpices.ForeColor = Color.SaddleBrown;
		}

		private void buttonOrderedSpices_MouseLeave(object sender, EventArgs e)
		{
			buttonOrderedSpices.BackColor = Color.Wheat;
			buttonOrderedSpices.ForeColor = Color.Peru;
		}

		private void buttonDeliveredSpices_MouseHover(object sender, EventArgs e)
		{
			buttonDeliveredSpices.BackColor = Color.BurlyWood;
			buttonDeliveredSpices.ForeColor = Color.SaddleBrown;
		}

		private void buttonDeliveredSpices_MouseLeave(object sender, EventArgs e)
		{
			buttonDeliveredSpices.BackColor = Color.Wheat;
			buttonDeliveredSpices.ForeColor = Color.Peru;
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");
			if (textBoxSpiceId.Text != "")
			{
				try
				{

					DataTable dts = new DataTable();
					con.Open();
					if (con.State == ConnectionState.Open)
					{
						string query = "delete from SpiceInfoTable_User WHERE SpiceId = '" + textBoxSpiceId.Text + "'";

						SqlCommand sqcom = new SqlCommand(query, con);
						int value = sqcom.ExecuteNonQuery();
						MessageBox.Show("Spice deleted");
						clear();
					}
					else
					{
						MessageBox.Show("Spice could not be deleted");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			else
			{
				MessageBox.Show("The required field is not filled up.");
			}
			}

		private void buttonUpdateSpices_Click(object sender, EventArgs e)
		{
			UpdateSpice us = new UpdateSpice();
			us.Show();
			this.Hide();
		}

		private void buttonUpdateSpices_MouseHover(object sender, EventArgs e)
		{
			buttonUpdateSpices.BackColor = Color.BurlyWood;
			buttonUpdateSpices.ForeColor = Color.SaddleBrown;
		}


		private void buttonUpdateSpices_MouseLeave(object sender, EventArgs e)
		{
			buttonUpdateSpices.BackColor = Color.Wheat;
			buttonUpdateSpices.ForeColor = Color.Peru;
		}

		private void labelSignOut_Click(object sender, EventArgs e)
		{
			SignIn si = new SignIn();
			si.Show();
			this.Hide();
		}
	}
}
