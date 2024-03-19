using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace zapisywaneListy
{
    public class Zapisywanie
    {
        public static string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "zapisywanie.txt");
        public static List<Produkt> ReadData()
        {
            if(File.Exists(fileName))
            {
                List<string> lines = File.ReadAllLines(fileName).ToList();
                List<Produkt> result = new List<Produkt>();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');
                    if(parts.Length == 3) { 
                        Produkt produkt = new Produkt();
                        produkt.Nazwa = parts[0];
                        produkt.Cena = int.Parse(parts[1]);
                        produkt.Ilosc = int.Parse(parts[2]);

                        result.Add(produkt);    
                    }
                }
                return result;
            }
            else
            {
                return null;    
            }
        }

        public static void WriteToFile(List<Produkt> produkts)
        {
            List<string> outputFile = new List<string>();   
            foreach(var bmiResult in produkts) 
            {
                string linia = $"{bmiResult.Nazwa};{bmiResult.Cena};{bmiResult.Ilosc}";
                outputFile.Add(linia);
            }
            File.WriteAllLines(fileName, outputFile);
        }
    }
}
