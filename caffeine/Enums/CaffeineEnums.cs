namespace Caffeine
{
    public class CaffeineEnums
    {
        /// <summary>
        /// Enum for the TimeInterval settings 
        /// </summary>
        public enum TimeInterval : int
        {
            Indefinite = 0,
            fiveMinutes = 1,
            tenMinutes = 2,
            fifteenMinutes = 3,
            thirtyMinutes = 4,
            oneHour = 5,
            twoHours = 6,
            fiveHours = 7,
            eightHours = 8,
            oneDay = 9,

        }


        /// <summary>
        /// Enum to translate the Enum TimeInterval to Milliseconds
        /// </summary>
        public enum MinutesToMilliseconds : int
        {
            Indefinite = -1,
            fiveMinutes = 300000,
            tenMinutes = 600000,
            fifteenMinutes = 900000,
            thirtyMinutes = 1800000,
            oneHour = 3600000,
            twoHours = 7200000,
            fiveHours = 18000000,
            eightHours = 28800000,
            oneDay = 86400000,
        }
    }
}
