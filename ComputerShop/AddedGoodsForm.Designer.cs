namespace ComputerShop
{
  partial class AddedGoodsForm
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
	  this.productName = new System.Windows.Forms.TextBox();
	  this.price = new System.Windows.Forms.NumericUpDown();
	  this.categoriesList = new System.Windows.Forms.ComboBox();
	  this.AddedGoodsBtn = new System.Windows.Forms.Button();
	  ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
	  this.SuspendLayout();
	  // 
	  // productName
	  // 
	  this.productName.Location = new System.Drawing.Point(51, 60);
	  this.productName.Name = "productName";
	  this.productName.Size = new System.Drawing.Size(259, 20);
	  this.productName.TabIndex = 0;
	  this.productName.Text = "Наименование";
	  // 
	  // price
	  // 
	  this.price.Location = new System.Drawing.Point(51, 95);
	  this.price.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
	  this.price.Name = "price";
	  this.price.Size = new System.Drawing.Size(259, 20);
	  this.price.TabIndex = 2;
	  // 
	  // categoriesList
	  // 
	  this.categoriesList.FormattingEnabled = true;
	  this.categoriesList.Location = new System.Drawing.Point(51, 135);
	  this.categoriesList.Name = "categoriesList";
	  this.categoriesList.Size = new System.Drawing.Size(259, 21);
	  this.categoriesList.TabIndex = 3;
	  // 
	  // AddedGoodsBtn
	  // 
	  this.AddedGoodsBtn.Location = new System.Drawing.Point(51, 180);
	  this.AddedGoodsBtn.Name = "AddedGoodsBtn";
	  this.AddedGoodsBtn.Size = new System.Drawing.Size(259, 23);
	  this.AddedGoodsBtn.TabIndex = 4;
	  this.AddedGoodsBtn.Text = "Сохранить";
	  this.AddedGoodsBtn.UseVisualStyleBackColor = true;
	  this.AddedGoodsBtn.Click += new System.EventHandler(this.AddedGoodsBtn_Click);
	  // 
	  // AddedGoodsForm
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(354, 270);
	  this.Controls.Add(this.AddedGoodsBtn);
	  this.Controls.Add(this.categoriesList);
	  this.Controls.Add(this.price);
	  this.Controls.Add(this.productName);
	  this.Name = "AddedGoodsForm";
	  this.Text = "Добавление товара";
	  this.Load += new System.EventHandler(this.AddedGoodsForm_Load);
	  ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
	  this.ResumeLayout(false);
	  this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.TextBox productName;
	private System.Windows.Forms.NumericUpDown price;
	private System.Windows.Forms.ComboBox categoriesList;
	private System.Windows.Forms.Button AddedGoodsBtn;
  }
}