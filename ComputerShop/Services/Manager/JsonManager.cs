using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Services.Manager
{
  public class JsonManager : IJsonManager
  {
	private readonly ILoggerManager _loggerManager = new LoggerManager();

	/// <summary>
	/// Метод десериализации обьекта
	/// </summary>
	/// <typeparam name="T">Тип обьекта</typeparam>
	/// <param name="json">JSON для десериализации</param>
	/// <returns>Десериализованный обьект</returns>
	public T DeserializeObject<T>(string json)
	{
	  try
	  {
		return JsonConvert.DeserializeObject<T>(json);
	  }
	  catch (Exception ex)
	  {
		_loggerManager.WriteLog(ex.Message);
		throw;
	  }
	}

	/// <summary>
	/// Метод для сериализации обьекта
	/// </summary>
	/// <typeparam name="T">Тип обьекта</typeparam>
	/// <param name="value">Обьект для сериализации</param>
	/// <returns>JSON</returns>
	public string SerializeObject<T>(T value)
	{
	  try
	  {
		return JsonConvert.SerializeObject(value);
	  }
	  catch (Exception ex)
	  {
		_loggerManager.WriteLog(ex.Message);
		throw;
	  }
	}
  }
}
