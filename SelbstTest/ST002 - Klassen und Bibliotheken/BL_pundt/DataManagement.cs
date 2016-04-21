using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_pundt
{
    public class DataManagement
    {
        private readonly string path;

        /// <summary>
        /// Manages Data on a given path
        /// </summary>
        /// <param name="path">path where the *.csv file can be found</param>
        public DataManagement(string path)
        {
            this.path = path;
        }

        public List<string> ReadCSV()
        {
            List<string> data = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                try
                {
                    while (reader.Peek() != -1)
                    {
                        data.Add(reader.ReadLine());
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occured!");
                    Debug.WriteLine(ex.Message);
                }
            }

            return data;
        }

        public bool WriteCSV(List<string> data)
        {
            bool succces = false;

            using (StreamWriter writer = new StreamWriter(path))
            {
                try
                {
                    foreach (var row in data)
                    {
                        writer.WriteLine(row);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An error occured!");
                    Debug.WriteLine(ex.Message);
                }
            }

            return succces;
        }
    }
}
