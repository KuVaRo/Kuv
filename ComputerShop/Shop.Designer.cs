namespace ComputerShop
{
  partial class Shop
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
	  this.goodsList = new System.Windows.Forms.ListView();
	  this.AddGoods = new System.Windows.Forms.Button();
	  this.RemoveGoods = new System.Windows.Forms.Button();
	  this.updateGoods = new System.Windows.Forms.Button();
	  this.CreateOrder = new System.Windows.Forms.Button();
	  this.goodsCount = new System.Windows.Forms.NumericUpDown();
	  this.orderStatus = new System.Windows.Forms.Label();
	  this.orderList = new System.Windows.Forms.ListView();
	  this.DoneOrders = new System.Windows.Forms.Button();
	  this.GetClients = new System.Windows.Forms.Button();
	  this.GetEmployees = new System.Windows.Forms.Button();
	  this.GetOrders = new System.Windows.Forms.Button();
	  ((System.ComponentModel.ISupportInitialize)(this.goodsCount)).BeginInit();
	  this.SuspendLayout();
	  // 
	  // goodsList
	  // 
	  this.goodsList.Dock = System.Windows.Forms.DockStyle.Left;
	  this.goodsList.Location = new System.Drawing.Point(0, 0);
	  this.goodsList.MultiSelect = false;
	  this.goodsList.Name = "goodsList";
	  this.goodsList.Size = new System.Drawing.Size(529, 448);
	  this.goodsList.TabIndex = 0;
	  this.goodsList.UseCompatibleStateImageBehavior = false;
	  this.goodsList.View = System.Windows.Forms.View.List;
	  // 
	  // AddGoods
	  // 
	  this.AddGoods.Location = new System.Drawing.Point(579, 25);
	  this.AddGoods.Name = "AddGoods";
	  this.AddGoods.Size = new System.Drawing.Size(196, 23);
	  this.AddGoods.TabIndex = 1;
	  this.AddGoods.Text = "Добавить";
	  this.AddGoods.UseVisualStyleBackColor = true;
	  this.AddGoods.Click += new System.EventHandler(this.AddGoods_Click);
	  // 
	  // RemoveGoods
	  // 
	  this.RemoveGoods.Location = new System.Drawing.Point(579, 88);
	  this.RemoveGoods.Name = "RemoveGoods";
	  this.RemoveGoods.Size = new System.Drawing.Size(196, 23);
	  this.RemoveGoods.TabIndex = 2;
	  this.RemoveGoods.Text = "Удалить";
	  this.RemoveGoods.UseVisualStyleBackColor = true;
	  this.RemoveGoods.Click += new System.EventHandler(this.RemoveGoods_Click);
	  // 
	  // updateGoods
	  // 
	  this.updateGoods.Location = new System.Drawing.Point(579, 56);
	  this.updateGoods.Name = "updateGoods";
	  this.updateGoods.Size = new System.Drawing.Size(196, 23);
	  this.updateGoods.TabIndex = 3;
	  this.updateGoods.Text = "Изменить";
	  this.updateGoods.UseVisualStyleBackColor = true;
	  this.updateGoods.Click += new System.EventHandler(this.updateGoods_Click);
	  // 
	  // CreateOrder
	  // 
	  this.CreateOrder.Location = new System.Drawing.Point(579, 27);
	  this.CreateOrder.Name = "CreateOrder";
	  this.CreateOrder.Size = new System.Drawing.Size(147, 23);
	  this.CreateOrder.TabIndex = 4;
	  this.CreateOrder.Text = "Оформить заказ";
	  this.CreateOrder.UseVisualStyleBackColor = true;
	  this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
	  // 
	  // goodsCount
	  // 
	  this.goodsCount.Location = new System.Drawing.Point(732, 28);
	  this.goodsCount.Name = "goodsCount";
	  this.goodsCount.Size = new System.Drawing.Size(43, 20);
	  this.goodsCount.TabIndex = 5;
	  // 
	  // orderStatus
	  // 
	  this.orderStatus.AutoSize = true;
	  this.orderStatus.Location = new System.Drawing.Point(576, 65);
	  this.orderStatus.Name = "orderStatus";
	  this.orderStatus.Size = new System.Drawing.Size(0, 13);
	  this.orderStatus.TabIndex = 6;
	  // 
	  // orderList
	  // 
	  this.orderList.Location = new System.Drawing.Point(529, 286);
	  this.orderList.Name = "orderList";
	  this.orderList.Size = new System.Drawing.Size(525, 162);
	  this.orderList.TabIndex = 7;
	  this.orderList.UseCompatibleStateImageBehavior = false;
	  this.orderList.View = System.Windows.Forms.View.List;
	  // 
	  // DoneOrders
	  // 
	  this.DoneOrders.Location = new System.Drawing.Point(579, 117);
	  this.DoneOrders.Name = "DoneOrders";
	  this.DoneOrders.Size = new System.Drawing.Size(196, 23);
	  this.DoneOrders.TabIndex = 8;
	  this.DoneOrders.Text = "Заказ выполнен";
	  this.DoneOrders.UseVisualStyleBackColor = true;
	  this.DoneOrders.Click += new System.EventHandler(this.DoneOrders_Click);
	  // 
	  // GetClients
	  // 
	  this.GetClients.Location = new System.Drawing.Point(817, 26);
	  this.GetClients.Name = "GetClients";
	  this.GetClients.Size = new System.Drawing.Size(196, 23);
	  this.GetClients.TabIndex = 9;
	  this.GetClients.Text = "Клиенты";
	  this.GetClients.UseVisualStyleBackColor = true;
	  this.GetClients.Click += new System.EventHandler(this.GetClients_Click);
	  // 
	  // GetEmployees
	  // 
	  this.GetEmployees.Location = new System.Drawing.Point(817, 55);
	  this.GetEmployees.Name = "GetEmployees";
	  this.GetEmployees.Size = new System.Drawing.Size(196, 23);
	  this.GetEmployees.TabIndex = 10;
	  this.GetEmployees.Text = "Сотрудники";
	  this.GetEmployees.UseVisualStyleBackColor = true;
	  this.GetEmployees.Click += new System.EventHandler(this.GetEmployees_Click);
	  // 
	  // GetOrders
	  // 
	  this.GetOrders.Location = new System.Drawing.Point(817, 84);
	  this.GetOrders.Name = "GetOrders";
	  this.GetOrders.Size = new System.Drawing.Size(196, 23);
	  this.GetOrders.TabIndex = 11;
	  this.GetOrders.Text = "Заказы";
	  this.GetOrders.UseVisualStyleBackColor = true;
	  this.GetOrders.Click += new System.EventHandler(this.GetOrders_Click);
	  // 
	  // Shop
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(1054, 448);
	  this.Controls.Add(this.GetOrders);
	  this.Controls.Add(this.GetEmployees);
	  this.Controls.Add(this.GetClients);
	  this.Controls.Add(this.DoneOrders);
	  this.Controls.Add(this.orderList);
	  this.Controls.Add(this.orderStatus);
	  this.Controls.Add(this.goodsCount);
	  this.Controls.Add(this.CreateOrder);
	  this.Controls.Add(this.updateGoods);
	  this.Controls.Add(this.RemoveGoods);
	  this.Controls.Add(this.AddGoods);
	  this.Controls.Add(this.goodsList);
	  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
	  this.Name = "Shop";
	  this.Text = "Магазин";
	  this.Load += new System.EventHandler(this.Shop_Load);
	  ((System.ComponentModel.ISupportInitialize)(this.goodsCount)).EndInit();
	  this.ResumeLayout(false);
	  this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.ListView goodsList;
	private System.Windows.Forms.Button AddGoods;
	private System.Windows.Forms.Button RemoveGoods;
	private System.Windows.Forms.Button updateGoods;
	private System.Windows.Forms.Button CreateOrder;
	private System.Windows.Forms.NumericUpDown goodsCount;
	private System.Windows.Forms.Label orderStatus;
	private System.Windows.Forms.ListView orderList;
	private System.Windows.Forms.Button DoneOrders;
	private System.Windows.Forms.Button GetClients;
	private System.Windows.Forms.Button GetEmployees;
	private System.Windows.Forms.Button GetOrders;
  }
}