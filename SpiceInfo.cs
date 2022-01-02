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
	public partial class SpiceInfo : Form
	{
		public SpiceInfo()
		{
			InitializeComponent();
		}

		private void SpiceInfo_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'theMoshollaWalaDataSet8.SpiceInfoTable_User' table. You can move, or remove it, as needed.
			this.spiceInfoTable_UserTableAdapter1.Fill(this.theMoshollaWalaDataSet8.SpiceInfoTable_User);
			labelUserName.Text = SignIn.PassingText;
			// TODO: This line of code loads data into the 'theMoshollaWalaDataSet5.SpiceInfoTable_User' table. You can move, or remove it, as needed.
			this.spiceInfoTable_UserTableAdapter.Fill(this.theMoshollaWalaDataSet5.SpiceInfoTable_User);


		}

		private void pictureBoxSearch_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");
			
			try
			{

				DataTable dts = new DataTable();
				con.Open();

				if (con.State == ConnectionState.Open)
				{

					string query = "select * from SpiceInfoTable_User where SpiceId like '%" + textBoxSearch.Text + "%' or SpiceName like '%" + textBoxSearch.Text + "%' or Brand like '%" + textBoxSearch.Text + "%' or Price like '%" + textBoxSearch.Text + "%'";
					SqlDataAdapter sd = new SqlDataAdapter(query, con);
					sd.Fill(dts);
					dataGridViewSpiceInfo.DataSource = dts;
					dataGridViewSpiceInfo.Refresh();
				}
				else
				{
					MessageBox.Show("can not search");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			SignIn si = new SignIn();
			si.Show();
			this.Hide();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void labelSignOut_Click(object sender, EventArgs e)
		{
			SignIn si = new SignIn();
			si.Show();
			this.Hide();
		}

		private void pictureBoxProfile_Click(object sender, EventArgs e)
		{
			ViewProfile vp = new ViewProfile();
			vp.Show();
			this.Hide();
		}

		private void dataGridViewSpiceInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");

			try
			{

				DataTable dts = new DataTable();
				con.Open();
				if (con.State == ConnectionState.Open)
				{

					foreach (DataGridViewRow row in dataGridViewSpiceInfo.Rows)
					{
						DataGridViewCheckBoxCell chk0 = (DataGridViewCheckBoxCell)row.Cells[0];
						if (Convert.ToInt32(chk0.EditedFormattedValue) == 1)
						{

							string query = "insert into OrderedSpices(SpiceId,SpiceName,Brand,Price,Customer_UserName)values('" + row.Cells[1].Value + "','" + row.Cells[2].Value + "','" + row.Cells[3].Value + "','" + row.Cells[4].Value + "','" + labelUserName.Text + "')";
							SqlCommand sqcom = new SqlCommand(query, con);
							int value = sqcom.ExecuteNonQuery();

							dataGridViewSpiceInfo.Refresh();
						}

					}

					MessageBox.Show("Order placed.");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//MessageBox.Show("database connection error");

			}
		}
	}
}
