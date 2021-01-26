using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace OnlineShop.Infrastructure.IOHelper
{
    public class FileManager
    {
        public string path { get; set; }

        public FileManager()
        {
            path = "..\\..\\..\\OnlineShop.Web\\wwwroot\\seed\\TextFile2.txt";
        }

        public void WriteDataToCSV<T>(IList<T> data)
        {
            if (!IsFileExist())
            {
                CreateFile();
            }

            //using (var writer = new StreamWriter(path))
            //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            //{
            //    csv.WriteHeader<T>();
            //    csv.NextRecord();
            //    foreach (var record in data)
            //    {
            //        csv.WriteRecord(record);
            //        csv.NextRecord();
            //    }
            //}
        }

        public void CreateFile()
        {
            File.Create(path);
        }

        public bool IsFileExist()
        {
            return File.Exists(path);
        }
    }
}
