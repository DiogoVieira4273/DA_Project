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
            this.button_criarFuncionario = new System.Windows.Forms.Button();
            this.button_FormPratos = new System.Windows.Forms.Button();
            this.button_FormExtras = new System.Windows.Forms.Button();
            this.button_FormMenu = new System.Windows.Forms.Button();
            this.button_FormMultas = new System.Windows.Forms.Button();
            this.button_FormReservas = new System.Windows.Forms.Button();
            this.button_FormClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "fazer depois.....";
            // 
            // button_criarFuncionario
            // 
            this.button_criarFuncionario.Location = new System.Drawing.Point(28, 248);
            this.button_criarFuncionario.Name = "button_criarFuncionario";
            this.button_criarFuncionario.Size = new System.Drawing.Size(114, 23);
            this.button_criarFuncionario.TabIndex = 2;
            this.button_criarFuncionario.Text = "Criar Funcionario";
            this.button_criarFuncionario.UseVisualStyleBackColor = true;
            // 
            // button_FormPratos
            // 
            this.button_FormPratos.Location = new System.Drawing.Point(298, 113);
            this.button_FormPratos.Name = "button_FormPratos";
            this.button_FormPratos.Size = new System.Drawing.Size(150, 48);
            this.button_FormPratos.TabIndex = 3;
            this.button_FormPratos.Text = "Pratos";
            this.button_FormPratos.UseVisualStyleBackColor = true;
            // 
            // button_FormExtras
            // 
            this.button_FormExtras.Location = new System.Drawing.Point(298, 166);
            this.button_FormExtras.Name = "button_FormExtras";
            this.button_FormExtras.Size = new System.Drawing.Size(150, 49);
            this.button_FormExtras.TabIndex = 4;
            this.button_FormExtras.Text = "Extras";
            this.button_FormExtras.UseVisualStyleBackColor = true;
            // 
            // button_FormMenu
            // 
            this.button_FormMenu.Location = new System.Drawing.Point(298, 222);
            this.button_FormMenu.Name = "button_FormMenu";
            this.button_FormMenu.Size = new System.Drawing.Size(150, 49);
            this.button_FormMenu.TabIndex = 5;
            this.button_FormMenu.Text = "Menu";
            this.button_FormMenu.UseVisualStyleBackColor = true;
            // 
            // button_FormMultas
            // 
            this.button_FormMultas.Location = new System.Drawing.Point(478, 112);
            this.button_FormMultas.Name = "button_FormMultas";
            this.button_FormMultas.Size = new System.Drawing.Size(150, 49);
            this.button_FormMultas.TabIndex = 6;
            this.button_FormMultas.Text = "Multas";
            this.button_FormMultas.UseVisualStyleBackColor = true;
            // 
            // button_FormReservas
            // 
            this.button_FormReservas.Location = new System.Drawing.Point(478, 167);
            this.button_FormReservas.Name = "button_FormReservas";
            this.button_FormReservas.Size = new System.Drawing.Size(150, 49);
            this.button_FormReservas.TabIndex = 7;
            this.button_FormReservas.Text = "Reservas";
            this.button_FormReservas.UseVisualStyleBackColor = true;
            // 
            // button_FormClientes
            // 
            this.button_FormClientes.Location = new System.Drawing.Point(478, 222);
            this.button_FormClientes.Name = "button_FormClientes";
            this.button_FormClientes.Size = new System.Drawing.Size(150, 49);
            this.button_FormClientes.TabIndex = 8;
            this.button_FormClientes.Text = "Clientes";
            this.button_FormClientes.UseVisualStyleBackColor = true;
            // 
            // Formulario_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_FormClientes);
            this.Controls.Add(this.button_FormReservas);
            this.Controls.Add(this.button_FormMultas);
            this.Controls.Add(this.button_FormMenu);
            this.Controls.Add(this.button_FormExtras);
            this.Controls.Add(this.button_FormPratos);
            this.Controls.Add(this.button_criarFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_Principal";
            this.Text = "Formulário_Principal";
            this.Load += new System.EventHandler(this.Formulario_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_criarFuncionario;
        private System.Windows.Forms.Button button_FormPratos;
        private System.Windows.Forms.Button button_FormExtras;
        private System.Windows.Forms.Button button_FormMenu;
        private System.Windows.Forms.Button button_FormMultas;
        private System.Windows.Forms.Button button_FormReservas;
        private System.Windows.Forms.Button button_FormClientes;
    }
}

