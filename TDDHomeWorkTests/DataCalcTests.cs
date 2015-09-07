using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDHomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Collections;
namespace TDDHomeWork.Tests
{
    [TestClass()]
    public class DataCalcTests
    {
        [TestMethod()]
        public void getResultTest_3ItemsGroup_CostSum_6_15_24_21()
        {
           //Arrange
            MyData d = new MyData();
            var Group3ItmesResult = from item in d.getSourceData().AsEnumerable()
                         group item by (((int)(item["Id"])-1) / 3) into g
                         select g;
            ArrayList expected = new ArrayList() { 6,15,24,21};
           //Act
            var actual = DataCalc.Sum(Group3ItmesResult, "Cost");
           //Assert
            CollectionAssert.AreEqual(expected, actual); 
        }
        [TestMethod()]
        public void getResultTest_4ItemsGroup_RevenueSum_50_66_60()
        {
            //Arrange
            MyData d = new MyData();
            var Group4ItmesResult = from item in d.getSourceData().AsEnumerable()
                                    group item by (((int)(item["Id"]) - 1) / 4) into g
                                    select g;
            ArrayList expected = new ArrayList() { 50, 66, 60 };
            //Act
            var actual = DataCalc.Sum(Group4ItmesResult, "Revenue");
            //Assert
            CollectionAssert.AreEqual(expected, actual); 
        }
       
    }
}
