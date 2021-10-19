using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Dynamic;

namespace UseJson
{
    /// <summary>
    /// Json
    /// JSON存储 --- Mongo ES
    /// Json作为配置 vs XML作为配置
    /// </summary>
    public class Program
    {
        class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }

            [JsonIgnore]
            public string MyProperty { get; set; }
        }

        public class ExampleClass
        {
            public string String1 { get; set; }
            public string String2 { get; set; }
            public string String3 { get; set; }

        }
        public static async Task Main(string[] args)
        {
            String str = "{\"Id\":\"123\",\"DateOfRegistration\":\"2012-10-21T00:00:00+05:30\",\"Status\":0}";
            string json = "{\"String1\": 1, \"String2\": true, \"String3\": false }";
            string str1 = "{'Id':'123','DateOfRegistration':'2012 - 10 - 21T00: 00:00 + 05:30','Status':0}".Replace("'", "\"");
            //string json1 = @"{ "String1": 1,"String2": true,"String3": false}";
            //The System.Text.Json types are thread-safe, including:
            //JsonSerializer
            //Utf8JsonReader
            //Utf8JsonWriter
            //JsonDocument
            Person person = new Person { Name = "Hello", Age = 123, MyProperty = "adfljflsad" };


            /////C#动态语言部分 类比Python JS
            //dynamic contact = new ExpandoObject
            //{
            //    Name = "Patrick Hines",
            //    Phone = "206-555-0144",
            //    Address = new ExpandoObject
            //    {
            //        Street = "123 Main St",
            //        City = "Mercer Island",
            //        State = "WA",
            //        Postal = "68402"
            //    }
            //};

            dynamic contact = new ExpandoObject();
            contact.Name = "Patrick Hines";
            contact.Phone = "206-555-0144";
            contact.Address = new ExpandoObject();
            contact.Address.Street = "123 Main St";
            contact.Address.City = "Mercer Island";
            contact.Address.State = "WA";
            contact.Address.Postal = "68402";

            //Serialize to get Json string using NewtonSoft.JSON
            string Json = JsonSerializer.Serialize(contact, new JsonSerializerOptions { WriteIndented = true});

            File.WriteAllTextAsync(Path.Combine(AppContext.BaseDirectory, "contact.json"), Json);


            var str2 = JsonSerializer.Serialize(person, new JsonSerializerOptions(JsonSerializerDefaults.General));
            await File.WriteAllTextAsync(Path.Combine(AppContext.BaseDirectory, "person.json"), str);

            using var stream = new FileStream(Path.Combine(AppContext.BaseDirectory, "person.json"), FileMode.Open, FileAccess.Read);

            //从流中异步
            var deserialObj = await JsonSerializer.DeserializeAsync<Person>(stream);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
