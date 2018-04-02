namespace Requisição
{
    partial class usuario
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
            this.NMatricula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NMatricula
            // 
            this.NMatricula.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMatricula.ForeColor = System.Drawing.SystemColors.MenuText;
            this.NMatricula.Location = new System.Drawing.Point(95, 34);
            this.NMatricula.MaxLength = 11;
            this.NMatricula.Name = "NMatricula";
            this.NMatricula.Size = new System.Drawing.Size(250, 29);
            this.NMatricula.TabIndex = 0;
            this.NMatricula.Text = "Nº Matricula";
            this.NMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NMatricula.UseWaitCursor = true;
            this.NMatricula.TextChanged += new System.EventHandler(this.NMatricula_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NMatricula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "usuario";
            this.Text = "Entrada de usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NMatricula;
        private System.Windows.Forms.Button button1;
    }
}

