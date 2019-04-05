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
  public partial class Shop : Form
  {
	private IFileManager _fileManager = new FileManager();
	private ILoggerManager _loggerManager = new LoggerManager();
	private readonly User _user;
	private bool _isEmployee = false;

	//Инициализация формы, выдача прав пользователю
	public Shop(User user)
	{
	  InitializeComponent();
	  _isEmployee = user.Role != Roles.User;
	  AddGoods.Visible = _isEmployee;
	  updateGoods.Visible = _isEmployee;
	  RemoveGoods.Visible = _isEmployee;
	  DoneOrders.Visible = _isEmployee;
	  GetEmployees.Visible = _isEmployee;
	  GetClients.Visible = _isEmployee;
	  GetOrders.Visible = _isEmployee;
	  CreateOrder.Visible = !_isEmployee;
	  goodsCount.Visible = !_isEmployee;
	  _user = user;
	}

	private async void Shop_Load(object sender, EventArgs e)
	{
	  //Получение заказов и товаров
	  var orders = await _fileManager.ReadFile<Order>("orders.json");
	  var goods = await _fileManager.ReadFile<Goods>("goods.json");

	  //Заполнение listView
	  goods.ForEach(x =>
	  {
		var item = new ListViewItem();
		item.Text = $"{x.Category}, {x.Name} - {x.Price}";
		item.Tag = x;

		goodsList.Items.Add(item);
	  });

	  if (!_isEmployee)
	  {
		orders.Where(x => x.ClientID == _user.ID).ToList().ForEach(x =>
		{
		  var item = new ListViewItem();
		  item.Text = $"{x.Goods}, Количество: {x.Count}, Ценна: {x.TotalPrice}, Выполнен: {x.IsDone.ToString()}";
		  item.Tag = x;

		  orderList.Items.Add(item);
		});
	  }
	  else
	  {
		orders.Where(x => !x.IsDone).ToList().ForEach(x =>
		{
		  var item = new ListViewItem();
		  item.Text = $"{x.Goods}, Количество: {x.Count}, Ценна: {x.TotalPrice}, Выполнен: {x.IsDone.ToString()}";
		  item.Tag = x;

		  orderList.Items.Add(item);
		});
	  }
	}

	//Переход на форму добавления товара
	private void AddGoods_Click(object sender, EventArgs e)
	{
	  var addedForm = new AddedGoodsForm();
	  addedForm.Show();
	  this.Close();
	}

	//Удаление товара
	private async void RemoveGoods_Click(object sender, EventArgs e)
	{
	  //Считывание выбранного товара
	  var selectedItem = goodsList.SelectedItems[0];
	  var goods = (Goods)selectedItem.Tag;

	  //Удаление из файла
	  await _fileManager.DeleteItem("goods.json", goods);
	  //Удаление из интерфейса
	  goodsList.SelectedItems[0].Remove();
	}

	//Обновление выбранного товара
	private void updateGoods_Click(object sender, EventArgs e)
	{
	  try
	  {
		var selectedItem = goodsList.SelectedItems[0];
		var goods = (Goods)selectedItem.Tag;

		//Передача на форму добавления
		var addedForm = new AddedGoodsForm(goods, _user);
		addedForm.Show();
		this.Close();
	  }
	  catch (Exception ex)
	  {
		_loggerManager.WriteLog(ex.Message);
		return;
	  }
	}

	//Сделать заказ
	private async void CreateOrder_Click(object sender, EventArgs e)
	{
	  try
	  {
		//Считывание выбраного товара
		var selectedItem = goodsList.SelectedItems[0];
		var goods = (Goods)selectedItem.Tag;

		var count = goodsCount.Value;
		//Создание заказа
		var order = new Order
		{
		  Client = $"{_user.SecondName} {_user.FirtsName}",
		  ClientID = _user.ID,
		  GoodsID = goods.ID,
		  Goods = goods.Name,
		  Count = count,
		  TotalPrice = count * goods.Price
		};

		await _fileManager.AddOrUpdateItem("orders.json", order);

		//Добавление позиции в интерфейс
		var item = new ListViewItem();
		item.Text = $"{order.Goods}, Количество: {order.Count}, Ценна: {order.TotalPrice}, Выполнен: {order.IsDone.ToString()}";
		item.Tag = order;

		//Запись лога о добавленном товаре
		_loggerManager.WriteLog($"Оформлен заказ - {order.ID}");
		//Сообщение пользователю
		orderStatus.Text = "Заказ оформлен";
		orderList.Items.Add(item);
	  }
	  catch (Exception ex)
	  {
		_loggerManager.WriteLog(ex.Message);
		orderStatus.Text = "Произошла ошибка";
		return;
	  }
	}

	//Заказ оформлен, выставляется сотрудниками
	private async void DoneOrders_Click(object sender, EventArgs e)
	{
	  try
	  {
		//Считывание выбранных заказов
		var selectedItems = orderList.SelectedItems;
		//Передор товаров
		foreach (ListViewItem item in selectedItems)
		{
		  //Обновление статусов заказов
		  var order = (Order)item.Tag;
		  order.EmployeeID = _user.ID;
		  order.Employee = $"{_user.SecondName} {_user.FirtsName}";
		  order.IsDone = true;

		  await _fileManager.AddOrUpdateItem("orders.json", order);

		  var index = orderList.Items.IndexOf(item);
		  orderList.Items[index].Text = $"{order.Goods}, Количество: {order.Count}, Ценна: {order.TotalPrice}, Выполнен: {order.IsDone.ToString()}";
		  orderList.Items[index].Tag = order;

		  //Внесение логов
		  _loggerManager.WriteLog($"Выполнен заказ - {order.ID}");
		}
	  }
	  catch (Exception ex)
	  {
		_loggerManager.WriteLog(ex.Message);
		throw;
	  }
	}

	//Открывает форму клиентов, выводит подробную  информацию
	private async void GetClients_Click(object sender, EventArgs e)
	{
	  var clients = await _fileManager.ReadFile<User>("clients.json");
	  var usersForm = new Users(clients);
	  usersForm.Show();
	}

	private async void GetEmployees_Click(object sender, EventArgs e)
	{
	  var employees = await _fileManager.ReadFile<User>("employees.json");
	  var usersForm = new Users(employees);
	  usersForm.Show();
	}

	private async void GetOrders_Click(object sender, EventArgs e)
	{
	  var orders = await _fileManager.ReadFile<Order>("orders.json");
	  var orderForm = new Orders(orders);
	  orderForm.Show();
	}
  }
}
