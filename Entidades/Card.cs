namespace PStarsWrapper.Entidades
{
    class Card
    {
        
        public Rank Valor { get; set; }
        public Suits Palo { get; set; }
        public Card(Rank v, Suits p)
        {
            Valor = v;
            Palo = p;
        }
        public override string ToString() //Sobreescribimos principalmente para pruebas de desarrollo
        {
            return Valor + " de " + Palo;
        }
    }
}
