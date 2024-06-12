namespace iCantina.Views
{
    partial class Formulario_Estudante
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
            this.button_addEstudante = new System.Windows.Forms.Button();
            this.button_apagarEstudante = new System.Windows.Forms.Button();
            this.button_editarEstudante = new System.Windows.Forms.Button();
            this.label_nomeEstudante = new System.Windows.Forms.Label();
            this.label_nifEstudante = new System.Windows.Forms.Label();
            this.label_saldoEstudante = new System.Windows.Forms.Label();
            this.label_Nestudante = new System.Windows.Forms.Label();
            this.textBox_nomeEstudante = new System.Windows.Forms.TextBox();
            this.textBox_nifEstudante = new System.Windows.Forms.TextBox();
            this.textBox_saldoEstudante = new System.Windows.Forms.TextBox();
            this.textBox_nEstudante = new System.Windows.Forms.TextBox();
            this.listBox_estudante = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_addEstudante
            // 
            this.button_addEstudante.Location = new System.Drawing.Point(44, 313);
            this.button_addEstudante.Name = "button_addEstudante";
            this.button_addEstudante.Size = new System.Drawing.Size(120, 41);
            this.button_addEstudante.TabIndex = 0;
            this.button_addEstudante.Text = "Registar";
            this.button_addEstudante.UseVisualStyleBackColor = true;
            this.button_addEstudante.Click += new System.EventHandler(this.button_addEstudante_Click);
            // 
            // button_apagarEstudante
            // 
            this.button_apagarEstudante.Location = new System.Drawing.Point(195, 313);
            this.button_apagarEstudante.Name = "button_apagarEstudante";
            this.button_apagarEstudante.Size = new System.Drawing.Size(120, 41);
            this.button_apagarEstudante.TabIndex = 1;
            this.button_apagarEstudante.Text = "Apagar";
            this.button_apagarEstudante.UseVisualStyleBackColor = true;
            this.button_apagarEstudante.Click += new System.EventHandler(this.button_apagarEstudante_Click);
            // 
            // button_editarEstudante
            // 
            this.button_editarEstudante.Location = new System.Drawing.Point(335, 313);
            this.button_editarEstudante.Name = "button_editarEstudante";
            this.button_editarEstudante.Size = new System.Drawing.Size(120, 41);
            this.button_editarEstudante.TabIndex = 2;
            this.button_editarEstudante.Text = "Editar";
            this.button_editarEstudante.UseVisualStyleBackColor = true;
            this.button_editarEstudante.Click += new System.EventHandler(this.button_editarEstudante_Click);
            // 
            // label_nomeEstudante
            // 
            this.label_nomeEstudante.AutoSize = true;
            this.label_nomeEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeEstudante.Location = new System.Drawing.Point(60, 75);
            this.label_nomeEstudante.Name = "label_nomeEstudante";
            this.label_nomeEstudante.Size = new System.Drawing.Size(99, 13);
            this.label_nomeEstudante.TabIndex = 3;
            this.label_nomeEstudante.Text = "Nome Completo:";
            // 
            // label_nifEstudante
            // 
            this.label_nifEstudante.AutoSize = true;
            this.label_nifEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nifEstudante.Location = new System.Drawing.Point(60, 101);
            this.label_nifEstudante.Name = "label_nifEstudante";
            this.label_nifEstudante.Size = new System.Drawing.Size(31, 13);
            this.label_nifEstudante.TabIndex = 4;
            this.label_nifEstudante.Text = "NIF:";
            // 
            // label_saldoEstudante
            // 
            this.label_saldoEstudante.AutoSize = true;
            this.label_saldoEstudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saldoEstudante.Location = new System.Drawing.Point(60, 128);
            this.label_saldoEstudante.Name = "label_saldoEstudante";
            this.label_saldoEstudante.Size = new System.Drawing.Size(43, 13);
            this.label_saldoEstudante.TabIndex = 5;
            this.label_saldoEstudante.Text = "Saldo:";
            // 
            // label_Nestudante
            // 
            this.label_Nestudante.AutoSize = true;
            this.label_Nestudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nestudante.Location = new System.Drawing.Point(60, 153);
            this.label_Nestudante.Name = "label_Nestudante";
            this.label_Nestudante.Size = new System.Drawing.Size(115, 13);
            this.label_Nestudante.TabIndex = 6;
            this.label_Nestudante.Text = "Numero Estudante:";
            // 
            // textBox_nomeEstudante
            // 
            this.textBox_nomeEstudante.Location = new System.Drawing.Point(195, 75);
            this.textBox_nomeEstudante.Name = "textBox_nomeEstudante";
            this.textBox_nomeEstudante.Size = new System.Drawing.Size(260, 20);
            this.textBox_nomeEstudante.TabIndex = 7;
            // 
            // textBox_nifEstudante
            // 
            this.textBox_nifEstudante.Location = new System.Drawing.Point(195, 101);
            this.textBox_nifEstudante.Name = "textBox_nifEstudante";
            this.textBox_nifEstudante.Size = new System.Drawing.Size(260, 20);
            this.textBox_nifEstudante.TabIndex = 8;
            // 
            // textBox_saldoEstudante
            // 
            this.textBox_saldoEstudante.Location = new System.Drawing.Point(195, 127);
            this.textBox_saldoEstudante.Name = "textBox_saldoEstudante";
            this.textBox_saldoEstudante.Size = new System.Drawing.Size(260, 20);
            this.textBox_saldoEstudante.TabIndex = 9;
            // 
            // textBox_nEstudante
            // 
            this.textBox_nEstudante.Location = new System.Drawing.Point(195, 153);
            this.textBox_nEstudante.Name = "textBox_nEstudante";
            this.textBox_nEstudante.Size = new System.Drawing.Size(260, 20);
            this.textBox_nEstudante.TabIndex = 10;
            // 
            // listBox_estudante
            // 
            this.listBox_estudante.FormattingEnabled = true;
            this.listBox_estudante.Location = new System.Drawing.Point(476, 75);
            this.listBox_estudante.Name = "listBox_estudante";
            this.listBox_estudante.Size = new System.Drawing.Size(287, 277);
            this.listBox_estudante.TabIndex = 11;
            // 
            // Formulario_Estudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 376);
            this.Controls.Add(this.listBox_estudante);
            this.Controls.Add(this.textBox_nEstudante);
            this.Controls.Add(this.textBox_saldoEstudante);
            this.Controls.Add(this.textBox_nifEstudante);
            this.Controls.Add(this.textBox_nomeEstudante);
            this.Controls.Add(this.label_Nestudante);
            this.Controls.Add(this.label_saldoEstudante);
            this.Controls.Add(this.label_nifEstudante);
            this.Controls.Add(this.label_nomeEstudante);
            this.Controls.Add(this.button_editarEstudante);
            this.Controls.Add(this.button_apagarEstudante);
            this.Controls.Add(this.button_addEstudante);
            this.Name = "Formulario_Estudante";
            this.Text = "Formulario_Estudante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addEstudante;
        private System.Windows.Forms.Button button_apagarEstudante;
        private System.Windows.Forms.Button button_editarEstudante;
        private System.Windows.Forms.Label label_nomeEstudante;
        private System.Windows.Forms.Label label_nifEstudante;
        private System.Windows.Forms.Label label_saldoEstudante;
        private System.Windows.Forms.Label label_Nestudante;
        private System.Windows.Forms.TextBox textBox_nomeEstudante;
        private System.Windows.Forms.TextBox textBox_nifEstudante;
        private System.Windows.Forms.TextBox textBox_saldoEstudante;
        private System.Windows.Forms.TextBox textBox_nEstudante;
        private System.Windows.Forms.ListBox listBox_estudante;
    }
}