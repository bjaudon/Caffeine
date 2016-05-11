/*
 * Name: CaffeineCore Class
 * Synopsis: Core functions for Caffeine
 * Author: Bryan Jaudon <bryan.jaudon@gmail.com>
 * Date: 5/10/2016
 */

using System;

namespace Caffeine
{
    class CaffeineCore
    {
        private DateTime lastEnabled; // Store the DateTime of the last enable
        private bool inCaffeineMode; // State of our program

        public CaffeineCore()
        {
            // Constructor for the instance.
            inCaffeineMode = false; 
        }

        public void setCaffeineMode(bool mode)
        {
            /*
             * Set our mode to the specified state
             * True = Enable Caffeine (no system sleep)
             * False = Disable Caffeine (normal system operation)
             */

            try
            {
                if (mode == true)
                {
                    // Use the ExecutionState class for the Windows API implementation of SetExecutionState.
                    // Set ES_CONTINUOUS, ES_DISPLAY_REQUIRED and ES_SYSTEM_REQUIRED flags to disable screensaver, monitor blanking and sleep mode.
                    ExecutionState.SetThreadExecutionState(ExecutionState.EXECUTION_STATE.ES_CONTINUOUS | ExecutionState.EXECUTION_STATE.ES_DISPLAY_REQUIRED | ExecutionState.EXECUTION_STATE.ES_SYSTEM_REQUIRED);
                    lastEnabled = DateTime.Now; // Record our DateTime of enablement
                    inCaffeineMode = true; // Set our mode to true.
                }
                else
                {
                    // Use the ExecutionState class to set ES_CONTINIOUS to clear the Execution State flags.
                    ExecutionState.SetThreadExecutionState(ExecutionState.EXECUTION_STATE.ES_CONTINUOUS);
                    inCaffeineMode = false; // Set our enabled mode to false.
                }
            }
            catch (Exception ex)
            {
                throw ex; // Catch any errors and report them.
            }
        }

        public bool getCaffeineMode()
        {
            return inCaffeineMode; // Return our current mode.
        }

        public DateTime getLastEnabled()
        {
            return lastEnabled; // Return the last time we enabled
        }

        public int getActiveTime()
        {
            // Return the amount of time we have been active in Caffeine mode. Return -1 if we are not enabled.
            TimeSpan timeElapsed = DateTime.Now - getLastEnabled();
            if (getCaffeineMode()) { return (int)timeElapsed.TotalMilliseconds; }
            else { return -1; }
        }

        public string toString()
        {
            // Default toString() method to announce our current mode.
            return "Caffeine is = " + (inCaffeineMode ? "Enabled":"Disabled");
        }
    }
}