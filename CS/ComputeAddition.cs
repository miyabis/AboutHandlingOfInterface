using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiYABiS.Study.インタフェースの扱い.CS
{

    /// <summary>
    /// 加算する
    /// </summary>
    public class ComputeAddition : ICompute
    {

        long ICompute.Execute(long value1, long value2)
        {
            return value1 + value2;
        }

    }
}
