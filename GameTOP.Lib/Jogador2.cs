using GameTop.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona esta chutando";
        }

        public string Corre()
        {
            return "Maradona esta correndo";
        }

        public string Passe()
        {
            return "Maradona esta passando";
        }
    }
}