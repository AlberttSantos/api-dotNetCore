namespace TreinamentoCSharp.Dominio
{
    public class Sala : Base
    {        
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        public bool PossuiTV { get; set; }
        public bool PossuiProjetor { get; set; }
    }
}