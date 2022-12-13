using Entities.Enums;
using Entities.Tabuleiro2;
namespace Entities.Xadrez
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
