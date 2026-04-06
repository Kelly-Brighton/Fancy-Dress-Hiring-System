using Microsoft.VisualStudio.TestTools.UnitTesting;
using FancyDressHiringSystem;
using System.Collections.Generic;

namespace FancyDressTests
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void Test_Filter_WithGender()
        {
            var genders = new List<string> { "Male" };
            var sizes = new List<string>();

            string query = FilterHelper.BuildQuery(genders, sizes, false);

            Assert.IsTrue(query.Contains("Gender IN ('Male')"));
        }

        [TestMethod]
        public void Test_Filter_WithSize()
        {
            var genders = new List<string>();
            var sizes = new List<string> { "M" };

            string query = FilterHelper.BuildQuery(genders, sizes, false);

            Assert.IsTrue(query.Contains("Size IN ('M')"));
        }

        [TestMethod]
        public void Test_Filter_WithSearch()
        {
            string query = FilterHelper.BuildQuery(
                new List<string>(),
                new List<string>(),
                true
            );

            Assert.IsTrue(query.Contains("Name LIKE @searchTerm"));
        }

        [TestMethod]
        public void Test_Filter_AlwaysIncludesPrice()
        {
            string query = FilterHelper.BuildQuery(
                new List<string>(),
                new List<string>(),
                false
            );

            Assert.IsTrue(query.Contains("Price <= @price"));
        }
    }
}
