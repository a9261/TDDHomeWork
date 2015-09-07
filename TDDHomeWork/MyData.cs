using System;
using System.Collections.Generic;
 
using System.Text;
using System.Threading.Tasks;
 
using System.Data;
namespace TDDHomeWork
{
    //模擬資料
    public class MyData : IData
    {
  
        public DataTable getSourceData()
        {
             //1.建立模擬資料
             //Id	Cost	Revenue	SellPrice
             //1	1	11	21
             //2	2	12	22
             //3	3	13	23
             //4	4	14	24
             //5	5	15	25
             //6	6	16	26
             //7	7	17	27
             //8	8	18	28
             //9	9	19	29
             //10	10	20	30
             //11	11	21	31
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int)); dt.Columns.Add("Cost", typeof(int));
            dt.Columns.Add("Revenue", typeof(int)); dt.Columns.Add("SellPrice", typeof(int));
            dt.Rows.Add(new object[] { 1, 1, 11, 21 });
            dt.Rows.Add(new object[] { 2, 2, 12, 22 });
            dt.Rows.Add(new object[] { 3, 3, 13, 23 });
            dt.Rows.Add(new object[] { 4, 4, 14, 24 });
            dt.Rows.Add(new object[] { 5, 5, 15, 25 });
            dt.Rows.Add(new object[] { 6, 6, 16, 26 });
            dt.Rows.Add(new object[] { 7, 7, 17, 27 });
            dt.Rows.Add(new object[] { 8, 8, 18, 28 });
            dt.Rows.Add(new object[] { 9, 9, 19, 29 });
            dt.Rows.Add(new object[] { 10, 10, 20, 30 });
            dt.Rows.Add(new object[] { 11, 11, 21, 31 });
           
            return dt;
        }
    }

}
