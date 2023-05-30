using System.Collections.Generic;

namespace BoxingUnboxing
{
    public static class Class
    {
        static long iterationsCount = 900000000;
        private static string firstName = "Ivan";
        private static string lastName = "Smirnov";
        
        
        public static int CastingIntToLong()
        {
            int number = 0;
            for (int i=0; i < iterationsCount; i++)
            {
                var obj = (long)i;
                number = (int)obj;
            }

            return number;
        }
        
        public static int CastingIntToObject()
        {
            int number = 0;
            for (int i=0; i < iterationsCount; i++)
            {
                var obj = (object)i;
                number = (int)obj;
            }

            return number;
        }
    }
}