using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TDDHomeWork
{
    public interface IData
    {
        DataTable getSourceData();
    }
}
