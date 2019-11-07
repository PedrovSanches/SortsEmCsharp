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
        public static int[] shellSort(int[] vetor)
        {
            int h = 1;
            int n = vetor.Length;

            while (h < n)
            {
                h = h * 3 + 1;
            }

            h = h / 3;
            int c, j;
            while (h > 0)
            {
                for (int i = h; i < n; i++)
                {
                    c = vetor[i];
                    j = i;
                    while (j >= h && vetor[j - h] > c)
			        {
                            vetor[j] = vetor[j - h];
                            j = j - h;
                    }
                    vetor[j] = c;
                }
                h = h / 2;
            
            }
            return vetor;
        }
        public static int[] cocktailSort(int[] vetor)
        {
            int tamanho, inicio, fim, swap, aux;
            tamanho = vetor.Length;
            inicio = 0;
            fim = tamanho - 1;
            swap = 0;
            while (swap == 0 && inicio < fim)
	{
                swap = 1;
                for (int i = inicio; i < fim; i = i + 1)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        swap = 0;
                    }
                }

                fim = fim - 1;

                for (int i = fim; i > inicio; i = i - 1)
                {
                    if (vetor[i] < vetor[i - 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i - 1];
                        vetor[i - 1] = aux;
                        swap = 0;
                    }
                }

                inicio = inicio + 1;
            }

            return vetor;
        }
        public static int[] gnomeSort(int[] vetor)
        {
            int p = 0;
            int aux;
            while (p < (vetor.Length - 1))
            {
                if (vetor[p] > vetor[p + 1])
                {
                    aux = vetor[p];
                    vetor[p] = vetor[p + 1];
                    vetor[p + 1] = aux;
                    if (p > 0)
                    {
                        p -= 2;
                    }
                }
                p++;
            }

            return vetor;
        }
        public static int[] combSort(int[] vetor)
        {
            int gap = vetor.Length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                {
                    gap = (int)(gap / 1.247330950103979);
                }

                int i = 0;
                swapped = false;
                while (i + gap < vetor.Length)
                {
                    if (vetor[i].CompareTo(vetor[i + gap]) > 0)
                    {
                        int t = vetor[i];
                        vetor[i] = vetor[i + gap];
                        vetor[i + gap] = t;
                        swapped = true;
                    }
                    i++;
                }
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
                else if (selected == "Shell Sort")
                {
                    form_output.string_novo = string.Join(", ", shellSort(dados));
                }
                else if (selected == "Cocktail Sort")
                {
                    form_output.string_novo = string.Join(", ", cocktailSort(dados));
                }
                else if (selected == "Comb Sort")
                {
                    form_output.string_novo = string.Join(", ", combSort(dados));
                }
                else if (selected == "Gnome Sort")
                {
                    form_output.string_novo = string.Join(", ", gnomeSort(dados));
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
