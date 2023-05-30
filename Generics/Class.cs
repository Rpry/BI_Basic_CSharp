using System.Collections.Generic;

namespace Generics
{
    public static class Class
    {
        static int iterationsCount = 30000000;
        private static string firstName = "Ivan";
        private static string lastName = "Smirnov";
        
        public static void ManyAdditionsViaListOfObjects()
        {
            var list = new List<object>();
            for (int i=0; i < iterationsCount; i++)
            {
                list.Add(i);
                int dto = (int)list[i];
            }
        }
        
        public static void ManyAdditionsViaGenericList()
        {
            var list = new List<int>();
            for (int i=0; i < iterationsCount; i++)
            {
                list.Add(i);
                int dto = list[i];
            }
        }
        
        public static string OneConcatenationViaString()
        {
            string fullname = null;
            for (int i=0; i < iterationsCount; i++)
            {
                fullname = firstName + " " + lastName;
            }
            return fullname;
        }
        
        public static string OneConcatenationViaStringBuilder()
        {
            string fullname = null;
            for (int i = 0; i < iterationsCount; i++)
            {
                var builder = new System.Text.StringBuilder();
                builder.Append(firstName);
                builder.Append(" ");
                builder.Append(lastName);
                fullname = builder.ToString();
            }
            return fullname;
        }
    }
}