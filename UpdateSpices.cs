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
	public partial class UpdateSpice : Form
	{
		public UpdateSpice()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");
			if (textBoxSpiceId1.Text != "" && textBoxSpiceId2.Text != "" && textBoxSpiceName2.Text != "" && textBoxBrand2.Text != "" && textBoxPrice2.Text != "")
			{

				try
				{

					DataTable dts = new DataTable();
					con.Open();
					if (con.State == ConnectionState.Open)
					{
						if (MessageBox.Show("Are you sure to update data?", "update", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							string query = "update SpiceInfoTable_User SET SpiceId = '" + textBoxSpiceId2.Text + "' , SpiceName = '" + textBoxSpiceName2.Text + "' , Brand = '" + textBoxBrand2.Text + "' , Price = '" + textBoxPrice2.Text + "' where SpiceId = '" + textBoxSpiceId1.Text + "'"; SqlCommand sqcom = new SqlCommand(query, con);
							int value = sqcom.ExecuteNonQuery();
							MessageBox.Show("Spice updated");
							//clear();
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

		private void labelThemoshollawal_Click(object sender, EventArgs e)
		{
			AdminHome ah = new AdminHome();
			ah.Show();
			this.Hide();
		}

		private void labelSignOut_Click(object sender, EventArgs e)
		{

			SignIn si = new SignIn();
			si.Show();
			this.Hide();
		}
		private void UpdateSpice_Load(object sender, EventArgs e)
		{
			labelUserName.Text = SignIn.PassingText;
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
			buttonDeleteSpice.BackColor = Color.BurlyWood;
			buttonDeleteSpice.ForeColor = Color.SaddleBrown;
		}

		private void buttonDeleteSpice_MouseLeave(object sender, EventArgs e)
		{
			buttonDeleteSpice.BackColor = Color.Wheat;
			buttonDeleteSpice.ForeColor = Color.Peru;

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

	}
}
