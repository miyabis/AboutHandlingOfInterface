using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiYABiS.Study.インタフェースの扱い.CS
{

    /// <summary>
    /// 減算する
    /// </summary>
    public class ComputeSubtraction : ICompute
    {

        long ICompute.Execute(long value1, long value2)
        {
            return value1 - value2;
        }

    }
}
