using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Services.Manager
{
  public class LoggerManager : ILoggerManager
  {
	/// <summary>
	/// Путь в корень приложения
	/// </summary>
	private string _path = Path.Combine(Directory.GetCurrentDirectory());

	/// <summary>
	/// Метод записи логов
	/// </summary>
	/// <param name="message">Сообщение для записи</param>
	public void WriteLog(string message)
	{
	  try
	  {
		using (StreamWriter sw = File.AppendText(_path + "\\" + "log.txt"))
		{
		  Log(message, sw);
		}
	  }
	  catch (Exception ex)
	  {
		Debugger.Break();
	  }
	}

	/// <summary>
	/// Формирование лога
	/// </summary>
	/// <param name="logMessage">Лог для записи</param>
	/// <param name="txtWriter">Способ записи</param>
	private void Log(string logMessage, TextWriter txtWriter)
	{
	  try
	  {
		txtWriter.Write("\r\nLog Entry : ");
		txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
			DateTime.Now.ToLongDateString());
		txtWriter.WriteLine("  :");
		txtWriter.WriteLine("  :{0}", logMessage);
		txtWriter.WriteLine("-------------------------------");
	  }
	  catch (Exception ex)
	  {
	  }
	}
  }
}
