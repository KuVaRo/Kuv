using ComputerShop.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Services.Manager
{
  public class FileManager : IFileManager
  {
	private string _path = Path.Combine(Directory.GetCurrentDirectory());
	private readonly IJsonManager _jsonManager = new JsonManager();
	private readonly ILoggerManager _loggerManager = new LoggerManager();

	/// <summary>
	/// Удаленеи одного элемента
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <param name="item"></param>
	/// <returns></returns>
	public async Task<List<T>> DeleteItem<T>(string fileName, T item) where T : GenericModel
	{
	  try
	  {
		//Получение всех элементов
		var data = await ReadFile<T>(fileName);
		//Обьект для удаления
		var deleting = data.FirstOrDefault(x => x.ID == item.ID);
		if (deleting == null)
		{
		  return data;
		}

		//Удаление обьекта
		data.Remove(deleting);
		//Запись обновленной коллекции
		WriteFile(fileName, data);

		return data;
	  }
	  catch (Exception ex)
	  {
		_loggerManager.WriteLog(ex.Message);
		return new List<T>();
	  }
	}

	/// <summary>
	/// Считывание данных из файла
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <returns></returns>
	public async Task<List<T>> ReadFile<T>(string fileName) where T : GenericModel
	{
	  try
	  {
		//Получение JSON`а из файла
		var json = File.ReadAllText(GetPath(fileName));
		//Преобразование JSON в тип T
		var data = _jsonManager.DeserializeObject<List<T>>(json);

		return data != null ? data : new List<T>();
	  }
	  catch (Exception ex)
	  {
		_loggerManager.WriteLog(ex.Message);
		return new List<T>();
	  }
	}

	/// <summary>
	/// Добавление или обновление обьекта
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <param name="item"></param>
	/// <returns></returns>
	public async Task<List<T>> AddOrUpdateItem<T>(string fileName, T item) where T : GenericModel
	{
	  try
	  {
		var data = await ReadFile<T>(fileName);
		//Поиск обьекта по ключу
		var finded = data.FirstOrDefault(x => x.ID == item.ID);
		if (finded != null)
		{
		  //Обновление обьекта
		  data.Remove(finded);
		  data.Add(item);
		}
		else
		{
		  //Добавление обьекта
		  data.Add(item);
		}

		//Запись обновленной коллекции
		WriteFile(fileName, data);

		return data != null ? data : new List<T>();
	  }
	  catch (Exception ex)
	  {
		_loggerManager.WriteLog(ex.Message);
		return new List<T>();
	  }
	}

	/// <summary>
	/// Запись данных в файл
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="fileName"></param>
	/// <param name="value"></param>
	public async void WriteFile<T>(string fileName, List<T> value) where T : GenericModel
	{
	  try
	  {
		//Преобразование обьекта T в JSON
		var json = _jsonManager.SerializeObject(value);
		//Запись в файл
		File.WriteAllText(GetPath(fileName), json);
	  }
	  catch (Exception ex)
	  {
		_loggerManager.WriteLog(ex.Message);
		throw;
	  }
	}

	/// <summary>
	/// Получение пути
	/// </summary>
	/// <param name="fileName">Имя файла</param>
	/// <returns></returns>
	private string GetPath(string fileName)
	{
	  //Путь + имя файла
	  var path = Path.Combine(_path, fileName);
	  //Если нет директории, то она создается
	  if (!Directory.Exists(_path))
	  {
		Directory.CreateDirectory(_path);
	  }

	  //Если нет файла, то она создается
	  if (!File.Exists(path))
	  {
		File.Create(path);
	  }

	  return path;
	}
  }
}
