using ComputerShop.Entities;
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
  public partial class AddedGoodsForm : Form
  {
	private List<Goods> _goods = new List<Goods>();
	private List<Category> _categories = new List<Category>();

	private IFileManager _fileManager = new FileManager();
	private readonly Goods _updateGoods;
	private readonly User _user;

	
	public AddedGoodsForm()
	{
	  InitializeComponent();
	}

	/// <summary>
	/// Конструктор с параметрами формы добавления
	/// </summary>
	/// <param name="updateGoods">Модель для обновления</param>
	/// <param name="user">Текущий пользователь</param>
	public AddedGoodsForm(Goods updateGoods, User user)
	{
	  InitializeComponent();
	  _updateGoods = updateGoods;
	  _user = user;
	  productName.Text = _updateGoods.Name;
	  price.Value = _updateGoods.Price;
	}

	/// <summary>
	/// Событие на загрузку формы
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void AddedGoodsForm_Load(object sender, EventArgs e)
	{
	  //Считывание товаров в системе
	  _categories = await _fileManager.ReadFile<Category>("categories.json");

	  //Добавление элементов в listVIew
	  categoriesList.DisplayMember = "Name";
	  _categories.ForEach(x => categoriesList.Items.Add(x));

	  //заполнение дропдауна, в соответствии с обновляемым обьектом1
	  categoriesList.SelectedItem = _categories.FirstOrDefault(x => x.ID == _updateGoods.CategoryID);
	}

	/// <summary>
	/// Добавление товара
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void AddedGoodsBtn_Click(object sender, EventArgs e)
	{
	  //Получение выбранной категории товара из дропдауна
	  var category = (Category)categoriesList.SelectedItem;

	  //Проверка полей на заполнение 
	  if ((category != null 
		&& category.Name != null)
		|| !string.IsNullOrWhiteSpace(productName.Text))
	  {
		//Обновление или добавление товара
		if (_updateGoods == null)
		{
		  //Создание нового обьекта
		  var goods = new Goods
		  {
			Name = productName.Text,
			Price = price.Value,
			Category = category.Name,
			CategoryID = category.ID
		  };

		  //Добавление обьекта
		  await _fileManager.AddOrUpdateItem("goods.json", goods);
		}
		else
		{
		  //Обновление обьекта
		  _updateGoods.Name = productName.Text;
		  _updateGoods.Price = price.Value;
		  _updateGoods.Category = category.Name;
		  _updateGoods.CategoryID = category.ID;

		  await _fileManager.AddOrUpdateItem("goods.json", _updateGoods);
		}

		//Переход на главную форму
		var shopForm = new Shop(_user);
		shopForm.Show();
		this.Close();
	  }
	}
  }
}
