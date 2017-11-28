using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    public class UrlXMLFormatter
    {
        private string path;

        public UrlXMLFormatter(string path, string url)
        {
            this.path = path;
            XDocument newDocument = new XDocument();
            Regex reg = new Regex(@"(\w+)://(\w+.\w+)/(.*)\?(.*)");
            Match mc = reg.Match(url);
            string scheme = mc.Groups[1].Value;
            string host = mc.Groups[2].Value;
            string URLpath = mc.Groups[3].Value;
            string parameters = null;
            if (mc.Groups[4].Value != "")
            {
                parameters = mc.Groups[4].Value;
            }
            string[] keyValueParametrs = parameters.Split('=','&');
            XElement root = new XElement("URL");
            XAttribute attr = new XAttribute("host", host);
            XElement elementScheme = new XElement("scheme",scheme);
            XElement elementURL = new XElement("URLpath", URLpath);
            XElement elementParameter = new XElement("parameters");
            root.Add(attr);
            root.Add(elementScheme);
            root.Add(elementURL);
            for (int i = 0; i < keyValueParametrs.Length / 2; i++)
            {
                XAttribute parameterAttr = new XAttribute(keyValueParametrs[0], keyValueParametrs[1]);
                elementParameter.Add(parameterAttr);
            }
            root.Add(elementParameter);
            newDocument.Add(root);
            newDocument.Save(path);
        }
    }
}
