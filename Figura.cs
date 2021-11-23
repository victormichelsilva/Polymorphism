using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo1
{
    class Figura
    {
        public virtual void Desenhar() 
        {
            Console.WriteLine("Executando Desenhar na classe base");
        }
    }
}
