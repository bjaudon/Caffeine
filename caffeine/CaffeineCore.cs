using System;

namespace Caffeine
{
    class CaffeineCore
    {
        private DateTime lastEnabled;
        private bool inCaffeineMode;

        public CaffeineCore()
        {
            inCaffeineMode = false;
        }

        public void setCaffeineMode(bool mode)
        {
            try
            {
                if (mode == true)
                {
                    ExecutionState.SetThreadExecutionState(ExecutionState.EXECUTION_STATE.ES_CONTINUOUS | ExecutionState.EXECUTION_STATE.ES_DISPLAY_REQUIRED | ExecutionState.EXECUTION_STATE.ES_SYSTEM_REQUIRED);
                    lastEnabled = DateTime.Now;
                    inCaffeineMode = true;
                }
                else
                {
                    ExecutionState.SetThreadExecutionState(ExecutionState.EXECUTION_STATE.ES_CONTINUOUS);
                    inCaffeineMode = false;
                }
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public bool getCaffeineMode()
        {
            return inCaffeineMode;
        }

        public DateTime getLastEnabled()
        {
            return lastEnabled;
        }

        public int getActiveTime()
        {
            TimeSpan timeElapsed = DateTime.Now - getLastEnabled();
            if (getCaffeineMode()) { return (int)timeElapsed.TotalMilliseconds; }
            else { return -1; }
        }

        public string toString()
        {
            return "Caffeine is = " + (inCaffeineMode ? "Enabled":"Disabled");
        }

        
        
        
    }
}