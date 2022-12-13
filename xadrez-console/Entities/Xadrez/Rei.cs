using Entities.Enums;
using Entities.Tabuleiro2;

namespace Entities.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
