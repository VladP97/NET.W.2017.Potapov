using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML
{
    public class UrlXMLFormatter : ILoadFromFile
    {
        private string path;

        public UrlXMLFormatter(string xmlPath, string pathToFile)
        {
            path = xmlPath;
            XDocument newDocument = new XDocument();
            Regex reg1 = new Regex(@"(\w+)://(\w+.\w+)/(.*)\?(.*)");
            Regex reg2 = new Regex(@"(\w+)://(\w+.\w+)/(.*)");
            string[] urls = GetStringsFromFile(pathToFile);
            XElement URLS = new XElement("URLS");
            for (int j = 0; j < urls.Length - 1; j++)
            {
                Match mc = reg1.Match(urls[j]);
                if (!mc.Success)
                {
                    mc = reg2.Match(urls[j]);
                }
                string scheme = mc.Groups[1].Value;
                string host = mc.Groups[2].Value;
                string URLpath = mc.Groups[3].Value;
                string parameters = "";
                XElement elementUrl = new XElement("URL");
                XAttribute attr = new XAttribute("host", host);
                XElement elementScheme = new XElement("scheme", scheme);
                XElement elementURL = new XElement("URLpath", URLpath);
                XElement elementParameter = new XElement("parameters");
                elementUrl.Add(attr);
                elementUrl.Add(elementScheme);
                elementUrl.Add(elementURL);
                if (mc.Groups[4].Value != "")
                {
                    parameters = mc.Groups[4].Value;
                    string[] keyValueParametrs = parameters.Split('=', '&');
                    for (int i = 0; i < keyValueParametrs.Length / 2; i++)
                    {
                        XAttribute parameterAttr = new XAttribute(keyValueParametrs[0], keyValueParametrs[1]);
                        elementParameter.Add(parameterAttr);
                    }
                }

                elementUrl.Add(elementParameter);
                Console.WriteLine(elementUrl);
                URLS.Add(elementUrl);
            }
            newDocument.Add(URLS);
            newDocument.Save(path);
        }

        public string[] GetStringsFromFile(string path)
        {
            string stringFromFile;
            using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                stringFromFile = sr.ReadToEnd();
            }
            return stringFromFile.Split('\n');
        }
    }
}
