using System.Collections.Generic;

namespace DelegatesAndEvents
{
    public class AnonymousAndLambda
    {
        private delegate int PerformCalculation(int x, int y);

        public AnonymousAndLambda()
        {
            int Method(int x, int y)
            {
                return x + y;
            }

            PerformCalculation del = Method;

            //anonymous method
            del = delegate(int x, int y) { return x - y; };

            //lambda
            del = (x, y) => { return x - y; };
        }
    }
}