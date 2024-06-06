namespace iCantina.Views
{
    partial class Formulario_Principal
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
            this.button_Funcionarios = new System.Windows.Forms.Button();
            this.button_FormPratos = new System.Windows.Forms.Button();
            this.button_FormExtras = new System.Windows.Forms.Button();
            this.button_FormMenu = new System.Windows.Forms.Button();
            this.button_FormMultas = new System.Windows.Forms.Button();
            this.button_FormReservas = new System.Windows.Forms.Button();
            this.button_FormEstudantes = new System.Windows.Forms.Button();
            this.button_FormProfessores = new System.Windows.Forms.Button();
            this.listBox_ListaFuncionarios = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button_Funcionarios
            // 
            this.button_Funcionarios.Location = new System.Drawing.Point(12, 255);
            this.button_Funcionarios.Name = "button_Funcionarios";
            this.button_Funcionarios.Size = new System.Drawing.Size(130, 39);
            this.button_Funcionarios.TabIndex = 2;
            this.button_Funcionarios.Text = "Funcionarios";
            this.button_Funcionarios.UseVisualStyleBackColor = true;
            this.button_Funcionarios.Click += new System.EventHandler(this.button_FormFuncionarios_Click);
            // 
            // button_FormPratos
            // 
            this.button_FormPratos.Location = new System.Drawing.Point(12, 30);
            this.button_FormPratos.Name = "button_FormPratos";
            this.button_FormPratos.Size = new System.Drawing.Size(130, 39);
            this.button_FormPratos.TabIndex = 3;
            this.button_FormPratos.Text = "Pratos";
            this.button_FormPratos.UseVisualStyleBackColor = true;
            this.button_FormPratos.Click += new System.EventHandler(this.button_FormPratos_Click);
            // 
            // button_FormExtras
            // 
            this.button_FormExtras.Location = new System.Drawing.Point(12, 75);
            this.button_FormExtras.Name = "button_FormExtras";
            this.button_FormExtras.Size = new System.Drawing.Size(130, 39);
            this.button_FormExtras.TabIndex = 4;
            this.button_FormExtras.Text = "Extras";
            this.button_FormExtras.UseVisualStyleBackColor = true;
            this.button_FormExtras.Click += new System.EventHandler(this.button_FormExtras_Click);
            // 
            // button_FormMenu
            // 
            this.button_FormMenu.Location = new System.Drawing.Point(12, 120);
            this.button_FormMenu.Name = "button_FormMenu";
            this.button_FormMenu.Size = new System.Drawing.Size(130, 39);
            this.button_FormMenu.TabIndex = 5;
            this.button_FormMenu.Text = "Menu";
            this.button_FormMenu.UseVisualStyleBackColor = true;
            this.button_FormMenu.Click += new System.EventHandler(this.button_FormMenu_Click);
            // 
            // button_FormMultas
            // 
            this.button_FormMultas.Location = new System.Drawing.Point(12, 165);
            this.button_FormMultas.Name = "button_FormMultas";
            this.button_FormMultas.Size = new System.Drawing.Size(130, 39);
            this.button_FormMultas.TabIndex = 6;
            this.button_FormMultas.Text = "Multas";
            this.button_FormMultas.UseVisualStyleBackColor = true;
            this.button_FormMultas.Click += new System.EventHandler(this.button_FormMultas_Click);
            // 
            // button_FormReservas
            // 
            this.button_FormReservas.Location = new System.Drawing.Point(12, 210);
            this.button_FormReservas.Name = "button_FormReservas";
            this.button_FormReservas.Size = new System.Drawing.Size(130, 39);
            this.button_FormReservas.TabIndex = 7;
            this.button_FormReservas.Text = "Reservas";
            this.button_FormReservas.UseVisualStyleBackColor = true;
            this.button_FormReservas.Click += new System.EventHandler(this.button_FormReservas_Click);
            // 
            // button_FormEstudantes
            // 
            this.button_FormEstudantes.Location = new System.Drawing.Point(12, 300);
            this.button_FormEstudantes.Name = "button_FormEstudantes";
            this.button_FormEstudantes.Size = new System.Drawing.Size(130, 39);
            this.button_FormEstudantes.TabIndex = 8;
            this.button_FormEstudantes.Text = "Estudantes";
            this.button_FormEstudantes.UseVisualStyleBackColor = true;
            this.button_FormEstudantes.Click += new System.EventHandler(this.button_FormEstudantes_Click);
            // 
            // button_FormProfessores
            // 
            this.button_FormProfessores.Location = new System.Drawing.Point(12, 345);
            this.button_FormProfessores.Name = "button_FormProfessores";
            this.button_FormProfessores.Size = new System.Drawing.Size(130, 39);
            this.button_FormProfessores.TabIndex = 9;
            this.button_FormProfessores.Text = "Professores";
            this.button_FormProfessores.UseVisualStyleBackColor = true;
            this.button_FormProfessores.Click += new System.EventHandler(this.button_FormProfessores_Click);
            // 
            // listBox_ListaFuncionarios
            // 
            this.listBox_ListaFuncionarios.FormattingEnabled = true;
            this.listBox_ListaFuncionarios.Location = new System.Drawing.Point(613, 30);
            this.listBox_ListaFuncionarios.Name = "listBox_ListaFuncionarios";
            this.listBox_ListaFuncionarios.Size = new System.Drawing.Size(175, 329);
            this.listBox_ListaFuncionarios.TabIndex = 10;
            this.listBox_ListaFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBox_ListaFuncionarios_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Funcionários:";
            // 
            // Formulario_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_ListaFuncionarios);
            this.Controls.Add(this.button_FormProfessores);
            this.Controls.Add(this.button_FormEstudantes);
            this.Controls.Add(this.button_FormReservas);
            this.Controls.Add(this.button_FormMultas);
            this.Controls.Add(this.button_FormMenu);
            this.Controls.Add(this.button_FormExtras);
            this.Controls.Add(this.button_FormPratos);
            this.Controls.Add(this.button_Funcionarios);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_Principal";
            this.Text = "Formulário_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Funcionarios;
        private System.Windows.Forms.Button button_FormPratos;
        private System.Windows.Forms.Button button_FormExtras;
        private System.Windows.Forms.Button button_FormMenu;
        private System.Windows.Forms.Button button_FormMultas;
        private System.Windows.Forms.Button button_FormReservas;
        private System.Windows.Forms.Button button_FormEstudantes;
        private System.Windows.Forms.Button button_FormProfessores;
        private System.Windows.Forms.ListBox listBox_ListaFuncionarios;
        private System.Windows.Forms.Label label2;
    }
}

