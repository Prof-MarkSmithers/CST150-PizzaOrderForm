using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderForm
{
	class Drink : Item
	{
		//all drinks will be the same size:1 Liter 
		//all drinks will be the same price: 99cents
		int qty;
		float price = 0.99f;
		String Type;
		public Drink(int qty, String Type)
		{
			this.qty = qty;
			this.Type = Type;
		}
		public override string ToString()
		{
			return  qty + " " + Type;
		}
		public float getPrice()
		{ return price; }
		public float getTotal()
		{
			return qty * price;
		}

		public int getQty()
		{
			return qty;
		}
		public void addOne()
		{
			this.qty++;
		}
		public void subOne()
		{
			if (this.qty > 0)
			{
				this.qty--;
			}
		}
		public void setQty(int qty)
		{
			this.qty = qty;
		}
		public String getType()
		{
			return Type;
		}
		public void setType(String Type)
		{
			this.Type = Type;
		}
	}
}
