using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManager.DataAccess
{
    public interface IDataHelpers
    {
        string CheckForNull(string textToCheck);
        string ConvertToNull(string textToCheck);
        string ChangeNullToZero(string value);
        Dictionary<string, string> GetNameValuePairFromModel(object objectModel);
        List<string> GetNamesFromModel(object objecmodel);
    }

    public class DataHelpers : IDataHelpers
    {

        public string CheckForNull(string textToCheck)
        {
            var stringythingy = String.IsNullOrWhiteSpace(textToCheck) ? "" : textToCheck;
            return stringythingy;
        }

        public string ConvertToNull(string textToCheck)
        {
            var stringythingy = String.IsNullOrWhiteSpace(textToCheck) ? "null" : "'" + textToCheck + "'";
            return stringythingy;
        }

        public string ChangeNullToZero(string value)
        {
            return String.IsNullOrEmpty(value) ? "0" : value;
        }

        public Dictionary<string, string> GetNameValuePairFromModel(object objectModel)
        {
            //TODO: make this filter out a new TableName property that I could add to help make calls more generic
            Type t = objectModel.GetType();
            return t.GetProperties().Where(pi => pi.PropertyType == typeof(string) && pi.GetGetMethod() != null)
                .ToDictionary(field => field.Name, field => field.GetValue(objectModel, null) as string);
        }

        public List<string> GetNamesFromModel(object objecmodel)
        {
            Type t = objecmodel.GetType();

            List<string> list = t.GetProperties()
                .Where(pi => pi.PropertyType == typeof (string) && pi.GetGetMethod() != null)
                .Select(field => field.Name).ToList();
            return list;
        }
    }
}