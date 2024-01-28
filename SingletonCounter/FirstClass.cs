namespace SingletonCounter
{
    class FirstClass
    {
        static int count = 0;

        public FirstClass()
        {
            ++count;
        }

        public int Count()
        {
            return count;
        }
    }
}
