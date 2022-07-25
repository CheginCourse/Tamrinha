using System;
using Newtonsoft.Json;

namespace Json
{
    class DataStructure
    {
        public int? id;

        public string? first_name;

        public string? last_name;

        public string? email;

        public string? gender;

        public int? Age;

        public string? ip_address;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText(@".\Employee.json");
            List<DataStructure>? datas = JsonConvert.DeserializeObject<List<DataStructure>>(json);

            foreach (DataStructure data in datas)
            {
                if (data.gender == "Male" && data.Age > 20)
                {
                    Console.WriteLine($"{data.first_name} {data.last_name}");    
                }
            }

            // # With Linq

            IEnumerable<DataStructure> filtered = from data in datas
                           where data.Age > 20 && data.gender == "Male"
                           select data;
            List<DataStructure> filteredData = filtered.ToList();
             foreach (DataStructure item in filteredData)
            {
                Console.WriteLine($"{item.first_name} {item.last_name}");    
            }
         }
    }
}
