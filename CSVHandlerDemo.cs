using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;

namespace FileIODemo
{
    public class CSVHandlerDemo
    {
        public void ImplementCSVDataHandling()
        {
            string importFilePath = "J:\\240\\FileIODemo\\FileIODemo\\ExampleAddress.csv";
            string exportFilePath = "J:\\240\\FileIODemo\\FileIODemo\\CopyExampleAddress.csv";
            string jsonexportFilePath = "J:\\240\\FileIODemo\\FileIODemo\\JsonDataAddress.json";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))    
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read Data succesfully from ExampleAddress.csv");

                foreach (AddressData addressData in records) 
                {
                    Console.WriteLine(addressData.name);
                    Console.WriteLine(addressData.phone);
                    Console.WriteLine(addressData.email);
                    Console.WriteLine(addressData.country);
                    Console.WriteLine("------------------");
                }

                //Console.WriteLine("***************Now reading from csv file and write to csv file****************");

                //using (var writer = new StreamWriter(exportFilePath))
                //using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                //{
                //    csvExport.WriteRecords(records);
                //}

                Console.WriteLine("***************Now reading from csv file and write to json file****************");

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(jsonexportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw) )    
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
