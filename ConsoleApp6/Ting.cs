namespace ConsoleApp6
{
    class Ting
    {
        private int _a;

        public int a
        {
            get
            {

                return _a;
            }
            private set
            {

                _a = value;
            }
        }

        public int GetA()
        {
            return _a;
        }

        private void SetA(int a)
        {
            _a = a;
        }
    }
}
