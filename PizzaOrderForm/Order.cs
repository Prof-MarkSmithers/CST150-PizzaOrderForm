using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderForm
{
	public enum Status
	{
		UnSumbitted,
		Submitted,
		Processing,
		Completed,
		Deleted
	}
	public class Order
	{
		float total = 0.00f;
		List<Pizza> PizzaList = new List<Pizza>();
		List<Side> SideList = new List<Side>();
		List<Drink> DrinkList = new List<Drink>();
		Status orderStatus = Status.UnSumbitted;
		
		public Order()
		{
			this.created = DateTime.Now;
			this.first_Name = "John ";
			this.last_Name = "Wayne";
			this.email = "John.Wayne@gmail.com";
			this.phone = "555-555-5555";
			this.payment_method = "Cash";
			order_id = Guid.NewGuid();
			this.notes = "";
		}
		Order(DateTime created, String first_Name, String last_Name, String email, String phone, String payment_method )
		{
			this.created = created;
			this.first_Name = first_Name;
			this.last_Name = last_Name;
			this.email = email;
			this.phone = phone;
			this.payment_method = payment_method;
			this.notes = "";
		}
		public StringBuilder getAllPizza()
		{
			StringBuilder SB = new StringBuilder();
			foreach (var pizza in PizzaList)
			{
				SB.AppendLine(pizza.ToString());
			}
			return SB;
		}
		public StringBuilder getAllSides()
		{
			StringBuilder SB = new StringBuilder();
			foreach (var side in SideList)
			{
				SB.AppendLine(side.ToString());
			}
			return SB;
		}
		//returns a string builder of the item and quantity of drinks
		public StringBuilder getAllDrinks()
		{
			StringBuilder SB = new StringBuilder();
			foreach (var drink in DrinkList)
			{
				SB.AppendLine(drink.ToString());
			}
			return SB;
		}
		//returns a string builder of the item and quantity of pizza, sides and drinks
		public override String ToString()
		{
			StringBuilder orderSB = new StringBuilder();
			//get all pizza
			orderSB.AppendLine(getAllPizza().ToString());

			//get all sides
			orderSB.AppendLine(getAllSides().ToString());

			//get all drinks
			orderSB.AppendLine(getAllDrinks().ToString());

			return orderSB.ToString();
		}
		public bool updated { get; set; }
		public bool cancelled { get; set; }
		public DateTime created { get; set; }
		public DateTime completed { get; set; }
		public String first_Name { get; set; }
		public Guid order_id { get; set; }
		public String last_Name { get; set; }
		public String notes { get; set; }
		public String email
		{
			get; set;
		}
		 public String phone
		{
			get; set;
		}
		 public String payment_method
		{
			get; set;
		}
		/*adds a pizza to the order*/
		public void addPizza(int qty, String Type, String size)
		{
			bool pizzaExist = false;
			/*There is only one size, so drinks of the same type just add one*/
			foreach (var pizza in PizzaList)
			{
				//if the drink already exist up the quantity
				if (Type.Contains(pizza.getType()) && pizza.getType().Contains(Type) && pizza.size.Contains(size))
				{
					pizzaExist = true;
					for (int i = 0; i < qty; i++)
					{ pizza.addOne(); }
				}
			}
			if (!pizzaExist)
			{
				//if the drink does not exist add to the list
				PizzaList.Add(new Pizza(qty, Type, size));
			}
			//PizzaList.Add(new Pizza(qty, Type, size));
		}
		//returns order status
		public string getStatus()
		{
			return orderStatus.ToString();
		}
		//sets the order status to submitted
		public void orderSubmitted()
		{
			orderStatus = Status.Submitted;
		}
		//sets the order status to processing
		public void orderProcessing()
		{
			orderStatus = Status.Processing;
		}
		public void orderCompleted()
		{
			orderStatus = Status.Completed;
		}
		//marks an order as deleted, but data still remains
		public void orderDeleted()
		{ orderStatus = Status.Deleted; }
		//returns the total number of pizza
		public int getPizzaQty()
		{
			int myPizzaCount = 0;
			foreach (var pizza in PizzaList)
			{
				myPizzaCount += pizza.getQty();
			}
			return myPizzaCount;
		}
		//returns the total number of drinks
		public int getDrinkQty()
		{
			int myDrinkCount = 0;
			foreach (var drink in DrinkList)
			{
				myDrinkCount += drink.getQty();
			}
			return myDrinkCount;
		}
		//returns the total number of sides
		public int getSidesQty()
		{
			int mySideCount = 0;
			foreach (var side in SideList)
			{
				mySideCount += side.getQty();
			}
			return mySideCount;
		}
		/*adds a side to the order*/
		public void addSide(int qty, String Type)
		{
			bool sideExist = false;
			/*There is only one size, so drinks of the same type just add one*/
			foreach (var side in SideList)
			{
				//if the drink already exist up the quantity
				if (Type.Contains(side.getType()) && side.getType().Contains(Type))
				{
					sideExist = true;
					for (int i = 0; i < qty; i++)
					  side.addOne();
				}
			}
			if (!sideExist)
			{
				//if the drink does not exist add to the list
				SideList.Add(new Side(qty, Type));
			}
		}
		/*adds a drink to the order*/
		public void addDrink(int qty, String Type)
		{
			bool drinkExist = false;
			/*There is only one size, so drinks of the same type just add one*/
			foreach (var drink in DrinkList)
			{
				//if the drink already exist up the quantity
				if(Type.Contains(drink.getType()) && drink.getType().Contains(Type))
				{
					drinkExist = true;
					drink.addOne();
				}
			}
		    if(!drinkExist)
			{
				//if the drink does not exist add to the list
				DrinkList.Add(new Drink(qty, Type));
			}
		}
		//sets the total price
		public void setTotal()
		{
			foreach (var pizza in PizzaList)
			{
				total += pizza.getTotal();
			}
			foreach (var side in SideList)
			{
				total += side.getTotal();
			}
			foreach (var drink in DrinkList)
			{
				total += drink.getTotal();
			}
		}
	}
}
