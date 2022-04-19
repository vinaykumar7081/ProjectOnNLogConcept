using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOnNLogProject
{
    public class AdditionOfNumbers
    {
        private readonly NLog nLog = new NLog();
        public int Add(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                nLog.LogDebug("Debug Successfull : Sum()");
                nLog.LogError("Expecting not null values");
                nLog.LogWarn("FirstNumber or secondNumber should not equal to 0");
            }
            int result = x + y;
            nLog.LogDebug("Debug Successfull : Sum()");
            nLog.LogInfo("Sum Method passed, Result" + result);
            return result;
        }
    }
}
