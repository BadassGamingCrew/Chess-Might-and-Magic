using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleChessUnitTests
{
    public static class Utils
    {
        public const string ExceptionErrorMessage =
            "Unexpected exception ocured!!{0}Exception type: {1}{0}Exception Message: {2}{0}";

        public static string BuildErrorMessage(Exception e)
        {
            string newLine = Environment.NewLine;
            Type exceptionType = e.GetType();
            string exceptionMessage = e.Message;

            return string.Format(ExceptionErrorMessage, newLine, exceptionType, exceptionMessage);
        }
    }
}
