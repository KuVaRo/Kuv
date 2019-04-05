namespace ComputerShop
{
  partial class Orders
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
	  this.OrdersList = new System.Windows.Forms.ListView();
	  this.SuspendLayout();
	  // 
	  // OrdersList
	  // 
	  this.OrdersList.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.OrdersList.Location = new System.Drawing.Point(0, 0);
	  this.OrdersList.Name = "OrdersList";
	  this.OrdersList.Size = new System.Drawing.Size(914, 450);
	  this.OrdersList.TabIndex = 0;
	  this.OrdersList.UseCompatibleStateImageBehavior = false;
	  this.OrdersList.View = System.Windows.Forms.View.List;
	  // 
	  // Orders
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(914, 450);
	  this.Controls.Add(this.OrdersList);
	  this.Name = "Orders";
	  this.Text = " Заказы";
	  this.Load += new System.EventHandler(this.Orders_Load);
	  this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.ListView OrdersList;
  }
}