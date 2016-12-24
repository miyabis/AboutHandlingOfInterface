using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiYABiS.Study.インタフェースの扱い.CS
{

    /// <summary>
    /// 計算する為のインタフェース
    /// </summary>
    public interface ICompute
    {

        /// <summary>
        /// 計算する
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        long Execute(long value1, long value2);

    }
}
