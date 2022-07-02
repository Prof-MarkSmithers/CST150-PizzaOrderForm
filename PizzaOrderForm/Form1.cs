using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderForm
{
	
	public partial class Form1 : Form
	{
		List<Order> OrderList = new List<Order>();
		List<Order> personalOrderList = new List<Order>();
		public Form1()
		{
			this.BackgroundImage = Properties.Resources.PizzaSmall;
			InitializeComponent();
		}

		private void bntOrder_Click(object sender, EventArgs e)
		{
			
			string myString = "";
			//Open Window To place a New Order
			//hide the main_menu
			this.Hide();
			//create instance of Order Form
			PlaceOrder PlacePizzaOrders = new PlaceOrder(this.OrderList);
			//show order form
			PlacePizzaOrders.ShowDialog();
			//null out when done
			PlacePizzaOrders = null;
			//show main menu when complete
			this.Show();
		}

		private void btnView_Orders_Click(object sender, EventArgs e)
		{
			this.Hide();
			//create instance of Order Form
			OrderStatus PizzaOrderStatus = new OrderStatus(this.OrderList);
			//show order form
			PizzaOrderStatus.ShowDialog();
			//null out when done
			PizzaOrderStatus = null;
			//show main menu when complete
			this.Show();
		}
	}
}
