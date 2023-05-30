namespace DelegatesAndEvents
{
    public static class UsingDelegate
    {
        public delegate int Calculation(int x, int y);
        
        public static int RunActionAndWriteToConsole(int x, int y, Calculation action)
        {
            var resultOfAction = action(x, y);
            return resultOfAction;
        }
    }
}