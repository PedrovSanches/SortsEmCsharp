namespace SortsEmCsharp
{
    partial class AppSort
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Executar = new System.Windows.Forms.Button();
            this.list_sort = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(354, 306);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(75, 23);
            this.btn_Executar.TabIndex = 0;
            this.btn_Executar.Text = "Executar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // list_sort
            // 
            this.list_sort.FormattingEnabled = true;
            this.list_sort.Items.AddRange(new object[] {
            "Bubble Sort",
            "Insertion Sort",
            "Selection Sort"});
            this.list_sort.Location = new System.Drawing.Point(332, 178);
            this.list_sort.Name = "list_sort";
            this.list_sort.Size = new System.Drawing.Size(120, 95);
            this.list_sort.TabIndex = 1;
            this.list_sort.SelectedIndexChanged += new System.EventHandler(this.list_sort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o tipo de Sort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tempo de Execução:";
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Location = new System.Drawing.Point(481, 358);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(13, 13);
            this.lbl_tempo.TabIndex = 4;
            this.lbl_tempo.Text = "0";
            // 
            // AppSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 461);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_sort);
            this.Controls.Add(this.btn_Executar);
            this.Name = "AppSort";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AppSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.ListBox list_sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tempo;
    }
}

