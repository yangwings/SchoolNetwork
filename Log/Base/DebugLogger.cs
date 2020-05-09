using System.Diagnostics;

namespace SchoolNetwork.Log.Base
{
    internal class DebugLogger : ILogger
    {
        public void LogError(string error)
        {
            
            Debug.WriteLine(error,"error");
        }

        public void LogMessage(string message)
        {
            Debug.WriteLine(message,"message");
        }

        public void LogWarning(string warning)
        {
            Debug.WriteLine(warning,"warning");
        }
    }
}
