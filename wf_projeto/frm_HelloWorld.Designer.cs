
namespace wf_projeto
{
    partial class frm_HelloWorld
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ModificaLabel = new System.Windows.Forms.Button();
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Titulo.Location = new System.Drawing.Point(42, 36);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(209, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "VisualStudio .NET Version";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(575, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "fechar aplicação";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ModificaLabel
            // 
            this.btn_ModificaLabel.Location = new System.Drawing.Point(46, 79);
            this.btn_ModificaLabel.Name = "btn_ModificaLabel";
            this.btn_ModificaLabel.Size = new System.Drawing.Size(205, 23);
            this.btn_ModificaLabel.TabIndex = 2;
            this.btn_ModificaLabel.Text = "Modifica texto da Label";
            this.btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.btn_ModificaLabel.Click += new System.EventHandler(this.btn_ModificaLabel_Click);
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(46, 124);
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(205, 26);
            this.txt_ConteudoLabel.TabIndex = 3;
            this.txt_ConteudoLabel.TextChanged += new System.EventHandler(this.txt_ConteudoLabel_TextChanged);
            // 
            // frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1333, 658);
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.btn_ModificaLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.frm_HelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ModificaLabel;
        private System.Windows.Forms.TextBox txt_ConteudoLabel;
    }
}

