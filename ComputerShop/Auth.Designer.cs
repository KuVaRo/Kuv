namespace ComputerShop
{
  partial class Auth
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
	  this.authTabs = new System.Windows.Forms.TabControl();
	  this.loginTab = new System.Windows.Forms.TabPage();
	  this.IsEmployee = new System.Windows.Forms.CheckBox();
	  this.Login = new System.Windows.Forms.Button();
	  this.passwordText = new System.Windows.Forms.TextBox();
	  this.loginText = new System.Windows.Forms.TextBox();
	  this.registrationTab = new System.Windows.Forms.TabPage();
	  this.phoneText = new System.Windows.Forms.MaskedTextBox();
	  this.passwordRegText = new System.Windows.Forms.TextBox();
	  this.loginRegText = new System.Windows.Forms.TextBox();
	  this.firstNameText = new System.Windows.Forms.TextBox();
	  this.surNameText = new System.Windows.Forms.TextBox();
	  this.Registration = new System.Windows.Forms.Button();
	  this.IsEmployeeReg = new System.Windows.Forms.CheckBox();
	  this.authTabs.SuspendLayout();
	  this.loginTab.SuspendLayout();
	  this.registrationTab.SuspendLayout();
	  this.SuspendLayout();
	  // 
	  // authTabs
	  // 
	  this.authTabs.Controls.Add(this.loginTab);
	  this.authTabs.Controls.Add(this.registrationTab);
	  this.authTabs.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.authTabs.Location = new System.Drawing.Point(0, 0);
	  this.authTabs.Name = "authTabs";
	  this.authTabs.SelectedIndex = 0;
	  this.authTabs.Size = new System.Drawing.Size(800, 450);
	  this.authTabs.TabIndex = 0;
	  // 
	  // loginTab
	  // 
	  this.loginTab.Controls.Add(this.IsEmployee);
	  this.loginTab.Controls.Add(this.Login);
	  this.loginTab.Controls.Add(this.passwordText);
	  this.loginTab.Controls.Add(this.loginText);
	  this.loginTab.Location = new System.Drawing.Point(4, 22);
	  this.loginTab.Name = "loginTab";
	  this.loginTab.Padding = new System.Windows.Forms.Padding(3);
	  this.loginTab.Size = new System.Drawing.Size(792, 424);
	  this.loginTab.TabIndex = 0;
	  this.loginTab.Text = "Вход";
	  this.loginTab.UseVisualStyleBackColor = true;
	  // 
	  // IsEmployee
	  // 
	  this.IsEmployee.AutoSize = true;
	  this.IsEmployee.Location = new System.Drawing.Point(248, 205);
	  this.IsEmployee.Name = "IsEmployee";
	  this.IsEmployee.Size = new System.Drawing.Size(79, 17);
	  this.IsEmployee.TabIndex = 3;
	  this.IsEmployee.Text = "Сотрудник";
	  this.IsEmployee.UseVisualStyleBackColor = true;
	  // 
	  // Login
	  // 
	  this.Login.Location = new System.Drawing.Point(248, 228);
	  this.Login.Name = "Login";
	  this.Login.Size = new System.Drawing.Size(275, 23);
	  this.Login.TabIndex = 2;
	  this.Login.Text = "Войти";
	  this.Login.UseVisualStyleBackColor = true;
	  this.Login.Click += new System.EventHandler(this.Login_Click);
	  // 
	  // passwordText
	  // 
	  this.passwordText.Location = new System.Drawing.Point(248, 170);
	  this.passwordText.Name = "passwordText";
	  this.passwordText.Size = new System.Drawing.Size(275, 20);
	  this.passwordText.TabIndex = 1;
	  this.passwordText.Text = "Пароль";
	  // 
	  // loginText
	  // 
	  this.loginText.Location = new System.Drawing.Point(248, 135);
	  this.loginText.Name = "loginText";
	  this.loginText.Size = new System.Drawing.Size(275, 20);
	  this.loginText.TabIndex = 0;
	  this.loginText.Text = "Логин";
	  // 
	  // registrationTab
	  // 
	  this.registrationTab.Controls.Add(this.IsEmployeeReg);
	  this.registrationTab.Controls.Add(this.Registration);
	  this.registrationTab.Controls.Add(this.phoneText);
	  this.registrationTab.Controls.Add(this.passwordRegText);
	  this.registrationTab.Controls.Add(this.loginRegText);
	  this.registrationTab.Controls.Add(this.firstNameText);
	  this.registrationTab.Controls.Add(this.surNameText);
	  this.registrationTab.Location = new System.Drawing.Point(4, 22);
	  this.registrationTab.Name = "registrationTab";
	  this.registrationTab.Padding = new System.Windows.Forms.Padding(3);
	  this.registrationTab.Size = new System.Drawing.Size(792, 424);
	  this.registrationTab.TabIndex = 1;
	  this.registrationTab.Text = "Регистрация";
	  this.registrationTab.UseVisualStyleBackColor = true;
	  // 
	  // phoneText
	  // 
	  this.phoneText.Location = new System.Drawing.Point(267, 231);
	  this.phoneText.Mask = "(999) 000-0000";
	  this.phoneText.Name = "phoneText";
	  this.phoneText.Size = new System.Drawing.Size(225, 20);
	  this.phoneText.TabIndex = 4;
	  // 
	  // passwordRegText
	  // 
	  this.passwordRegText.Location = new System.Drawing.Point(267, 119);
	  this.passwordRegText.Name = "passwordRegText";
	  this.passwordRegText.Size = new System.Drawing.Size(225, 20);
	  this.passwordRegText.TabIndex = 3;
	  this.passwordRegText.Text = "Пароль";
	  // 
	  // loginRegText
	  // 
	  this.loginRegText.Location = new System.Drawing.Point(267, 82);
	  this.loginRegText.Name = "loginRegText";
	  this.loginRegText.Size = new System.Drawing.Size(225, 20);
	  this.loginRegText.TabIndex = 2;
	  this.loginRegText.Text = "Логин";
	  // 
	  // firstNameText
	  // 
	  this.firstNameText.Location = new System.Drawing.Point(267, 193);
	  this.firstNameText.Name = "firstNameText";
	  this.firstNameText.Size = new System.Drawing.Size(225, 20);
	  this.firstNameText.TabIndex = 1;
	  this.firstNameText.Text = "Имя";
	  // 
	  // surNameText
	  // 
	  this.surNameText.Location = new System.Drawing.Point(267, 156);
	  this.surNameText.Name = "surNameText";
	  this.surNameText.Size = new System.Drawing.Size(225, 20);
	  this.surNameText.TabIndex = 0;
	  this.surNameText.Text = "Фамилия";
	  // 
	  // Registration
	  // 
	  this.Registration.Location = new System.Drawing.Point(267, 303);
	  this.Registration.Name = "Registration";
	  this.Registration.Size = new System.Drawing.Size(225, 23);
	  this.Registration.TabIndex = 5;
	  this.Registration.Text = "Регистрация";
	  this.Registration.UseVisualStyleBackColor = true;
	  this.Registration.Click += new System.EventHandler(this.Registration_Click);
	  // 
	  // IsEmployeeReg
	  // 
	  this.IsEmployeeReg.AutoSize = true;
	  this.IsEmployeeReg.Location = new System.Drawing.Point(267, 269);
	  this.IsEmployeeReg.Name = "IsEmployeeReg";
	  this.IsEmployeeReg.Size = new System.Drawing.Size(79, 17);
	  this.IsEmployeeReg.TabIndex = 6;
	  this.IsEmployeeReg.Text = "Сотрудник";
	  this.IsEmployeeReg.UseVisualStyleBackColor = true;
	  // 
	  // Auth
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(800, 450);
	  this.Controls.Add(this.authTabs);
	  this.Name = "Auth";
	  this.Text = "Форма Автризации";
	  this.authTabs.ResumeLayout(false);
	  this.loginTab.ResumeLayout(false);
	  this.loginTab.PerformLayout();
	  this.registrationTab.ResumeLayout(false);
	  this.registrationTab.PerformLayout();
	  this.ResumeLayout(false);

	}

	#endregion

	private System.Windows.Forms.TabControl authTabs;
	private System.Windows.Forms.TabPage loginTab;
	private System.Windows.Forms.Button Login;
	private System.Windows.Forms.TextBox passwordText;
	private System.Windows.Forms.TextBox loginText;
	private System.Windows.Forms.TabPage registrationTab;
	private System.Windows.Forms.CheckBox IsEmployee;
	private System.Windows.Forms.TextBox firstNameText;
	private System.Windows.Forms.TextBox surNameText;
	private System.Windows.Forms.MaskedTextBox phoneText;
	private System.Windows.Forms.TextBox passwordRegText;
	private System.Windows.Forms.TextBox loginRegText;
	private System.Windows.Forms.Button Registration;
	private System.Windows.Forms.CheckBox IsEmployeeReg;
  }
}

