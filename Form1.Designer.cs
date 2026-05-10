namespace Nums240075
{
    partial class Form1
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
            this.lblNums = new System.Windows.Forms.Label();
            this.txtNums = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNums
            // 
            this.lblNums.AutoSize = true;
            this.lblNums.Location = new System.Drawing.Point(12, 22);
            this.lblNums.Name = "lblNums";
            this.lblNums.Size = new System.Drawing.Size(44, 13);
            this.lblNums.TabIndex = 0;
            this.lblNums.Text = "Número";
            // 
            // txtNums
            // 
            this.txtNums.Location = new System.Drawing.Point(13, 39);
            this.txtNums.Name = "txtNums";
            this.txtNums.Size = new System.Drawing.Size(90, 20);
            this.txtNums.TabIndex = 1;
            this.txtNums.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(135, 36);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(135, 65);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(75, 23);
            this.btnMenor.TabIndex = 4;
            this.btnMenor.Text = "Menor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(216, 65);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 5;
            this.btnSoma.Text = "Somatório";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(15, 111);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(276, 212);
            this.lstResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 341);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtNums);
            this.Controls.Add(this.lblNums);
            this.Name = "Form1";
            this.Text = "Número 33Zero3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNums;
        private System.Windows.Forms.TextBox txtNums;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.ListBox lstResult;
    }
}

