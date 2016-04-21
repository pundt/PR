using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BL_pundt
{
    public class WebSite
    {
        private string url;
        private readonly string content;
        private readonly string fileName;

        public string Content
        {
            get { return content; }
        }

        public string FileName
        {
            get
            {
                return fileName;
            }
        }


        public string URL
        {
            get { return url; }
            set { if (!string.IsNullOrEmpty(value)) url = value; }
        }

        public WebSite(string url)
        {
            this.URL = url;
            this.content = LoadContent();
            this.fileName = url;

            foreach (var invalidChar in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(invalidChar, '_');
            }

            this.fileName =  Path.ChangeExtension(fileName, ".html");
        }

        private string LoadContent()
        {
            Debug.WriteLine("LoadContent");
            Debug.Indent();

            string content = string.Empty;
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    WebClient client = new WebClient();
                    content = client.DownloadString(url);
                    Debug.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error");
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                throw new Exception("Please provide a valid URL");
            }
            Debug.Unindent();
            return content;
        }
    }
}
