using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Entities
{
  /// <summary>
  /// Модель заказа
  /// </summary>
  public class Order : GenericModel
  {
	public string Employee { get; set; }

	public Guid EmployeeID { get; set; }

	public string Client { get; set; }

	public Guid ClientID { get; set; }

	public string Goods { get; set; }

	public Guid GoodsID { get; set; }

	public decimal TotalPrice { get; set; }

	public decimal Count { get; set; }

	public bool IsDone { get; set; } = false;
  }
}
