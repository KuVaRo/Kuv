using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Entities
{
  /// <summary>
  /// Модель товара
  /// </summary>
  public class Goods : GenericModel
  {
	public string Name { get; set; }

	public decimal Price { get; set; }

	public string Category { get; set; }

	public Guid CategoryID { get; set; }
  }
}
