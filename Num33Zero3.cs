using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nums240075
{
    public class Num33Zero3
    {

        private int m_num;

        public Num33Zero3(int num)
        {
            m_num = num;
        }

        public int Valor
        {
            get { return m_num; }
        }

        public bool Is33Zero3()
        {
            string numis = m_num.ToString();
            if (numis.Contains("3"))
                return false;

            int soma = 0;
            foreach(char carc in numis)
            {
                soma += (int)char.GetNumericValue(carc);
            }
            return soma == 33;
        }
    }
}
