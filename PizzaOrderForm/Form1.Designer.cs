
namespace PizzaOrderForm
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bntOrder = new System.Windows.Forms.Button();
			this.btnView_Orders = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bntOrder
			// 
			this.bntOrder.BackColor = System.Drawing.Color.Red;
			this.bntOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntOrder.ForeColor = System.Drawing.Color.Azure;
			this.bntOrder.Location = new System.Drawing.Point(568, 34);
			this.bntOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bntOrder.Name = "bntOrder";
			this.bntOrder.Size = new System.Drawing.Size(173, 78);
			this.bntOrder.TabIndex = 0;
			this.bntOrder.Text = "Order";
			this.bntOrder.UseVisualStyleBackColor = false;
			this.bntOrder.Click += new System.EventHandler(this.bntOrder_Click);
			// 
			// btnView_Orders
			// 
			this.btnView_Orders.BackColor = System.Drawing.Color.MediumBlue;
			this.btnView_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnView_Orders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnView_Orders.Location = new System.Drawing.Point(568, 130);
			this.btnView_Orders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnView_Orders.Name = "btnView_Orders";
			this.btnView_Orders.Size = new System.Drawing.Size(173, 84);
			this.btnView_Orders.TabIndex = 1;
			this.btnView_Orders.Text = "View Orders";
			this.btnView_Orders.UseVisualStyleBackColor = false;
			this.btnView_Orders.Click += new System.EventHandler(this.btnView_Orders_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnView_Orders);
			this.Controls.Add(this.bntOrder);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bntOrder;
		private System.Windows.Forms.Button btnView_Orders;
	}
}

