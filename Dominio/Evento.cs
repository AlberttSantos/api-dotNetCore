using System;

namespace TreinamentoCSharp.Dominio
{
    public class Evento : Base
    {       
        public int SalaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}