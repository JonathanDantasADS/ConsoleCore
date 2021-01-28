using System;
using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly iJogador _Jogador1;
        private readonly iJogador _Jogador2;
        
        public JogoFoda(iJogador jogador1, iJogador jogador2)
        {
            _Jogador1 = jogador1;
            _Jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            Console.WriteLine(_Jogador1.Corre());
            Console.WriteLine(_Jogador1.Chuta());
            Console.WriteLine(_Jogador1.Passe());

            Console.WriteLine(_Jogador2.Corre());
            Console.WriteLine(_Jogador2.Chuta());
            Console.WriteLine(_Jogador2.Passe());
        }
    }
}