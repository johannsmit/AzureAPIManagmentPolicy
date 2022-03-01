using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace AzureAPIManagementPolicy.Models
{
    public interface IMessageBody
    {
        /// <summary>
        /// T : string, byte[],JObject, JToken, JArray, XNode, XElement, XDocument
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="preserveContent"></param>
        /// <returns>string, byte[],JObject, JToken, JArray, XNode, XElement, XDocument</returns>
        public T As<T>(bool preserveContent = false);
    }
}