using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFincanceLab
{
    public interface ITable_Data
    {
        List<object[]> GetRows();
        void ClearCachedData();
    }
}
