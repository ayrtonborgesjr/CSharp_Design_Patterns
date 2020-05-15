using System;

namespace _01_Singleton
{
    // classe sealed não pode ser herdada
    public sealed class Singleton 
    {
        // objetos e métodos static não podem ser instânciados
        private static Singleton Instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                    Console.WriteLine("Ball");
                }

                return Instance;
            }
        }

        public void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
