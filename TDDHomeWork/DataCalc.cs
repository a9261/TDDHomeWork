using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomeWork
{
    public class DataCalc
    {
     
        //public delegate Func<IEnumerable, ArrayList> CalcMethod;
       // public delegate ArrayList CalcMethod(IEnumerable D);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_DataSource"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        public static ArrayList Sum(dynamic _DataSource,string ColumnName) 
        {

            var xx = _DataSource;

            if (((IEnumerable)_DataSource).GetEnumerator().MoveNext())
            {
                //((IEnumerable)_DataSource).GetEnumerator().Reset();
                ArrayList Result = new ArrayList();
                foreach (var item in (IEnumerable)_DataSource)
                {
                        int sum = 0;
                        if (item.GetType() != typeof(DataRow)) { 
                            foreach (var content in (IGrouping<int, DataRow>)item)
                            {
                                sum += (int)content.Field<int>(ColumnName);
                            }
                        }
                        else
                        {
                            sum += ((DataRow)item).Field<int>(ColumnName);
                        }
                        Result.Add(sum);
                    
                }
                return Result;
            }
            return null;
           
        }
    }
    
}
