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
	public partial class OrderStatus : Form
	{
		//creat an order list
		List<Order> OrderList = new List<Order>();
		//add seleced index event  https://www.codeproject.com/Questions/348044/mouseclick-event-on-listbox-item-in-csharp-visual
		public OrderStatus(List<Order> OrderList)
		{
			this.OrderList = OrderList;
			this.BackgroundImage = Properties.Resources.PizzaSmall6;

			InitializeComponent();
			LBoxProcessing.SelectedValueChanged += new EventHandler(LBoxOrdersPlaced_SelectedIndexChanged);
			LBoxComplete.SelectedValueChanged += new EventHandler(LBoxOrdersPlaced_SelectedIndexChanged);
			LBoxDeleted.SelectedValueChanged += new EventHandler(LBoxOrdersPlaced_SelectedIndexChanged);
			//LBoxProcessing.
			sort_status();
		}
		private void sort_status()
		{
			LBoxOrdersPlaced.Items.Clear();
			LBoxProcessing.Items.Clear();
			LBoxComplete.Items.Clear();
			LBoxDeleted.Items.Clear();
			//loop through all orders and place the order number in the list box
			foreach (var order in OrderList)
			{
				switch (order.getStatus().ToLower())
				{
					case "submitted":
						//do something
						//LBoxOrdersPlaced
						LBoxOrdersPlaced.Items.Add(order.order_id);
						break;
					case "processing":
						//do something
						LBoxProcessing.Items.Add(order.order_id);
						break;
					case "completed":
						//do something
						LBoxComplete.Items.Add(order.order_id);
						break;
					case "deleted":
						//do something
						LBoxDeleted.Items.Add(order.order_id);
						break;
					default:
						//do something
						break;
				}
			}
		}
		private void btnMainMenu_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void LBoxOrdersPlaced_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] vowels = { "a", "e", "i", "o", "u", "y" };
			System.Windows.Forms.ListBox listbox = (System.Windows.Forms.ListBox)sender;
			foreach (var order in OrderList)
			{
				if (order.order_id.ToString().Contains(listbox.SelectedItem.ToString()))
				{
					string[] delim = { Environment.NewLine, "\n" }; // "\n" added in case you manually appended a newline
																	//clear the details in the box
					LBoxDetailedView.Items.Clear();
					//order id is fist lime in box
					LBoxDetailedView.Items.Add(order.order_id.ToString());
					LBoxDetailedView.Items.Add(order.first_Name.ToString());
					LBoxDetailedView.Items.Add(order.last_Name.ToString());
					LBoxDetailedView.Items.Add(order.email.ToString());
					LBoxDetailedView.Items.Add(order.phone.ToString());
					//put status in status box
					TBoxStatus.Text = order.getStatus();
					//put details in the box

					StringBuilder pizza = order.getAllPizza();
					string[] lines = pizza.ToString().Split(delim, StringSplitOptions.None);
					foreach (string line in lines)
					{
						Boolean is_a_word = false;
						/*
						 * code kept throwing in empty spaces in check boxes
						 * so I check to see if there is a vowel anywhere in the line of text
						 * if there are no vowels, all english words have vowels,
						 * do not add
						 */
						foreach (string vowel in vowels)
						{
							if (line.ToLower().Contains(vowel))
							{
								is_a_word = true;
							}
						}
						if (is_a_word)
						{
							LBoxDetailedView.Items.Add(line);
						}
					}

					StringBuilder sides = order.getAllSides();
					string[] lines_sides = sides.ToString().Split(delim, StringSplitOptions.None);

					foreach (string line in lines_sides)
					{
						Boolean is_a_word = false;
						/*
						 * code kept throwing in empty spaces in check boxes
						 * so I check to see if there is a vowel anywhere in the line of text
						 * if there are no vowels, all english words have vowels,
						 * do not add
						 */
						foreach (string vowel in vowels)
						{
							if (line.ToLower().Contains(vowel))
							{
								is_a_word = true;
							}
						}
						if (is_a_word)
						{
							LBoxDetailedView.Items.Add(line);
						}
					}
					StringBuilder drinks = order.getAllDrinks();
					string[] lines_drinks = drinks.ToString().Split(delim, StringSplitOptions.None);
					foreach (string line in lines_drinks)
					{
						Boolean is_a_word = false;
						/*
						 * code kept throwing in empty spaces in check boxes
						 * so I check to see if there is a vowel anywhere in the line of text
						 * if there are no vowels, all english words have vowels,
						 * do not add
						 */
						foreach (string vowel in vowels)
						{
							if (line.ToLower().Contains(vowel))
							{
								is_a_word = true;
							}
						}
						if (is_a_word)
						{
							LBoxDetailedView.Items.Add(line);
						}

					}
				}
			}
		}

		private void change_status(object sender, EventArgs e, string status)
		{
			if (LBoxDetailedView.Items.Count > 0)
			{
				String myOrderID = LBoxDetailedView.Items[0].ToString();
				if (myOrderID != "")
				{
					foreach (var order in OrderList)
					{
						if (order.order_id.ToString().Contains(myOrderID.ToString()))
						{
							switch (status.ToLower())
							{
								case "submitted":
									order.orderSubmitted();
									break;
								case "processing":
									order.orderProcessing();
									break;
								case "complete":
									order.orderCompleted();
									break;
								case "deleted":
									order.orderDeleted();
									break;
								default:
									// code block
									break;
							}
							//sort or resort
							TBoxStatus.Text = status;
							sort_status();
						}
					}
				}
			}
		}
		//change status to submitted unless alread this status
		private void btnSumbiited_Click(object sender, EventArgs e)
		{
			change_status(sender, e, "submitted");
		}
		//change status to processing unless alread this status
		private void btnProcessing_Click(object sender, EventArgs e)
		{
			change_status(sender, e, "processing");
		}
		//change status to completed unless alread this status
		private void btnCompleted_Click(object sender, EventArgs e)
		{
			change_status(sender, e, "complete");
		}
		//change status to cancelled unless alread this status
		private void btnCancelled_Click(object sender, EventArgs e)
		{
			change_status(sender, e, "deleted");
		}
	}
}
