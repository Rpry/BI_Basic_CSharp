using System;

namespace DelegatesAndEvents.Event
{
    class Order
    {
        public delegate void OrderEventHandler();

        public event OrderEventHandler OnCreated;

        public void Create()
        {
            Console.WriteLine("Order created");

            if (OnCreated != null)
            {
                OnCreated();
            }
        }
    }
}