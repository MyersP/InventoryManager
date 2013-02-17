using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventoryManager.DataAccess;

namespace InventoryManager.Mappers
{
    public class MapperHelper
    {
        public IDataHelpers _DataHelpers = new DataHelpers();
        public string GetValueFromDict(Dictionary<string, string> dictionary, string searchString)
        {
            string value;
            dictionary.TryGetValue(searchString, out value);
            return value;
        }
    }
}