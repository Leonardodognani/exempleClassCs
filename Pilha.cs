using System;

namespace exempleClassCs {

    public class Pilha {

        Posicao primeiro;

        public void Empilha(object item) 
        {
            primeiro = new Posicao(primeiro, item);
        }
        public object Desempilha()
        {
            if(primeiro == null)
            {
                throw new InvalidOperationException();
            }
        }
    }
}

     
