/*
 * Name: ExecutionState Class
 * Synopsis: Windows API for SetExecutionState method.
 * Author: Bryan Jaudon<bryan.jaudon@gmail.com>
 * Date: 5/10/2016
 * 
 * Microsoft SetThreadExecutionState 
 * https://msdn.microsoft.com/en-us/library/aa373208(v=vs85).aspx
 */

using System.Runtime.InteropServices;

namespace Caffeine
{
    internal class ExecutionState
    {
        public enum EXECUTION_STATE : uint
        {            
            ES_CONTINUOUS = 0x80000000,         // Informs the system that the state being set should remain in effect until 
                                                // the next call that uses ES_CONTINUOUS and one of the other state flags is 
                                                // cleared.

            ES_AWAYMODE_REQUIRED = 0x00000040,  // Enables away mode. This value must be specified with ES_CONTINUOUS.
                                                // Away mode should be used only by media-recording and media-distribution
                                                // applications that must perform critical background processing on 
                                                // desktop computers while the computer appears to be sleeping. See Remarks.

            ES_DISPLAY_REQUIRED = 0x00000002,   // Forces the display to be on by resetting the display idle timer.
                                                // Windows 8:  This flag can only keep a display turned on, it can't turn on 
                                                // a display that's currently off

            ES_SYSTEM_REQUIRED = 0x00000001,    // Forces the system to be in the working state by resetting the system idle 
                                                // timer.

            ES_USER_PRESENT = 0x00000004,       // This value is not supported. If ES_USER_PRESENT is combined with other 
                                                // esFlags values, the call will fail and none of the specified states will be 
                                                // set.
        }
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

    }
}
