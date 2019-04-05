using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Services
{
  public interface ILoggerManager
  {
	void WriteLog(string message);
  }
}
