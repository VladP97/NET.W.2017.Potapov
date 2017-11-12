using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public interface IParamsStringFormatter
	{
		string ToString(params string[] paramsToGenerateString);
	}
}
