using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Services
{
  public interface IJsonManager
  {
	string SerializeObject<T>(T value);

	T DeserializeObject<T>(string json);
  }
}
