using System;
using System.Collections.Generic;

namespace TechDas.DTO
{
    public class PythonData
    {
        public string id { get; set; } = string.Empty;

        public List<DateTime> Datelist { get; set; } = new List<DateTime>();
        public List<int> sensor1_value { get; set; } = new List<int>();
        public List<int> sensor2_value { get; set; } = new List<int>();

        public List<int> sensor3_value { get; set; } = new List<int>();

        public List<int> sensor4_value { get; set; } = new List<int>();

        public List<int> sensor5_value { get; set; } = new List<int>();

        public List<int> sensor6_value { get; set; } = new List<int>();

        public List<int> sensor7_value { get; set; } = new List<int>();

        public List<int> sensor8_value { get; set; } = new List<int>();

        public List<int> sensor9_value { get; set; } = new List<int>();

        public List<int> sensor10_value { get; set; } = new List<int>();

        public List<int> sensor1_value_pred { get; set; } = new List<int>();

        public List<int> sensor2_value_pred { get; set; } = new List<int>();

        public List<int> sensor3_value_pred { get; set; } = new List<int>();

        public List<int> sensor4_value_pred { get; set; } = new List<int>();

        public List<int> sensor5_value_pred { get; set; } = new List<int>();

        public List<int> sensor6_value_pred { get; set; } = new List<int>();

        public List<int> sensor7_value_pred { get; set; } = new List<int>();

        public List<int> sensor8_value_pred { get; set; } = new List<int>();

        public List<int> sensor9_value_pred { get; set; } = new List<int>();

        public List<int> sensor10_value_pred { get; set; } = new List<int>();

        public List<string> sensors_status { get; set; } = new List<string>();

        public List<int> sensors_sigma { get; set; } = new List<int>();

        public List<string> sensors_percent { get; set; } = new List<string>();

        public PythonData()
        {
        }

        private static Random rnd;

        static PythonData()
        {
            rnd = new Random();
        }

        public static PythonData CreateRandom(string _id)
        {
            return new PythonData()
            {
                id = _id,
                Datelist = RandomDts(),
                sensor1_value = RandomInt(),
                sensor2_value = RandomInt(),
                sensor3_value = RandomInt(),
                sensor4_value = RandomInt(),
                sensor5_value = RandomInt(),
                sensor6_value = RandomInt(),
                sensor7_value = RandomInt(),
                sensor8_value = RandomInt(),
                sensor9_value = RandomInt(),
                sensor10_value = RandomInt(),
                sensor1_value_pred = RandomInt(),
                sensor2_value_pred = RandomInt(),
                sensor3_value_pred = RandomInt(),
                sensor4_value_pred = RandomInt(),
                sensor5_value_pred = RandomInt(),
                sensor6_value_pred = RandomInt(),
                sensor7_value_pred = RandomInt(),
                sensor8_value_pred = RandomInt(),
                sensor9_value_pred = RandomInt(),
                sensor10_value_pred = RandomInt(),
                sensors_status = ListString("start", "stop"),
                sensors_sigma = RandomInt(),
                sensors_percent = ListString("60%", "70%", "80%")
            };
        }

        protected static List<DateTime> RandomDts()
        {
            List<DateTime> dts = new List<DateTime>();
            dts.Add(DateTime.Now);
            dts.Add(DateTime.Now.AddMinutes(-10));
            dts.Add(DateTime.Now.AddMinutes(-20));
            dts.Add(DateTime.Now.AddMinutes(-30));
            return dts;
        }

        protected static List<int> RandomInt()
        {
            //Random rnd = new Random();
            List<int> result = new List<int>();
            result.Add(rnd.Next(1, 100));
            result.Add(rnd.Next(1, 100));
            result.Add(rnd.Next(1, 100));
            return result;
        }

        protected static List<string> ListString(params string[] arr)
        {
            List<string> result = new List<string>();
            foreach(string str in arr)
            {
                result.Add(str);
            }
            return result;
        }
    }
}
