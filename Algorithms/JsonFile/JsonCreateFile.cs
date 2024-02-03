using System.Globalization;
using Newtonsoft.Json;

namespace Algorithms.JsonFile {
    public class JsonCreateFile {
        public static void WriteJsonToFile(string inputFile = "JsonReadFile.txt" , string outputFile = "JsonWriteFile.json") {
            var path = @"D:\Projects\Algorithms\Algorithms\JsonFile\"; //Your Path here.
            var lines = File.ReadAllLines(path + inputFile);
            List<JsonClass>? jsonList = new();
            var provider = CultureInfo.CreateSpecificCulture("en-US");

            string[] formats = { "yyyy-MM-dd-HH-mm", "yyyy-M-dd-HH-mm", "yyyy-MM-d-HH-mm", "yyyy-M-d-HH-mm", "yyyy-MM-dd-H-mm", "yyyy-MM-d-H-mm",
                                 "yyyy-M-d-H-mm", "yyyy-MM-dd-HH-m", "yyyy-MM-dd-H-m", "yyyy-MM-d-H-m", "yyyy-M-d-H-m" };

            foreach(string line in lines.Skip(1)) {

                var lineSplit = line.Split(',');
                string? comment = null;
                List<double>? valueList = new();

                lineSplit[^1] = lineSplit[^1][..^1];

                bool b = DateTime.TryParseExact(lineSplit[0][1..] , formats , null , DateTimeStyles.None , out DateTime timeStamp);

                int i;
                for(i = 1; i < lineSplit.Length; i++) {
                    if(double.TryParse(lineSplit[i] , provider , out double value)) {
                        valueList.Add(value);
                    }
                    else {
                        comment = lineSplit[i];
                    }
                }

                JsonClass jsonClass = new() {
                    TimeStamp = timeStamp ,
                    Value = valueList.Count > 0 ? valueList : null ,
                    Comment = comment
                };

                jsonList.Add(jsonClass);
            }

            jsonList = jsonList.OrderBy(t => t.TimeStamp).ToList();

            string json = JsonConvert.SerializeObject(jsonList , Formatting.Indented);
            File.WriteAllText(path + outputFile , json);
        }
    }
}
