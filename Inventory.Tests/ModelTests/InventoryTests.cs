using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Inventory.Models;


// namespace Inventory.Tests
// {
//     [TestClass]
//     public class CollectionTest : IDisposable
//     {
//         public void Dispose()
//         {
//             Collection.ClearAll();
//         }

//         public CollectionTest()
//         {
//             DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=inventory_test;";
//         }

//         [TestMethod]
//         public void GetAll_ReturnsEmptyListFromDatabase_CollectionList()
//         {
//         //Arrange
//         List<Collection> newList = new List<Collection> { };

//         //Act
//         List<Collection> result = Collection.GetAll();

//         //Assert
//         CollectionAssert.AreEqual(newList, result);
//         }
//     }
// }