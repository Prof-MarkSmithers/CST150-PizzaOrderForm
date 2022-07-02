using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PizzaOrderForm
{
	public partial class PlaceOrder : Form
	{
		ComboBox cbPizzaQuantity = new ComboBox();
		ComboBox cbSideQuantity = new ComboBox();
		ComboBox cbDrinkQuantity = new ComboBox();
		//int nthOrder = OrderList
		List<Order> OrderList = new List<Order>();
		Order myOrder = new Order();
		private const int EM_SETCUEBANNER = 0x1501;
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
[MarshalAs(UnmanagedType.LPWStr)] string lParam);

		int NumberOfOrders = 0;
		int cb_Width = 92;
		int cb_Height = 24;
		/*
		 * create the order here and not in add to order
		 * There should only be one order upon entry of this page
		 * When the page is closed, the order is submitted unless 
		 * cancel order is placed
		 * help sites:
		 * https://tecwritings.wordpress.com/2019/03/12/add-placeholder-text-to-the-windows-form-text-box-similar-to-html/
		 * scroll bars https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.textbox.multiline?view=windowsdesktop-6.0
		 * 
		*/
		//creates form controls, takes in current list of orders and adds to them as necessary
		public PlaceOrder(List<Order> OrderList)
		{
			
			this.OrderList = OrderList;
			//manually create Pizza Quantity Combo Box
			cbPizzaQuantity = createComboBox(29, 160, "How many?", "cbPizzaQuantity", 0, 100);
			this.Controls.Add(cbPizzaQuantity);
			
			//manually create Sides Quantity Combo Box
			cbSideQuantity = createComboBox(178, 115, "How many?", "cbSideQuantity", 0, 100);
			this.Controls.Add(cbSideQuantity);

			// manually create Drink Quantity Combo Box
			cbDrinkQuantity = createComboBox(322, 115, "How many?", "cbDrinkQuantity", 0, 100);
			this.Controls.Add(cbDrinkQuantity);

			//get how many orders exist
			NumberOfOrders = OrderList.Count;

			this.BackgroundImage = Properties.Resources.PizzaSmall2;

			//Initialize
			InitializeComponent();

			updateNumberOfPizzas();
			//make the order id field read only
			txtBoxOrderID.Text = myOrder.order_id.ToString();
			txtBoxOrderID.ReadOnly = true;
			//make user info multiline and change height
			txtUserInfo.Multiline = true;
			txtUserInfo.Height = 75;
			txtUserInfo.Width = cb_Width + 30;
			txtUserInfo.ReadOnly = true;
			txtUserInfo.ScrollBars = ScrollBars.Vertical;
			//adjust Notes parameters
			txtBoxNotes.Multiline = true;
			txtBoxNotes.Height = 2 * cb_Height;
			txtBoxNotes.ScrollBars = ScrollBars.Vertical;
			//default text here
			SendMessage(txtBoxEmail.Handle, EM_SETCUEBANNER, 0,"(Email)");
			SendMessage(txtBoxPhone.Handle, EM_SETCUEBANNER, 0, "(Phone)");
			SendMessage(txtBoxFName.Handle, EM_SETCUEBANNER, 0, "(First Name)");
			SendMessage(txtBoxLName.Handle, EM_SETCUEBANNER, 0, "(Last Name)");
			SendMessage(txtBoxNotes.Handle, EM_SETCUEBANNER, 0, "(Notes)");
			
		}
	    //create a combo box from scratch
		private ComboBox createComboBox(int loc_x, int loc_y, string text, string name, int start, int stop)
		{
			ComboBox newCB = new ComboBox();
			newCB.Location = new Point(loc_x, loc_y);
			newCB.Size = new Size(cb_Width, cb_Height);
			newCB.Text = text;
			newCB.Name = name;
			for (int i = start; i <= stop; i++)
			{
				newCB.Items.Add(i);
			}
			return newCB;
		}
		//get the number of pizzas in the current order
		private void updateNumberOfPizzas()
		{
			//TextBox numPizza = (Textbox)this.PlaceOrder.FindControl("txtNumPizza");
			
			string[] delim = { Environment.NewLine, "\n" }; // "\n" added in case you manually appended a newline
			
			//myOrder.ToString()
			lBoxOrders.Items.Clear();
			StringBuilder pizza = myOrder.getAllPizza();
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
				string[] vowels = { "a", "e", "i", "o", "u", "y" };
				foreach (string vowel in vowels)
				{
					if (line.ToLower().Contains(vowel))
					{
						is_a_word = true;
					}
				}
				if (is_a_word)
				{
					lBoxOrders.Items.Add(line);
				}
				
			}
			StringBuilder sides = myOrder.getAllSides();
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
				string[] vowels = { "a", "e", "i", "o", "u", "y" };
				foreach (string vowel in vowels)
				{
					if (line.ToLower().Contains(vowel))
					{
						is_a_word = true;
					}
				}
				if (is_a_word)
				{
					lBoxOrders.Items.Add(line);
				}
			}
			StringBuilder drinks = myOrder.getAllDrinks();
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
				string[] vowels = { "a", "e", "i", "o", "u", "y"};
				foreach(string vowel in vowels)
				{
					if(line.ToLower().Contains(vowel))
					{
						is_a_word = true;
					}
				}
				if (is_a_word)
				{
					lBoxOrders.Items.Add(line);
				}
			}

			//add user info to user info text box
			StringBuilder UserInfo = new StringBuilder();
			UserInfo.AppendLine("Order Id: " + myOrder.order_id.ToString());
			UserInfo.AppendLine("First Name: " + myOrder.first_Name.ToString());
			UserInfo.AppendLine("Lasr Name: " + myOrder.last_Name.ToString());
			UserInfo.AppendLine("Email : " + myOrder.email.ToString());
			UserInfo.AppendLine("Phone : " + myOrder.phone.ToString());
			UserInfo.AppendLine("Notes : " + myOrder.notes.ToString());
			txtUserInfo.Text = UserInfo.ToString();

		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMainMenu_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//adds the order to the list of orders and closes the page
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			/* current business rule is only one oder can be placed at a time
			 however as many pizzas, soda, and sides can be added to an order*/
			//change status of order
			myOrder.orderSubmitted();
			//add order to order list
			OrderList.Add(myOrder);
			//close page
			
			this.Close();
		}

		private void btnAddToOrder_Click(object sender, EventArgs e)
		{
			//validation check before creating order on Pizza, Drink, or Side
			//create new Order
			
			//Add Pizza
			Add_Pizza(myOrder);
			//Add Drink
			Add_Drink(myOrder);
			//Add Sides
			Add_Sides(myOrder);
			//Add oder to order list
			set_first_name();
			set_last_name();
			set_email();
			set_phone();
			updateNumberOfPizzas();
		}
		private void set_notes()
		{
			//first name txtBoxFName
			if (txtBoxNotes.Text != "")
			{
				myOrder.notes = txtBoxNotes.Text;
				txtBoxNotes.Text = "";
			}
		}
		private void set_first_name()
		{
			//first name txtBoxFName
			if(txtBoxFName.Text != "")
			{
				myOrder.first_Name = txtBoxFName.Text;
				txtBoxFName.Text = "";
			}
		}
		private void set_last_name()
		{
			//last name txtBoxLName
			if (txtBoxLName.Text != "")
			{
				myOrder.last_Name = txtBoxLName.Text;
				txtBoxLName.Text = "";
			}
		}
		private void set_email()
		{

			//email txtBoxEmail
			if (txtBoxEmail.Text != "")
			{
				myOrder.email = txtBoxEmail.Text;
				txtBoxEmail.Text = "";
			}
		}
		private void set_phone()
		{
			//phone txtBoxPhone
			if (txtBoxPhone.Text != "")
			{
				myOrder.phone = txtBoxPhone.Text;
				txtBoxPhone.Text = "";
			}
		}
		private void Add_Pizza(Order anOrder)
		{
			//get the pizza type from the form
			string pizza_type = cboxPizzaType.GetItemText(cboxPizzaType.SelectedItem);
			//get the pizza size and quantity from the form
			string pizza_size = cboxPizzaSize.GetItemText(cboxPizzaSize.SelectedItem);
			string pizza_qty = cbPizzaQuantity.GetItemText(cbPizzaQuantity.SelectedItem);
			//if pizza quantity is > 0
			if (int.TryParse(pizza_qty, out int qty))
			{
				if(qty > 0)
				{
					String message = "Please review your pizzas? \n";
					message += pizza_qty + " " + pizza_size + " " + pizza_type + "(s)\n";
					string title = "Review Order";
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					DialogResult result = MessageBox.Show(message, title, buttons);
					if (result == DialogResult.Yes)
					{
						//add pizza to orders
						anOrder.addPizza(qty, pizza_type, pizza_size);
					}
					else
					{
						// Message to not submit order
						String cancel_message = "Order not placed \n";
						string cancel_title = "Cancel Order";
						MessageBox.Show(cancel_message, cancel_title);
					}
					/// TODO: clear out or reset fields
					cbPizzaQuantity.Text = "0";
				}
				else
				{
					//do nothing
				}
				
			}
			else
			{
				//Console.WriteLine("String could not be parsed.");
				//if there is no pizza no need to notify user or developer
			}

		}
		//adding drinks to the order
		private void Add_Drink(Order anOrder)
		{
			//get drink type and quantity from form
			string drink_type = cbDrinkType.GetItemText(cbDrinkType.SelectedItem);
			string drink_qty = cbDrinkQuantity.GetItemText(cbDrinkQuantity.SelectedItem);
			//if drink quantity is > 0
			if (int.TryParse(drink_qty, out int qty))
			{
				if (qty > 0)
				{
					String message = "Please review your drinks? \n";
					message += drink_qty + drink_type + "(s)\n";
					string title = "Review Order";
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					DialogResult result = MessageBox.Show(message, title, buttons);
					if (result == DialogResult.Yes)
					{
						//add to order
						anOrder.addDrink(qty, drink_type);
					}
					else
					{
						// Message to not submit order
						String cancel_message = "Order not placed \n";
						string cancel_title = "Cancel Order";
						MessageBox.Show(cancel_message, cancel_title);
					}
					/// TODO: clear out or reset fields
					cbDrinkQuantity.Text = "0";
				}
				
			}
		}
		//adding sides to the order
		private void Add_Sides(Order anOrder)
		{
			//get side type and quantity from form
			string side_type = cbSideTepe.GetItemText(cbSideTepe.SelectedItem);
			string side_qty = cbSideQuantity.GetItemText(cbSideQuantity.SelectedItem);
			//if side quantity is > 0
			if (int.TryParse(side_qty, out int qty))
			{
				if (qty > 0)
				{
					String message = "Please review your sides? \n";
					message += side_qty + " " + side_type + "(s)\n";
					string title = "Review Order";
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					DialogResult result = MessageBox.Show(message, title, buttons);
					if (result == DialogResult.Yes)
					{
						//add to order
						anOrder.addSide(qty, side_type);
					}
					else
					{
						// Message to not submit order
						String cancel_message = "Order not placed \n";
						string cancel_title = "Cancel Order";
						MessageBox.Show(cancel_message, cancel_title);
					}
					/// TODO: clear out or reset fields
					cbSideQuantity.Text = "0";
				}
				
			}
		}
	}
}
