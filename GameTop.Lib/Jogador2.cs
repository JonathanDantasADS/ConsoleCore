using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Nome {get; set;}

        public Jogador2(string nome = "Ronaldo")
        {
            Nome = nome;
        }
        
        public string Chuta()
        {
            return Nome + " chutou";
        }

        public string Corre()
        {
            return Nome + " correu";
        }

        public string Passe()
        {
            return Nome + " passou";
        }
    }
}