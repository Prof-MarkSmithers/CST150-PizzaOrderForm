using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderForm
{
	class Pizza : Item
	{
		int qty;
		float price;
		public String size { get; set; }
		String Type;
		public Pizza(int qty, String Type, String size)
		{
			this.qty = qty;
			this.Type = Type;
			this.size = size;
		}
		public override string ToString()
		{
			return  qty + " " +  size + " " + Type;
		}
		public float getPrice()
		{ return price; }
		private void setPrice()
		{
			if(Type.ToLower().Contains("small"))
			{
				this.price = 5.99f;
			}
			else if (Type.ToLower().Contains("medium"))
			{
				this.price = 7.99f;
			}
			else {
				this.price = 10.99f;
			}
		}
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
			if(this.qty>0)
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
