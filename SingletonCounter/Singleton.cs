﻿namespace SingletonCounter
{
    public class Singleton
    {
        protected static int name = 0;
        /// Защищенный конструктор нужен, чтобы предотвратить создание экземпляра класса Singleton
        protected Singleton()
        {
            name += 1;
            Console.WriteLine("Singleton has been planted");
        }

        private sealed class SingletonCreator
        {
            private static readonly Singleton instance = new Singleton();
            public static Singleton Instance { get { return instance; } }
        }
        public string getName
        {
            get
            {
                return name.ToString();
            }
        }
        public static Singleton Instance
        {
            get { return SingletonCreator.Instance; }
        }

    }
}