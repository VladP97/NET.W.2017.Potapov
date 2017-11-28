using Microsoft.VisualStudio.TestTools.UnitTesting;
using XML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML.Tests
{
    [TestClass()]
    public class UrlXMLFormatterTests
    {
        [TestMethod()]
        public void CreateNewXMLFile()
        {
            UrlXMLFormatter uxf = new UrlXMLFormatter("test.xml", "test.txt");
        }
    }
}