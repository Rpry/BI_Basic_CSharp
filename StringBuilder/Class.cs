using System;
using System.Diagnostics;

namespace StringBuilder
{
    public static class Class
    {
        static int iterationsCount = 300000;
        private static string firstName = "Ivan";
        private static string lastName = "Smirnov";
        
        public static void ManyConcatenationsViaString()
        {
            string x = "";
            for (int i=0; i < iterationsCount; i++)
            {
                x += "!";
            }
        }
        
        public static void ManyConcatenationsViaStringBuilder()
        {
            var builder = new System.Text.StringBuilder();
            for (int i=0; i < iterationsCount; i++)
            {
                builder.Append("!");
            }
            string x = builder.ToString();
        }
        
        public static string OneConcatenationViaString()
        {
            string fullname = null;
            for (int i=0; i < iterationsCount; i++)
            {
                fullname = Guid.NewGuid() + " " + Guid.NewGuid();
            }
            return fullname;
        }
        
        public static string OneConcatenationViaStringBuilder()
        {
            string fullname = null;
            var builder = new System.Text.StringBuilder();
            for (int i = 0; i < iterationsCount; i++)
            {
                builder.Append(Guid.NewGuid());
                builder.Append(" ");
                builder.Append(Guid.NewGuid());
            }
            return builder.ToString();
        }
    }
}