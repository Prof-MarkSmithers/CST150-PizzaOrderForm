using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderForm
{
	class Side : Item
	{
		int qty;
		float price = 4.99f;
		String Type;
		public Side(int qty, String Type)
		{
			this.qty = qty;
			this.Type = Type;
		}
		public float getTotal()
		{
			return qty * price;
		}
		public float getPrice()
		{ return price; }
		private void setPrice(float price)
		{
			this.price = price;
		}
		public override string ToString()
		{
			return qty + " " + Type;
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
