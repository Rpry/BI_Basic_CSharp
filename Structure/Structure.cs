namespace Structure
{
    public struct Structure //static //abstract //sealed
    {
        private int field;

        public int Property { get; set; }
        
        public void Method(){}

        public Structure(int i)
        {
            field = 1;
            Property = 1;
        }
    }
}