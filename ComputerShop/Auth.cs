using ComputerShop.Entities;
using ComputerShop.Entities.Enums;
using ComputerShop.Services;
using ComputerShop.Services.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
  public partial class Auth : Form
  {
	private IFileManager _fileManager = new FileManager();

	public Auth()
	{
	  InitializeComponent();
	}

	//Вход в приложение
	private async void Login_Click(object sender, EventArgs e)
	{
	  //Выбор файла в зависимости от типа пользователя1
	  var fileName = IsEmployee.Checked ? "employees.json" : "clients.json";

	  //Поиск пользователя по логину и паролю
	  var users = await _fileManager.ReadFile<User>(fileName);

	  var user = users.FirstOrDefault(x => x.Login == loginText.Text
									   && x.Password == passwordText.Text);

	  //Проверка правильности введенных данных
	  if (user != null)
	  {
		var shopForm = new Shop(user);
		this.Hide();
		shopForm.Show();
	  }
	  else
	  {
		loginText.Text = "Неверные данные";
		passwordText.Text = "Пароль";
	  }
	}

	/// <summary>
	/// Регистрация нового пользователя
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void Registration_Click(object sender, EventArgs e)
	{
	  //Проверка заполненности полей
	  if (!string.IsNullOrWhiteSpace(loginRegText.Text)
		|| !string.IsNullOrWhiteSpace(passwordRegText.Text)
		|| !string.IsNullOrWhiteSpace(firstNameText.Text)
		|| !string.IsNullOrWhiteSpace(surNameText.Text)
		|| !string.IsNullOrWhiteSpace(phoneText.Text))
	  {
		//Создание пользователя
		var user = new User
		{
		  Login = loginRegText.Text,
		  Password = passwordRegText.Text,
		  Phone = phoneText.Text,
		  FirtsName = firstNameText.Text,
		  SecondName = surNameText.Text
		};

		//Добавление пользователей в файлы
		var fileName = IsEmployeeReg.Checked ? "employees.json" : "clients.json";
		if (IsEmployeeReg.Checked)
		{
		  user.Role = Roles.Manager;
		  await _fileManager.AddOrUpdateItem(fileName, user);
		}
		else
		{
		  await _fileManager.AddOrUpdateItem(fileName, user);
		}

		var shopForm = new Shop(user);
		this.Hide();
		shopForm.Show();
	  }
	}
  }
}
