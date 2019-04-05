namespace ComputerShop
{
  partial class Users
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
	  this.usersList = new System.Windows.Forms.ListView();
	  this.SuspendLayout();
	  // 
	  // usersList
	  // 
	  this.usersList.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.usersList.Location = new System.Drawing.Point(0, 0);
	  this.usersList.Name = "usersList";
	  this.usersList.Size = new System.Drawing.Size(938, 441);
	  this.usersList.TabIndex = 0;
	  this.usersList.UseCompatibleStateImageBehavior = false;
	  this.usersList.View = System.Windows.Forms.View.List;
	  // 
	  // Users
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(938, 441);
	  this.Controls.Add(this.usersList);
	  this.Name = "Users";
	  this.Text = "Пользователи";
	  this.Load += new System.EventHandler(this.Users_Load);
	  this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.ListView usersList;
  }
}