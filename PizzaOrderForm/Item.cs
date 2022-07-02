using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderForm
{
	/*This is the interface and base class of all items*/
	/*change background image:https://www.c-sharpcorner.com/UploadFile/7d3362/window-form-background-image/*/
	interface Item
	{
		float getPrice();
		int getQty();
		String getType();
	}
}
