namespace SortsEmCsharp
{
    partial class Form_Output
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_original = new System.Windows.Forms.TextBox();
            this.txt_novo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_original
            // 
            this.txt_original.Location = new System.Drawing.Point(61, 66);
            this.txt_original.Multiline = true;
            this.txt_original.Name = "txt_original";
            this.txt_original.Size = new System.Drawing.Size(667, 147);
            this.txt_original.TabIndex = 0;
            // 
            // txt_novo
            // 
            this.txt_novo.Location = new System.Drawing.Point(61, 243);
            this.txt_novo.Multiline = true;
            this.txt_novo.Name = "txt_novo";
            this.txt_novo.Size = new System.Drawing.Size(667, 147);
            this.txt_novo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elementos Originais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elementos Organizados:";
            // 
            // Form_Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_novo);
            this.Controls.Add(this.txt_original);
            this.Name = "Form_Output";
            this.Text = "Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_original;
        private System.Windows.Forms.TextBox txt_novo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}