namespace iCantina.Views
{
    partial class Formulario_Reserva
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
            this.listBox_estudantes = new System.Windows.Forms.ListBox();
            this.listBox_Professores = new System.Windows.Forms.ListBox();
            this.clientes = new System.Windows.Forms.Label();
            this.listBox_menus = new System.Windows.Forms.ListBox();
            this.menus = new System.Windows.Forms.Label();
            this.listBox_pratosdomenu = new System.Windows.Forms.ListBox();
            this.listBox_extrasdomenu = new System.Windows.Forms.ListBox();
            this.button_criarReserva = new System.Windows.Forms.Button();
            this.listBox_reserva = new System.Windows.Forms.ListBox();
            this.listBox_multas = new System.Windows.Forms.ListBox();
            this.label_multa = new System.Windows.Forms.Label();
            this.button_apagar_reserva = new System.Windows.Forms.Button();
            this.button_marcarReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_estudantes
            // 
            this.listBox_estudantes.FormattingEnabled = true;
            this.listBox_estudantes.Location = new System.Drawing.Point(3, 25);
            this.listBox_estudantes.Name = "listBox_estudantes";
            this.listBox_estudantes.Size = new System.Drawing.Size(185, 212);
            this.listBox_estudantes.TabIndex = 0;
            // 
            // listBox_Professores
            // 
            this.listBox_Professores.FormattingEnabled = true;
            this.listBox_Professores.Location = new System.Drawing.Point(194, 25);
            this.listBox_Professores.Name = "listBox_Professores";
            this.listBox_Professores.Size = new System.Drawing.Size(185, 212);
            this.listBox_Professores.TabIndex = 1;
            // 
            // clientes
            // 
            this.clientes.AutoSize = true;
            this.clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes.Location = new System.Drawing.Point(166, 9);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(52, 13);
            this.clientes.TabIndex = 2;
            this.clientes.Text = "Clientes";
            // 
            // listBox_menus
            // 
            this.listBox_menus.FormattingEnabled = true;
            this.listBox_menus.Location = new System.Drawing.Point(432, 25);
            this.listBox_menus.Name = "listBox_menus";
            this.listBox_menus.Size = new System.Drawing.Size(513, 82);
            this.listBox_menus.TabIndex = 3;
            this.listBox_menus.SelectedIndexChanged += new System.EventHandler(this.listBox_menus_SelectedIndexChanged);
            // 
            // menus
            // 
            this.menus.AutoSize = true;
            this.menus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menus.Location = new System.Drawing.Point(643, 9);
            this.menus.Name = "menus";
            this.menus.Size = new System.Drawing.Size(44, 13);
            this.menus.TabIndex = 4;
            this.menus.Text = "Menus";
            // 
            // listBox_pratosdomenu
            // 
            this.listBox_pratosdomenu.FormattingEnabled = true;
            this.listBox_pratosdomenu.Location = new System.Drawing.Point(541, 113);
            this.listBox_pratosdomenu.Name = "listBox_pratosdomenu";
            this.listBox_pratosdomenu.Size = new System.Drawing.Size(120, 121);
            this.listBox_pratosdomenu.TabIndex = 5;
            // 
            // listBox_extrasdomenu
            // 
            this.listBox_extrasdomenu.FormattingEnabled = true;
            this.listBox_extrasdomenu.Location = new System.Drawing.Point(667, 113);
            this.listBox_extrasdomenu.Name = "listBox_extrasdomenu";
            this.listBox_extrasdomenu.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_extrasdomenu.Size = new System.Drawing.Size(120, 121);
            this.listBox_extrasdomenu.TabIndex = 6;
            // 
            // button_criarReserva
            // 
            this.button_criarReserva.Location = new System.Drawing.Point(415, 475);
            this.button_criarReserva.Name = "button_criarReserva";
            this.button_criarReserva.Size = new System.Drawing.Size(140, 26);
            this.button_criarReserva.TabIndex = 7;
            this.button_criarReserva.Text = "Criar reserva";
            this.button_criarReserva.UseVisualStyleBackColor = true;
            this.button_criarReserva.Click += new System.EventHandler(this.button_criarReserva_Click);
            // 
            // listBox_reserva
            // 
            this.listBox_reserva.FormattingEnabled = true;
            this.listBox_reserva.Location = new System.Drawing.Point(354, 257);
            this.listBox_reserva.Name = "listBox_reserva";
            this.listBox_reserva.Size = new System.Drawing.Size(613, 212);
            this.listBox_reserva.TabIndex = 8;
            // 
            // listBox_multas
            // 
            this.listBox_multas.FormattingEnabled = true;
            this.listBox_multas.Location = new System.Drawing.Point(3, 275);
            this.listBox_multas.Name = "listBox_multas";
            this.listBox_multas.Size = new System.Drawing.Size(185, 199);
            this.listBox_multas.TabIndex = 11;
            // 
            // label_multa
            // 
            this.label_multa.AutoSize = true;
            this.label_multa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_multa.Location = new System.Drawing.Point(59, 257);
            this.label_multa.Name = "label_multa";
            this.label_multa.Size = new System.Drawing.Size(48, 13);
            this.label_multa.TabIndex = 12;
            this.label_multa.Text = "Multas:";
            // 
            // button_apagar_reserva
            // 
            this.button_apagar_reserva.Location = new System.Drawing.Point(595, 475);
            this.button_apagar_reserva.Name = "button_apagar_reserva";
            this.button_apagar_reserva.Size = new System.Drawing.Size(140, 26);
            this.button_apagar_reserva.TabIndex = 13;
            this.button_apagar_reserva.Text = "Apagar Reserva";
            this.button_apagar_reserva.UseVisualStyleBackColor = true;
            this.button_apagar_reserva.Click += new System.EventHandler(this.button_apagar_reserva_Click);
            // 
            // button_marcarReserva
            // 
            this.button_marcarReserva.Location = new System.Drawing.Point(773, 475);
            this.button_marcarReserva.Name = "button_marcarReserva";
            this.button_marcarReserva.Size = new System.Drawing.Size(140, 26);
            this.button_marcarReserva.TabIndex = 14;
            this.button_marcarReserva.Text = "Marcar Reserva";
            this.button_marcarReserva.UseVisualStyleBackColor = true;
            this.button_marcarReserva.Click += new System.EventHandler(this.button_marcarReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Reservas:";
            // 
            // Formulario_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_marcarReserva);
            this.Controls.Add(this.button_apagar_reserva);
            this.Controls.Add(this.label_multa);
            this.Controls.Add(this.listBox_multas);
            this.Controls.Add(this.listBox_reserva);
            this.Controls.Add(this.button_criarReserva);
            this.Controls.Add(this.listBox_extrasdomenu);
            this.Controls.Add(this.listBox_pratosdomenu);
            this.Controls.Add(this.menus);
            this.Controls.Add(this.listBox_menus);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.listBox_Professores);
            this.Controls.Add(this.listBox_estudantes);
            this.Name = "Formulario_Reserva";
            this.Text = "Formulario_Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_estudantes;
        private System.Windows.Forms.ListBox listBox_Professores;
        private System.Windows.Forms.Label clientes;
        private System.Windows.Forms.ListBox listBox_menus;
        private System.Windows.Forms.Label menus;
        private System.Windows.Forms.ListBox listBox_pratosdomenu;
        private System.Windows.Forms.ListBox listBox_extrasdomenu;
        private System.Windows.Forms.Button button_criarReserva;
        private System.Windows.Forms.ListBox listBox_reserva;
        private System.Windows.Forms.ListBox listBox_multas;
        private System.Windows.Forms.Label label_multa;
        private System.Windows.Forms.Button button_apagar_reserva;
        private System.Windows.Forms.Button button_marcarReserva;
        private System.Windows.Forms.Label label1;
    }
}