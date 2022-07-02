
namespace PizzaOrderForm
{
	partial class PlaceOrder
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
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.lblPizza = new System.Windows.Forms.Label();
			this.lblSides = new System.Windows.Forms.Label();
			this.lblDrinks = new System.Windows.Forms.Label();
			this.cboxPizzaType = new System.Windows.Forms.ComboBox();
			this.cboxPizzaSize = new System.Windows.Forms.ComboBox();
			this.btnAddToOrder = new System.Windows.Forms.Button();
			this.cbSideTepe = new System.Windows.Forms.ComboBox();
			this.cbDrinkType = new System.Windows.Forms.ComboBox();
			this.lBoxOrders = new System.Windows.Forms.ListBox();
			this.txtBoxFName = new System.Windows.Forms.TextBox();
			this.txtBoxLName = new System.Windows.Forms.TextBox();
			this.txtBoxEmail = new System.Windows.Forms.TextBox();
			this.txtBoxPhone = new System.Windows.Forms.TextBox();
			this.txtBoxOrderID = new System.Windows.Forms.TextBox();
			this.txtUserInfo = new System.Windows.Forms.TextBox();
			this.txtBoxNotes = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.Blue;
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.ForeColor = System.Drawing.SystemColors.Menu;
			this.btnSubmit.Location = new System.Drawing.Point(39, 396);
			this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(173, 87);
			this.btnSubmit.TabIndex = 0;
			this.btnSubmit.Text = "Submit Order";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.Location = new System.Drawing.Point(239, 396);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(161, 87);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel Order";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.BackColor = System.Drawing.Color.Blue;
			this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMainMenu.Location = new System.Drawing.Point(429, 396);
			this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(163, 87);
			this.btnMainMenu.TabIndex = 2;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = false;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			// 
			// lblPizza
			// 
			this.lblPizza.AutoSize = true;
			this.lblPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPizza.Location = new System.Drawing.Point(35, 32);
			this.lblPizza.Name = "lblPizza";
			this.lblPizza.Size = new System.Drawing.Size(70, 29);
			this.lblPizza.TabIndex = 3;
			this.lblPizza.Text = "Pizza";
			// 
			// lblSides
			// 
			this.lblSides.AutoSize = true;
			this.lblSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSides.Location = new System.Drawing.Point(233, 33);
			this.lblSides.Name = "lblSides";
			this.lblSides.Size = new System.Drawing.Size(75, 29);
			this.lblSides.TabIndex = 4;
			this.lblSides.Text = "Sides";
			// 
			// lblDrinks
			// 
			this.lblDrinks.AutoSize = true;
			this.lblDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDrinks.Location = new System.Drawing.Point(424, 32);
			this.lblDrinks.Name = "lblDrinks";
			this.lblDrinks.Size = new System.Drawing.Size(81, 29);
			this.lblDrinks.TabIndex = 5;
			this.lblDrinks.Text = "Drinks";
			// 
			// cboxPizzaType
			// 
			this.cboxPizzaType.FormattingEnabled = true;
			this.cboxPizzaType.Items.AddRange(new object[] {
            "Supreme",
            "Peperoni",
            "Greek",
            "Margarita",
            "Sassuage",
            "Cheese"});
			this.cboxPizzaType.Location = new System.Drawing.Point(39, 89);
			this.cboxPizzaType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboxPizzaType.Name = "cboxPizzaType";
			this.cboxPizzaType.Size = new System.Drawing.Size(121, 24);
			this.cboxPizzaType.TabIndex = 6;
			// 
			// cboxPizzaSize
			// 
			this.cboxPizzaSize.FormattingEnabled = true;
			this.cboxPizzaSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
			this.cboxPizzaSize.Location = new System.Drawing.Point(39, 142);
			this.cboxPizzaSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboxPizzaSize.Name = "cboxPizzaSize";
			this.cboxPizzaSize.Size = new System.Drawing.Size(121, 24);
			this.cboxPizzaSize.TabIndex = 7;
			// 
			// btnAddToOrder
			// 
			this.btnAddToOrder.BackColor = System.Drawing.Color.Blue;
			this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAddToOrder.Location = new System.Drawing.Point(617, 396);
			this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAddToOrder.Name = "btnAddToOrder";
			this.btnAddToOrder.Size = new System.Drawing.Size(176, 87);
			this.btnAddToOrder.TabIndex = 8;
			this.btnAddToOrder.Text = "Add To Order";
			this.btnAddToOrder.UseVisualStyleBackColor = false;
			this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
			// 
			// cbSideTepe
			// 
			this.cbSideTepe.FormattingEnabled = true;
			this.cbSideTepe.Items.AddRange(new object[] {
            "Wings",
            "Bread Sticks",
            "Fries"});
			this.cbSideTepe.Location = new System.Drawing.Point(239, 89);
			this.cbSideTepe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSideTepe.Name = "cbSideTepe";
			this.cbSideTepe.Size = new System.Drawing.Size(115, 24);
			this.cbSideTepe.TabIndex = 11;
			// 
			// cbDrinkType
			// 
			this.cbDrinkType.FormattingEnabled = true;
			this.cbDrinkType.Items.AddRange(new object[] {
            "Spirte",
            "Coke",
            "Diet Coke",
            "Mountain Dew",
            "Mr Pibb",
            "Cherry Coke"});
			this.cbDrinkType.Location = new System.Drawing.Point(429, 87);
			this.cbDrinkType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbDrinkType.Name = "cbDrinkType";
			this.cbDrinkType.Size = new System.Drawing.Size(120, 24);
			this.cbDrinkType.TabIndex = 12;
			// 
			// lBoxOrders
			// 
			this.lBoxOrders.FormattingEnabled = true;
			this.lBoxOrders.ItemHeight = 16;
			this.lBoxOrders.Location = new System.Drawing.Point(40, 278);
			this.lBoxOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lBoxOrders.Name = "lBoxOrders";
			this.lBoxOrders.Size = new System.Drawing.Size(363, 84);
			this.lBoxOrders.TabIndex = 14;
			// 
			// txtBoxFName
			// 
			this.txtBoxFName.Location = new System.Drawing.Point(660, 37);
			this.txtBoxFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBoxFName.Name = "txtBoxFName";
			this.txtBoxFName.Size = new System.Drawing.Size(132, 22);
			this.txtBoxFName.TabIndex = 15;
			// 
			// txtBoxLName
			// 
			this.txtBoxLName.Location = new System.Drawing.Point(660, 87);
			this.txtBoxLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBoxLName.Name = "txtBoxLName";
			this.txtBoxLName.Size = new System.Drawing.Size(132, 22);
			this.txtBoxLName.TabIndex = 16;
			// 
			// txtBoxEmail
			// 
			this.txtBoxEmail.Location = new System.Drawing.Point(660, 142);
			this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBoxEmail.Name = "txtBoxEmail";
			this.txtBoxEmail.Size = new System.Drawing.Size(132, 22);
			this.txtBoxEmail.TabIndex = 17;
			// 
			// txtBoxPhone
			// 
			this.txtBoxPhone.Location = new System.Drawing.Point(660, 192);
			this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBoxPhone.Name = "txtBoxPhone";
			this.txtBoxPhone.Size = new System.Drawing.Size(132, 22);
			this.txtBoxPhone.TabIndex = 18;
			// 
			// txtBoxOrderID
			// 
			this.txtBoxOrderID.Location = new System.Drawing.Point(660, 278);
			this.txtBoxOrderID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBoxOrderID.Name = "txtBoxOrderID";
			this.txtBoxOrderID.Size = new System.Drawing.Size(132, 22);
			this.txtBoxOrderID.TabIndex = 19;
			// 
			// txtUserInfo
			// 
			this.txtUserInfo.Location = new System.Drawing.Point(429, 277);
			this.txtUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtUserInfo.Name = "txtUserInfo";
			this.txtUserInfo.Size = new System.Drawing.Size(132, 22);
			this.txtUserInfo.TabIndex = 20;
			// 
			// txtBoxNotes
			// 
			this.txtBoxNotes.Location = new System.Drawing.Point(660, 310);
			this.txtBoxNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtBoxNotes.Name = "txtBoxNotes";
			this.txtBoxNotes.Size = new System.Drawing.Size(132, 22);
			this.txtBoxNotes.TabIndex = 21;
			// 
			// PlaceOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(869, 514);
			this.Controls.Add(this.txtBoxNotes);
			this.Controls.Add(this.txtUserInfo);
			this.Controls.Add(this.txtBoxOrderID);
			this.Controls.Add(this.txtBoxPhone);
			this.Controls.Add(this.txtBoxEmail);
			this.Controls.Add(this.txtBoxLName);
			this.Controls.Add(this.txtBoxFName);
			this.Controls.Add(this.lBoxOrders);
			this.Controls.Add(this.cbDrinkType);
			this.Controls.Add(this.cbSideTepe);
			this.Controls.Add(this.btnAddToOrder);
			this.Controls.Add(this.cboxPizzaSize);
			this.Controls.Add(this.cboxPizzaType);
			this.Controls.Add(this.lblDrinks);
			this.Controls.Add(this.lblSides);
			this.Controls.Add(this.lblPizza);
			this.Controls.Add(this.btnMainMenu);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "PlaceOrder";
			this.Text = "PlaceOrder";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnMainMenu;
		private System.Windows.Forms.Label lblPizza;
		private System.Windows.Forms.Label lblSides;
		private System.Windows.Forms.Label lblDrinks;
		private System.Windows.Forms.ComboBox cboxPizzaType;
		private System.Windows.Forms.ComboBox cboxPizzaSize;
		private System.Windows.Forms.Button btnAddToOrder;
		private System.Windows.Forms.ComboBox cbSideTepe;
		private System.Windows.Forms.ComboBox cbDrinkType;
		private System.Windows.Forms.ListBox lBoxOrders;
		private System.Windows.Forms.TextBox txtBoxFName;
		private System.Windows.Forms.TextBox txtBoxLName;
		private System.Windows.Forms.TextBox txtBoxEmail;
		private System.Windows.Forms.TextBox txtBoxPhone;
		private System.Windows.Forms.TextBox txtBoxOrderID;
		private System.Windows.Forms.TextBox txtUserInfo;
		private System.Windows.Forms.TextBox txtBoxNotes;
	}
}