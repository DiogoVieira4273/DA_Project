namespace iCantina.Views
{
    partial class Formulario_Funcionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.button_Registo = new System.Windows.Forms.Button();
            this.button_Apagar = new System.Windows.Forms.Button();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIF:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(144, 37);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(216, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(144, 74);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(216, 20);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(144, 110);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(216, 20);
            this.textBoxNIF.TabIndex = 5;
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(384, 37);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(266, 225);
            this.listBoxFuncionarios.TabIndex = 6;
            // 
            // button_Registo
            // 
            this.button_Registo.Location = new System.Drawing.Point(42, 186);
            this.button_Registo.Name = "button_Registo";
            this.button_Registo.Size = new System.Drawing.Size(94, 37);
            this.button_Registo.TabIndex = 7;
            this.button_Registo.Text = "Registar";
            this.button_Registo.UseVisualStyleBackColor = true;
            this.button_Registo.Click += new System.EventHandler(this.button_Registo_Click);
            // 
            // button_Apagar
            // 
            this.button_Apagar.Location = new System.Drawing.Point(165, 186);
            this.button_Apagar.Name = "button_Apagar";
            this.button_Apagar.Size = new System.Drawing.Size(94, 37);
            this.button_Apagar.TabIndex = 8;
            this.button_Apagar.Text = "Apagar";
            this.button_Apagar.UseVisualStyleBackColor = true;
            this.button_Apagar.Click += new System.EventHandler(this.button_Apagar_Click);
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(284, 186);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(94, 37);
            this.button_Guardar.TabIndex = 9;
            this.button_Guardar.Text = "Editar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // Formulario_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 290);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.button_Apagar);
            this.Controls.Add(this.button_Registo);
            this.Controls.Add(this.listBoxFuncionarios);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_Funcionario";
            this.Text = "Formulário_Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.ListBox listBoxFuncionarios;
        private System.Windows.Forms.Button button_Registo;
        private System.Windows.Forms.Button button_Apagar;
        private System.Windows.Forms.Button button_Guardar;
    }
}