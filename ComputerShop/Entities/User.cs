using ComputerShop.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Entities
{
  /// <summary>
  /// Базовая модель пользователя
  /// </summary>
  public class User : GenericModel
  {
	public string FirtsName { get; set; }

	public string SecondName { get; set; }

	public string Phone { get; set; }

	public Roles Role { get; set; } = Roles.User;

	public string Login { get; set; }

	public string Password { get; set; }
  }
}
