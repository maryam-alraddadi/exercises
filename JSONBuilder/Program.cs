using System;
using System.Collections.Generic;

namespace JSONBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            JSONBuilder j = new JSONBuilder();
                string res = j.add("key1", "value1")
                .add("key2", "value2")
                .add("key3", j.add("nestedKey", "nestedValue3"))
                .getJSON();
                Console.WriteLine(res);
        }
    }

    class JSONBuilder
    {
        private Dictionary<string, JSONBuilder> dict = new Dictionary<string, JSONBuilder>();
        // valueshould be any of string, number, object, array, boolean or null
        private string json;
        public JSONBuilder()
        {
            //this.dict = new Dictionary<string, JSONBuilder>();
            this.json = "{";
        }

        public JSONBuilder add(string key, string value)
        {
            this.json += "'" + key + "'" + ":" + "'" + value + "'" + " ,";
            return this;
        }

        public JSONBuilder add(string key, JSONBuilder value)
        {
            this.json += "'" + key + "'" + ":" + "'" + value + "'" + " ,";
            return this;
        }

        public string getJSON()
        {
            return this.json + "}";
        }
    }
}