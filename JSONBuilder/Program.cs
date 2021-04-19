using System;
using System.Collections.Generic;

namespace JSONBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONBuilder j = new JSONBuilder();
                string res = j.add("key1", "value1")
                .add("key2", "value2")
                .add("key3", j.add("nestedKey", "nestedValue3"))
                .add("key4", 5).add("key6", "value6")
                .getJSON();
                Console.WriteLine(res);
        }
    }

    class JSONBuilder
    {
        private string json;
        public JSONBuilder()
        {
            this.json = "{";
        }

        public JSONBuilder add(string key, string value)
        {
            this.json += "'" + key + "'" + ":" + "'" + value + "'" + " ,";
            return this;
        }

        public JSONBuilder add(string key, int value)
        {
            this.json += "'" + key + "'" + ":" + "'" + value + "'" + " ,";
            return this;
        }

        public JSONBuilder add(string key, bool value)
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