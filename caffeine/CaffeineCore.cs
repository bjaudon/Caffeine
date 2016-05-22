/*
 * Name: CaffeineCore Class
 * Synopsis: Core functions for Caffeine
 * Author: Bryan Jaudon <bryan.jaudon@gmail.com>
 * Date: 5/10/2016
 */

using System;
using static Caffeine.ExecutionState;

namespace Caffeine
{
    /// <summary>
    /// Define our core engine functions. Utilize Caffeine.ExecutionState to make calls to the Win32 API
    /// </summary>
    class CaffeineCore
    {
        private static DateTime lastEnabled; // Store the DateTime of the last enable
        private static bool inCaffeineMode = false; // State of our program

        /// <summary>
        /// Sets the Caffeine mode to the specified state
        /// </summary>
        /// <param name="mode"></param>
        public static void setCaffeineMode(bool mode)
        {
            try
            {
                if (mode == true)
                {
                    // Use the ExecutionState class for the Windows API implementation of SetExecutionState.
                    // Set ES_CONTINUOUS, ES_DISPLAY_REQUIRED and ES_SYSTEM_REQUIRED flags to disable screensaver, monitor blanking and sleep mode.
                    EXECUTION_STATE returnState = SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
                    if (returnState == EXECUTION_STATE.ES_ERRORSTATE) { throw new Exception("Could not set Execution State."); }
                    lastEnabled = DateTime.Now; // Record our DateTime of enablement
                    inCaffeineMode = true; // Set our mode to true.
                }
                else
                {
                    // Use the ExecutionState class to set ES_CONTINIOUS to clear the Execution State flags.
                    EXECUTION_STATE returnState = SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
                    if (returnState == EXECUTION_STATE.ES_ERRORSTATE) { throw new Exception("Could not set Execution State."); }
                    inCaffeineMode = false; // Set our enabled mode to false.
                }
            }
            catch (Exception ex)
            {
                throw ex; // Catch any errors and report them.
            }
        }

        /// <summary>
        /// Returns the current Caffeine mode
        /// </summary>
        /// <returns></returns>
        public static bool getCaffeineMode()
        {
            return inCaffeineMode; // Return our current mode.
        }

        /// <summary>
        /// Get the last DateTime that Caffeine was enabled. 
        /// </summary>
        /// <returns></returns>
        public static DateTime getLastEnabled()
        {
            return lastEnabled; // Return the last time we enabled
        }

        /// <summary>
        /// Return the total milliseconds that Caffeine has been enabled.
        /// </summary>
        /// <returns></returns>
        public static int getActiveTime()
        {
            // Return the amount of time we have been active in Caffeine mode. Return -1 if we are not enabled.
            TimeSpan timeElapsed = DateTime.Now - getLastEnabled();
            if (getCaffeineMode()) { return (int)timeElapsed.TotalMilliseconds; }
            else { return -1; }
        }

        /// <summary>
        /// Returns Caffeine state as a string.
        /// </summary>
        /// <returns></returns>
        public static string toString()
        {
            // Default toString() method to announce our current mode.
            return "Caffeine is = " + (inCaffeineMode ? "Enabled":"Disabled");
        }
    }
}