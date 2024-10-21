namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Corcs cor { get;protected set; }
        public int QtdeMovementos { get;protected set; }
        public Tabuleiro Tab { get;protected set; }

        public Peca(Posicao posicao, Corcs cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            Tab = tab;
            QtdeMovementos = 0;

        }
    }
}
