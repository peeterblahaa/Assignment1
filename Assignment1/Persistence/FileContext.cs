using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace FileData
{
    public class FileContext : AdultsData
    {
       
        public IList<Adult> Adults { get; private set; }


        
        private readonly string adultsFile = "adults.json";

        public FileContext()
        {
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(adultsFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        {
            // storing persons
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }


        public IList<Adult> GetAdults()
        {
            List<Adult> tmp = new List<Adult>(Adults);
            return tmp;
        }


        public void AddAdult(Adult adult)
        {
            int max = Adults.Max(adult1 => adult1.Id);
            adult.Id = (++max);
            Adults.Add(adult);
            SaveChanges();
        }

        public void RemoveAdult(int Id)
        {
            Adult toRemove = Adults.First(t => t.Id == Id);
            Adults.Remove(toRemove);
            SaveChanges();
        }

        public void Update(Adult adult)
        {
            Adult toUpdate = Adults.First(t => t.Age == adult.Age);
            SaveChanges();
        }

        public Adult Get(int age)
        {
            return Adults.FirstOrDefault(t => t.Age == age);
        }
    }
}