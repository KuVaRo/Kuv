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
  public partial class Orders : Form
  {
	private readonly List<Order> _orders;

	public Orders(List<Order> orders)
	{
	  InitializeComponent();
	  _orders = orders;
	}

	//Событие на 
	private void Orders_Load(object sender, EventArgs e)
	{
	  //Заполнение listView
	  _orders.ForEach(x =>
	  {
		ListViewItem item = new ListViewItem();
		item.Text = $"{x.ID}, Клиент: {x.Client}, Сотрудник: {x.Employee}, Товар: {x.Goods}, Количество: {x.Count}, Цена: {x.TotalPrice}";
		item.Tag = x;

		OrdersList.Items.Add(item);
	  });
	}
  }
}
