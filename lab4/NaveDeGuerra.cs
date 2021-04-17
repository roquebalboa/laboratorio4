using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class NaveDeGuerra: Nave, iNave
    {
        
        public NaveDeGuerra(string nome, int nivelCombustivel, int energia, int velocidade, int posiçãoX, int posiçãoY, bool eInimigo)
        {
            Nome = nome;
            NivelCombustivel = nivelCombustivel;
            Energia = energia;
            Velocidade = velocidade;
            Posição = new int[2] { posiçãoX, posiçãoY };
            EInimigo = eInimigo;
            Vivo = true;
        }
        
        public void Atirar()
        {

        }
        public void MoverCima()
        {
            Posição[0] -= Velocidade;
        }
        public void MoverBaixo()
        {
            Posição[0] += Velocidade;
        }
        public void MoverDireita()
        {
            Posição[1] += Velocidade;
        }
        public void MoverEsquerda()
        {
            Posição[1] -= Velocidade;
        }
        public string VerificarDanos()
        {
            return $"Energia Restante de {Nome} = {Energia}";
        }
        public void LimitarEspaço()
        {
            for (int i = 0; i < Posição.Length; i++)
            {
                if (Posição[i] < 1)
                {
                    Posição[i] = 1;
                }
                if (Posição[i] > 20)
                {
                    Posição[i] = 20;
                }
            }
        }

    }
}
