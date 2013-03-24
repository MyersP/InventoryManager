using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using InventoryManager.Models;
using Assert = NUnit.Framework.Assert;


namespace InventoryTests
{
    [TestClass]
    public class UnitTest
    {
        private readonly Type _Garmentstype = typeof(GarmentsModel);

        [TestCase("PatternNumberID", typeof(string))]
        [TestCase("GarmentNameID", typeof(string))]
        [TestCase("GarmentLocationID", typeof(string))]
        [TestCase("GarmentGenderID", typeof(string))]
        [TestCase("GarmentLayerID", typeof(string))]
        [TestCase("GarmentStoredID", typeof(string))]
        [TestCase("CustomerID", typeof(string))]
        [TestCase("GarmentMeasurementsID", typeof(string))]
       // [TestCase("SimilarAssets", typeof(IEnumerable<>))]
        public void ValidateGarmentModels(string propertyName, object type)
        {
            var property = _Garmentstype.GetProperty(propertyName);
            Assert.AreEqual(property.PropertyType, type);
        }

    }
}
