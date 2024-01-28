namespace SingletonCounter
{
    class SecondClass
    {
        Singleton subject = Singleton.Instance;

        public SecondClass() { }

        public string Count()
        {
            return subject.getName;
        }
    }
}
