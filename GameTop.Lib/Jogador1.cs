using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public string Nome {get; set;}

        public Jogador1(string nome = "Neymar")
        {
            Nome = nome;
        }

        // Chuta
        public string Chuta()
        {
            return Nome + " chutou";
        }

        // Corre
        public string Corre()
        {
           return Nome + " correu"; 
        }

        // Passe
        public string Passe()
        {
            return Nome + " passou";;
        }
    }
}