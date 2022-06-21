using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TopMSQuestions.Easy
{
    public class _359_Logger_Rate_Limiter
    {
        Dictionary<string, int> trackMessage;

        public _359_Logger_Rate_Limiter() {
            trackMessage = new Dictionary<string, int>();
        }

        public bool ShouldPrintMessage(int timestamp, string message) {
            if (trackMessage.ContainsKey(message) && timestamp - trackMessage[message] < 10) { 
                return false; 
            }
            trackMessage[message] = timestamp;
            return true;
        }
    }
}
