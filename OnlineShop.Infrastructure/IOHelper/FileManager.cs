using CsvHelper;
using CsvHelper.Configuration;
using OnlineShop.Domain.ModelForCSV;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace OnlineShop.Infrastructure.IOHelper
{
    public class FileManager
    {
        public string Path { get; set; }

        public void WriteDataToCSV<T>(IList<T> data)
        {
            var pathToFile = SetFileRelatedToDataType(data);

            CheckIsFileExists<T>(pathToFile);

            using (var stream = File.Open(pathToFile, FileMode.Append))
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

        public IList<T> ReadDataFromCSV<T>(string path, IList<T> result)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = (string header, int index) => header.ToLower(),
                HasHeaderRecord = true
            };

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, config))
                {
                    while (csv.Read())
                    {
                        var value = csv.GetRecord<T>();
                        result.Add(value);
                    }
                }
                return result;
            }
            else
            {
                return null;
            }
        }

        public void CheckIsFileExists<T>(string pathToFile)
        {
            if (!File.Exists(pathToFile))
            {
                using (var writer = File.CreateText(pathToFile))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<T>();
                    csv.NextRecord();
                }
            }
        }

        private string SetFileRelatedToDataType<T>(IList<T> data)
        {
            var relatedPath = new StringBuilder(Path);
            if (data is List<CameraCSV>)
            {
                relatedPath.Append("\\Seed\\Camera.csv");
            }
            else if (data is List<HardwareCSV>)
            {
                relatedPath.Append("\\Seed\\Hardware.csv");
            }
            else if (data is List<ScreenCSV>)
            {
                relatedPath.Append("\\Seed\\Screen.csv");
            }
            else if (data is List<MobilePhoneCSV>)
            {
                relatedPath.Append("\\Seed\\MobilePhone.csv");
            }
            return relatedPath.ToString();
        }
    }
}
