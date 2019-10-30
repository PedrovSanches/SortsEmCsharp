using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace SortsEmCsharp
{
    public partial class AppSort : Form
    {
        public AppSort()
        {
            InitializeComponent();
        }
        Random random = new Random();
        Form_Output form_output = new Form_Output();
        Stopwatch sw;

        public static int[] bubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetor;
        }
        public static int[] selectionSort(int[] vetor)
        {
            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            return vetor;
        }
        public static int[] insertionSort(int[] vetor)
        {
            int i, j, atual;
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = atual;
            }
        return vetor;
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {   
            if(form_output == null || form_output.IsDisposed)
                form_output  = new Form_Output();
            try
            {          
                string selected = (list_sort.SelectedItem).ToString();
                int[] dados = new int[100];
                for (int i = 0; i < 100; i++)
                {
                    dados[i] = random.Next(1, 100000);
                }
                // Elementos Originais

                form_output.string_original = string.Join(", ", dados);
                // Elementos Depois do sort
                sw = Stopwatch.StartNew();
                if (selected == "Bubble Sort")
                {
                    form_output.string_novo = string.Join(", ", bubbleSort(dados));
                } else if (selected == "Insertion Sort") {
                    form_output.string_novo = string.Join(", ", insertionSort(dados));
                }
                else if (selected == "Selection Sort")
                {
                    form_output.string_novo = string.Join(", ", selectionSort(dados));
                }
                sw.Stop();
                lbl_tempo.Text = sw.Elapsed.TotalMilliseconds + "s";
                form_output.Show();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
     
        }
        

    private void list_sort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AppSort_Load(object sender, EventArgs e)
        {
            list_sort.SelectedIndex = 0;
        }
    }

}
