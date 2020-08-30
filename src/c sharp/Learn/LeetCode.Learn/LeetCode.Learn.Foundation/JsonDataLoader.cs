using System.IO;
using Newtonsoft.Json;

namespace LeetCode.Learn.Foundation
{
    public static class JsonDataLoader
    {
        /// <summary>
        /// This method retuns the json data to object if json data format is 
        /// confortable to T type
        /// </summary>
        /// <typeparam name="T">object type</typeparam>
        /// <param name="filePath">path of json data file</param>
        /// <returns></returns>
        public static T GetJsonFileData<T>(string filePath)
        {
            using (StreamReader fileStream = GetStreamReader(filePath))
            {
                return ConvertJsonStreamToObject<T>(fileStream);
            }
        }

        private static T ConvertJsonStreamToObject<T>(StreamReader fileStream)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            return (T)jsonSerializer.Deserialize(fileStream, typeof(T));
        }

        private static StreamReader GetStreamReader(string filePath)
        {
            var fullFilePath = System.IO.Path.GetFullPath(filePath);
            StreamReader streamReader = File.OpenText(fullFilePath);

            return streamReader;
        }
    }
}
