using ComputerShop.Entities;
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
  public partial class Users : Form
  {
	private readonly List<User> _users;

	public Users(List<User> users)
	{
	  InitializeComponent();
	  _users = users;
	}

	private void Users_Load(object sender, EventArgs e)
	{
	  _users.ForEach(x =>
	  {
		ListViewItem item = new ListViewItem();
		item.Text = $"{x.ID}, Пользователь: {x.SecondName} {x.FirtsName}, Логин: {x.Login}, Телефон: {x.Phone}, Роль: {x.Role}";
		item.Tag = x;

		usersList.Items.Add(item);
	  });
	}
  }
}
