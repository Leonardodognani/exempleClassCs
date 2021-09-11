using System;

namespace exempleClassCs
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.desempilha());
            Console.WriteLine(s.desempilha());
            Console.WriteLine(s.desempilha());
        }
    }
}
