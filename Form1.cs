using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nums240075
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            m_colec = new Numeros(DIMENSAO);
            m_TodosInseridos = new int[1000];
            m_QtdTodos = 0;
        }

        private const int DIMENSAO = 075;
        private Numeros m_colec;
        private int[] m_TodosInseridos;
        private int m_QtdTodos;

        private bool Existe(int valor)
        {
            for (int idx = 0; idx < m_QtdTodos; idx++)
            {
                if (m_TodosInseridos[idx] == valor)
                    return true;
            }
            return false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int numero;

            if (!int.TryParse(txtNums.Text, out numero) || numero <= 0)
            {
                MessageBox.Show("Por favor, insira um número inteiro positivo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Existe(numero))
            {
                MessageBox.Show("Número Repetido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Num33Zero3 obj = new Num33Zero3(numero);

            if (obj.Is33Zero3())
            {
                lstResult.Items.Add(numero + ", 33-Zero-3");

                if (!m_colec.AdicionarNumero(obj))
                {
                    MessageBox.Show("Array Cheio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            else
            {
                lstResult.Items.Add(numero + ", Não é 33-Zero-3.");
            }
                m_TodosInseridos[m_QtdTodos] = numero;
                m_QtdTodos++;
                txtNums.Clear();
                txtNums.Focus();
            }
        

        private void btnMenor_Click(object sender, EventArgs e)
        {
            int menor = m_colec.MenorNuemero();
            if (menor == -1)
            {
                MessageBox.Show("Nao existem numeros 33-Zero-3.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Menor numero: " + menor, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for(int idx = 0; idx < lstResult.Items.Count; idx++)
            {
                if (lstResult.Items[idx].ToString() == menor + ", 33-Zero-3")
                {
                    lstResult.SelectedIndex = idx;
                    break;
                }
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Somatório: " + m_colec.Somas(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Numeros 33-Zero-3 Guardados: \n\n" + m_colec.ContArray(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
