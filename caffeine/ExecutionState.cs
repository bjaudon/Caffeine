/*
 * Microsoft SetThreadExecutionState 
 * https://msdn.microsoft.com/en-us/library/aa373208(v=vs/85).aspx
 */

using System.Runtime.InteropServices;

namespace Caffeine
{
    internal class ExecutionState
    {
        public enum EXECUTION_STATE : uint
        {            
            ES_CONTINUOUS = 0x80000000,
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001,
            ES_USER_PRESENT = 0x00000004,
        }
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

    }
}
