using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Inventory.Models;


namespace Inventory.Tests
{
    [TestClass]
    public class CollectionTest : IDisposable
    {
        public void Dispose()
        {
            Collection.ClearAll();
        }

        public CollectionTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=inventory_test;";
        }

        [TestMethod]
        public void CollectionConstructor_CreatesInstanceOfCollection_Collection()
        {
        Collection newCollection = new Collection("name", "description");
        string resultName = newCollection.Name;
        string resultDescription = newCollection.Description;
        int resultId = newCollection.Id;

        Assert.AreEqual(typeof(Collection), newCollection.GetType());
        Assert.AreEqual(resultName, "name");
        Assert.AreEqual(resultDescription, "description");
        Assert.AreEqual(resultId, 1);
        }
    }
}