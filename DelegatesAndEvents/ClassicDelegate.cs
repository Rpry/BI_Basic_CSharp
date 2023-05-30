namespace DelegatesAndEvents
{
    public class ClassicDelegate
    {
        private delegate int PerformCalculation(int x, int y);

        public ClassicDelegate()
        {
            int Method(int x, int y)
            {
                return x + y;
            }

            PerformCalculation del = Method;

            //del(1, 1);
        }
    }
}