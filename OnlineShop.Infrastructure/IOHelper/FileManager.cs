using CsvHelper;
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
            path = ".\\Seed\\TextFile2.txt";
        }

        public void WriteDataToCSV<T>(IList<T> data)
        {
            using (var writer = File.CreateText(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteHeader<T>();
                csv.NextRecord();
                foreach (var record in data)
                {
                    csv.WriteRecord(record);
                    csv.NextRecord();
                }
            }
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
