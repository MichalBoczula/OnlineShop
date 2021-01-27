using CsvHelper;
using OnlineShop.Domain.ModelForCSV;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace OnlineShop.Infrastructure.IOHelper
{
    public class FileManager
    {
        public StringBuilder path { get; set; }

        public void WriteDataToCSV<T>(IList<T> data)
        {
            if (data[0] is CameraCSV)
            {
                path.Append("\\Seed\\Camera.csv");
            }
            else if (data[0] is HardwareCSV)
            {
                path.Append("\\Seed\\Hardware.csv");
            }
            else if (data[0] is ScreenCSV)
            {
                path.Append("\\Seed\\Screen.csv");
            }
            else if (data[0] is MobilePhoneCSV)
            {
                path.Append("\\Seed\\MobilePhone.csv");
            }

            CheckIsFileExists<T>();

            using (var stream = File.Open(path.ToString(), FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                foreach (var record in data)
                {
                    csv.WriteRecord(record);
                    csv.NextRecord();
                }
            }
        }

        public void CheckIsFileExists<T>()
        {
            if (!File.Exists(path.ToString()))
            {
                using (var writer = File.CreateText(path.ToString()))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<T>();
                    csv.NextRecord();
                }
            }
        }
    }
}
