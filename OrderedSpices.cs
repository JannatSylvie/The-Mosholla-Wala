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
	public partial class OrderedSpices : Form
	{
		public OrderedSpices()
		{
			InitializeComponent();
		}
		
		private void OrderedSpices_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'theMoshollaWalaDataSet10.OrderedSpices' table. You can move, or remove it, as needed.
			this.orderedSpicesTableAdapter2.Fill(this.theMoshollaWalaDataSet10.OrderedSpices);
			// TODO: This line of code loads data into the 'theMoshollaWalaDataSet9.OrderedSpices' table. You can move, or remove it, as needed.
			//this.orderedSpicesTableAdapter.Fill(this.theMoshollaWalaDataSet9.OrderedSpices);
			// TODO: This line of code loads data into the 'theMoshollaWalaDataSet7.OrderedSpices' table. You can move, or remove it, as needed.
			//this.orderedSpicesTableAdapter1.Fill(this.theMoshollaWalaDataSet7.OrderedSpices);
			labelUserName.Text = SignIn.PassingText;
			// TODO: This line of code loads data into the 'theMoshollaWalaDataSet6.OrderedSpices' table. You can move, or remove it, as needed.
			//this.orderedSpicesTableAdapter.Fill(this.theMoshollaWalaDataSet6.OrderedSpices);
			//SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");
			//string query = "select spiceid,spicename,brand,price,Customer_UserName from OrderedSpices";
			//SqlDataAdapter sda = new SqlDataAdapter(query, con);
			//DataTable dt = new DataTable();
			//sda.Fill(dt);
			//foreach (DataRow item in dt.Rows)
			//{
			//	int n = dataGridView1.Rows.Add();
			//	dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
			//	dataGridView1.Rows[n].Cells[2].Value = item[1].ToString();
			//	dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();
			//	dataGridView1.Rows[n].Cells[4].Value = item[3].ToString();
			//	dataGridView1.Rows[n].Cells[5].Value = item[4].ToString();
			//}
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
			//buttonOrderedSpices.BackColor = Color.BurlyWood;
			//buttonOrderedSpices.ForeColor = Color.SaddleBrown;
		}

		private void buttonOrderedSpices_MouseLeave(object sender, EventArgs e)
		{
			//buttonOrderedSpices.BackColor = Color.Wheat;
			//buttonOrderedSpices.ForeColor = Color.Peru;
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

		private void labelThemoshollawal_Click(object sender, EventArgs e)
		{
			AdminHome ah = new AdminHome();
			ah.Show();
			this.Hide();
		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{

			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");

			try
			{

				DataTable dts = new DataTable();
				con.Open();
				if (con.State == ConnectionState.Open)
				{

					foreach (DataGridViewRow row in dataGridViewOrderedSpices.Rows)
					{
						DataGridViewCheckBoxCell chk0 = (DataGridViewCheckBoxCell)row.Cells[0];
						if (Convert.ToInt32(chk0.EditedFormattedValue) == 1)
						{
							string query1 = "delete from OrderedSpices where SpiceId = '" + row.Cells[1].Value + "' and SpiceName = '" + row.Cells[2].Value + "' and Brand = '" + row.Cells[3].Value + "' and Price = '" + row.Cells[4].Value + "' and Customer_UserName = '" + row.Cells[5].Value + "'";
							string query2 = "insert into DeliveredSpices(SpiceId,SpiceName,Brand,Price,Customer_UserName)values('" + row.Cells[1].Value + "','" + row.Cells[2].Value + "','" + row.Cells[3].Value + "','" + row.Cells[4].Value + "','" + row.Cells[5].Value + "')";
							SqlCommand sqcom1 = new SqlCommand(query1, con);
							SqlCommand sqcom2 = new SqlCommand(query2, con);
							int value1 = sqcom1.ExecuteNonQuery();
							int value2 = sqcom2.ExecuteNonQuery();
							dataGridViewOrderedSpices.Refresh();
						}

					}

					MessageBox.Show("Order is confirmed.Ready to deliver.");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//MessageBox.Show("database connection error");

			}
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
					string query = "select * from OrderedSpices where SpiceId like '%" + textBoxSearch.Text + "%' or SpiceName like '%" + textBoxSearch.Text + "%' or Brand like '%" + textBoxSearch.Text + "%' or Price like '%" + textBoxSearch.Text + "%' or Customer_UserName like '%" + textBoxSearch.Text + "%'";
					SqlDataAdapter sd = new SqlDataAdapter(query, con);
					sd.Fill(dts);
					dataGridViewOrderedSpices.DataSource = dts;
					dataGridViewOrderedSpices.Refresh();

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

		private void dataGridViewOrderedSpices_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NV5CAN\SYLVIESQL;Initial Catalog=TheMoshollaWala;Integrated Security=True");

			try
			{

				DataTable dts = new DataTable();
				con.Open();
				if (con.State == ConnectionState.Open)
				{

					foreach (DataGridViewRow row in dataGridViewOrderedSpices.Rows)
					{
						DataGridViewCheckBoxCell chk0 = (DataGridViewCheckBoxCell)row.Cells[0];
						if (Convert.ToInt32(chk0.EditedFormattedValue) == 1)
						{
							string query1 = "delete from OrderedSpices where SpiceId = '" + row.Cells[1].Value + "' and SpiceName = '" + row.Cells[2].Value + "' and Brand = '" + row.Cells[3].Value + "' and Price = '" + row.Cells[4].Value + "' and Customer_UserName = '" + row.Cells[5].Value + "'";
							string query2 = "insert into DeliveredSpices(SpiceId,SpiceName,Brand,Price,Customer_UserName)values('" + row.Cells[1].Value + "','" + row.Cells[2].Value + "','" + row.Cells[3].Value + "','" + row.Cells[4].Value + "','" + row.Cells[5].Value + "')";
							SqlCommand sqcom1 = new SqlCommand(query1, con);
							SqlCommand sqcom2 = new SqlCommand(query2, con);
							int value1 = sqcom1.ExecuteNonQuery();
							int value2 = sqcom2.ExecuteNonQuery();
							dataGridViewOrderedSpices.Refresh();
						}

					}

					MessageBox.Show("Order is confirmed.Ready to deliver.");
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
