using System;

namespace ComputerShop.Entities
{
  /// <summary>
  /// Базовая модель
  /// </summary>
  public class GenericModel
  {
	public Guid ID { get; set; } = Guid.NewGuid();
  }
}