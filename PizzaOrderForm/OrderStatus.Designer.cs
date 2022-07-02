
namespace PizzaOrderForm
{
	partial class OrderStatus
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
			this.LBoxOrdersPlaced = new System.Windows.Forms.ListBox();
			this.lblSubmitted = new System.Windows.Forms.Label();
			this.LBoxProcessing = new System.Windows.Forms.ListBox();
			this.LBoxComplete = new System.Windows.Forms.ListBox();
			this.lblProcessing = new System.Windows.Forms.Label();
			this.lblCompleted = new System.Windows.Forms.Label();
			this.LBoxDeleted = new System.Windows.Forms.ListBox();
			this.lblDeleted = new System.Windows.Forms.Label();
			this.LBoxDetailedView = new System.Windows.Forms.ListBox();
			this.TBoxStatus = new System.Windows.Forms.TextBox();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.btnSumbiited = new System.Windows.Forms.Button();
			this.btnProcessing = new System.Windows.Forms.Button();
			this.btnCompleted = new System.Windows.Forms.Button();
			this.btnCancelled = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LBoxOrdersPlaced
			// 
			this.LBoxOrdersPlaced.FormattingEnabled = true;
			this.LBoxOrdersPlaced.ItemHeight = 16;
			this.LBoxOrdersPlaced.Location = new System.Drawing.Point(60, 41);
			this.LBoxOrdersPlaced.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.LBoxOrdersPlaced.Name = "LBoxOrdersPlaced";
			this.LBoxOrdersPlaced.Size = new System.Drawing.Size(159, 116);
			this.LBoxOrdersPlaced.TabIndex = 0;
			this.LBoxOrdersPlaced.SelectedIndexChanged += new System.EventHandler(this.LBoxOrdersPlaced_SelectedIndexChanged);
			// 
			// lblSubmitted
			// 
			this.lblSubmitted.AutoSize = true;
			this.lblSubmitted.Location = new System.Drawing.Point(60, 180);
			this.lblSubmitted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubmitted.Name = "lblSubmitted";
			this.lblSubmitted.Size = new System.Drawing.Size(71, 17);
			this.lblSubmitted.TabIndex = 1;
			this.lblSubmitted.Text = "Submitted";
			// 
			// LBoxProcessing
			// 
			this.LBoxProcessing.FormattingEnabled = true;
			this.LBoxProcessing.ItemHeight = 16;
			this.LBoxProcessing.Location = new System.Drawing.Point(280, 41);
			this.LBoxProcessing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.LBoxProcessing.Name = "LBoxProcessing";
			this.LBoxProcessing.Size = new System.Drawing.Size(159, 116);
			this.LBoxProcessing.TabIndex = 2;
			// 
			// LBoxComplete
			// 
			this.LBoxComplete.FormattingEnabled = true;
			this.LBoxComplete.ItemHeight = 16;
			this.LBoxComplete.Location = new System.Drawing.Point(500, 41);
			this.LBoxComplete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.LBoxComplete.Name = "LBoxComplete";
			this.LBoxComplete.Size = new System.Drawing.Size(159, 116);
			this.LBoxComplete.TabIndex = 4;
			// 
			// lblProcessing
			// 
			this.lblProcessing.AutoSize = true;
			this.lblProcessing.Location = new System.Drawing.Point(280, 180);
			this.lblProcessing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProcessing.Name = "lblProcessing";
			this.lblProcessing.Size = new System.Drawing.Size(78, 17);
			this.lblProcessing.TabIndex = 5;
			this.lblProcessing.Text = "Processing";
			// 
			// lblCompleted
			// 
			this.lblCompleted.AutoSize = true;
			this.lblCompleted.Location = new System.Drawing.Point(500, 180);
			this.lblCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCompleted.Name = "lblCompleted";
			this.lblCompleted.Size = new System.Drawing.Size(75, 17);
			this.lblCompleted.TabIndex = 6;
			this.lblCompleted.Text = "Completed";
			// 
			// LBoxDeleted
			// 
			this.LBoxDeleted.FormattingEnabled = true;
			this.LBoxDeleted.ItemHeight = 16;
			this.LBoxDeleted.Location = new System.Drawing.Point(713, 41);
			this.LBoxDeleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.LBoxDeleted.Name = "LBoxDeleted";
			this.LBoxDeleted.Size = new System.Drawing.Size(159, 116);
			this.LBoxDeleted.TabIndex = 7;
			// 
			// lblDeleted
			// 
			this.lblDeleted.AutoSize = true;
			this.lblDeleted.Location = new System.Drawing.Point(710, 180);
			this.lblDeleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDeleted.Name = "lblDeleted";
			this.lblDeleted.Size = new System.Drawing.Size(123, 17);
			this.lblDeleted.TabIndex = 8;
			this.lblDeleted.Text = "Deleted/Cancelled";
			// 
			// LBoxDetailedView
			// 
			this.LBoxDetailedView.FormattingEnabled = true;
			this.LBoxDetailedView.ItemHeight = 16;
			this.LBoxDetailedView.Location = new System.Drawing.Point(60, 268);
			this.LBoxDetailedView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.LBoxDetailedView.Name = "LBoxDetailedView";
			this.LBoxDetailedView.Size = new System.Drawing.Size(515, 116);
			this.LBoxDetailedView.TabIndex = 9;
			// 
			// TBoxStatus
			// 
			this.TBoxStatus.Location = new System.Drawing.Point(740, 268);
			this.TBoxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TBoxStatus.Name = "TBoxStatus";
			this.TBoxStatus.Size = new System.Drawing.Size(132, 22);
			this.TBoxStatus.TabIndex = 10;
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.BackColor = System.Drawing.Color.Blue;
			this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMainMenu.Location = new System.Drawing.Point(716, 359);
			this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(156, 85);
			this.btnMainMenu.TabIndex = 11;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = false;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			// 
			// btnSumbiited
			// 
			this.btnSumbiited.BackColor = System.Drawing.Color.Blue;
			this.btnSumbiited.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSumbiited.Location = new System.Drawing.Point(60, 416);
			this.btnSumbiited.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSumbiited.Name = "btnSumbiited";
			this.btnSumbiited.Size = new System.Drawing.Size(100, 28);
			this.btnSumbiited.TabIndex = 12;
			this.btnSumbiited.Text = "Submitted";
			this.btnSumbiited.UseVisualStyleBackColor = false;
			this.btnSumbiited.Click += new System.EventHandler(this.btnSumbiited_Click);
			// 
			// btnProcessing
			// 
			this.btnProcessing.BackColor = System.Drawing.Color.Blue;
			this.btnProcessing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnProcessing.Location = new System.Drawing.Point(199, 416);
			this.btnProcessing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnProcessing.Name = "btnProcessing";
			this.btnProcessing.Size = new System.Drawing.Size(100, 28);
			this.btnProcessing.TabIndex = 13;
			this.btnProcessing.Text = "Processing";
			this.btnProcessing.UseVisualStyleBackColor = false;
			this.btnProcessing.Click += new System.EventHandler(this.btnProcessing_Click);
			// 
			// btnCompleted
			// 
			this.btnCompleted.BackColor = System.Drawing.Color.Blue;
			this.btnCompleted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCompleted.Location = new System.Drawing.Point(339, 416);
			this.btnCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCompleted.Name = "btnCompleted";
			this.btnCompleted.Size = new System.Drawing.Size(100, 28);
			this.btnCompleted.TabIndex = 14;
			this.btnCompleted.Text = "Completed";
			this.btnCompleted.UseVisualStyleBackColor = false;
			this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
			// 
			// btnCancelled
			// 
			this.btnCancelled.BackColor = System.Drawing.Color.Red;
			this.btnCancelled.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancelled.Location = new System.Drawing.Point(476, 416);
			this.btnCancelled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCancelled.Name = "btnCancelled";
			this.btnCancelled.Size = new System.Drawing.Size(100, 28);
			this.btnCancelled.TabIndex = 15;
			this.btnCancelled.Text = "Cancelled";
			this.btnCancelled.UseVisualStyleBackColor = false;
			this.btnCancelled.Click += new System.EventHandler(this.btnCancelled_Click);
			// 
			// OrderStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(946, 509);
			this.Controls.Add(this.btnCancelled);
			this.Controls.Add(this.btnCompleted);
			this.Controls.Add(this.btnProcessing);
			this.Controls.Add(this.btnSumbiited);
			this.Controls.Add(this.btnMainMenu);
			this.Controls.Add(this.TBoxStatus);
			this.Controls.Add(this.LBoxDetailedView);
			this.Controls.Add(this.lblDeleted);
			this.Controls.Add(this.LBoxDeleted);
			this.Controls.Add(this.lblCompleted);
			this.Controls.Add(this.lblProcessing);
			this.Controls.Add(this.LBoxComplete);
			this.Controls.Add(this.LBoxProcessing);
			this.Controls.Add(this.lblSubmitted);
			this.Controls.Add(this.LBoxOrdersPlaced);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "OrderStatus";
			this.Text = "OrderStatus";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox LBoxOrdersPlaced;
		private System.Windows.Forms.Label lblSubmitted;
		private System.Windows.Forms.ListBox LBoxProcessing;
		private System.Windows.Forms.ListBox LBoxComplete;
		private System.Windows.Forms.Label lblProcessing;
		private System.Windows.Forms.Label lblCompleted;
		private System.Windows.Forms.ListBox LBoxDeleted;
		private System.Windows.Forms.Label lblDeleted;
		private System.Windows.Forms.ListBox LBoxDetailedView;
		private System.Windows.Forms.TextBox TBoxStatus;
		private System.Windows.Forms.Button btnMainMenu;
		private System.Windows.Forms.Button btnSumbiited;
		private System.Windows.Forms.Button btnProcessing;
		private System.Windows.Forms.Button btnCompleted;
		private System.Windows.Forms.Button btnCancelled;
	}
}