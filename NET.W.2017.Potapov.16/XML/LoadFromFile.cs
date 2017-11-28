using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public interface ILoadFromFile
    {
        string[] GetStringsFromFile(string path);
    }
}
