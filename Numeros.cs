using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nums240075
{
    public class Numeros
    {
        private Num33Zero3[] m_numeros;
        private int m_qtdNums;

        public Numeros(int dimensao)
        {
            m_numeros = new Num33Zero3[dimensao];
            m_qtdNums = 0;
        }

        public int QtdNumes
        {
            get { return m_qtdNums; }
        }

        public bool AdicionarNumero(Num33Zero3 num)
        {
            if (m_qtdNums >= m_numeros.Length)
                return false;

            m_numeros[m_qtdNums] = num;
            m_qtdNums++;
            return true;
        }

        public bool ExiteNuemero(int valor)
        {
            for (int idx = 0; idx < m_qtdNums; idx++)
            {
                if (m_numeros[idx].Valor == valor)
                    return true;
            }
            return false;
        }

        public int MenorNuemero()
        {
            if (m_qtdNums == 0)
            {
                return -1;
            }

            int menor = m_numeros[0].Valor;
            for (int idx = 1; idx < m_qtdNums; idx++)
            {
                if (m_numeros[idx].Valor < menor)
                    menor = m_numeros[idx].Valor;
            }
            return menor;
        }

        public long Somas()
        {
            long soma = 0;
            for (int idx = 0; idx < m_qtdNums; idx++)
            {
                soma += m_numeros[idx].Valor;
            }
            return soma;
        }

        public string ContArray()
        {
            if (m_qtdNums == 0)
                return "(Sem Numeros)";

            string texto = "";
            for (int idx = 0; idx < m_qtdNums; idx++)
            {
                texto += m_numeros[idx].Valor + "\n";
            }
            return texto;
        }
    }
}
