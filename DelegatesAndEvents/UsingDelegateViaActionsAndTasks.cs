using System;

namespace DelegatesAndEvents
{
    public static class UsingDelegateViaActionsAndTasks
    {
        public static int RunActionAndWriteToConsole(int x, int y, Func<int, int, int> action)
        {
            var resultOfAction = action(x, y);
            return resultOfAction;
        }
    }
}