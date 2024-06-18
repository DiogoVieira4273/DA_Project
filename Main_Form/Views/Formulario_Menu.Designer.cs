namespace iCantina.Views
{
    partial class Formulario_Menu
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
            this.listBox_pratos = new System.Windows.Forms.ListBox();
            this.listBox_extras = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.data = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.lista_pratos = new System.Windows.Forms.Label();
            this.lista_extras = new System.Windows.Forms.Label();
            this.label_preco_estudante = new System.Windows.Forms.Label();
            this.label_preco_prof = new System.Windows.Forms.Label();
            this.textBox_precoprof = new System.Windows.Forms.TextBox();
            this.textBox_precoest = new System.Windows.Forms.TextBox();
            this.listBox_menu = new System.Windows.Forms.ListBox();
            this.label_menu = new System.Windows.Forms.Label();
            this.button_criar_menu = new System.Windows.Forms.Button();
            this.button_apagar_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_pratos
            // 
            this.listBox_pratos.FormattingEnabled = true;
            this.listBox_pratos.Location = new System.Drawing.Point(12, 102);
            this.listBox_pratos.Name = "listBox_pratos";
            this.listBox_pratos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_pratos.Size = new System.Drawing.Size(180, 264);
            this.listBox_pratos.TabIndex = 0;
            // 
            // listBox_extras
            // 
            this.listBox_extras.FormattingEnabled = true;
            this.listBox_extras.Location = new System.Drawing.Point(210, 102);
            this.listBox_extras.Name = "listBox_extras";
            this.listBox_extras.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_extras.Size = new System.Drawing.Size(72, 264);
            this.listBox_extras.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(57, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(13, 19);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(38, 13);
            this.data.TabIndex = 4;
            this.data.Text = "Data:";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(13, 48);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(38, 13);
            this.hora.TabIndex = 5;
            this.hora.Text = "Hora:";
            // 
            // lista_pratos
            // 
            this.lista_pratos.AutoSize = true;
            this.lista_pratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_pratos.Location = new System.Drawing.Point(54, 86);
            this.lista_pratos.Name = "lista_pratos";
            this.lista_pratos.Size = new System.Drawing.Size(78, 13);
            this.lista_pratos.TabIndex = 6;
            this.lista_pratos.Text = "Lista Pratos:";
            // 
            // lista_extras
            // 
            this.lista_extras.AutoSize = true;
            this.lista_extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_extras.Location = new System.Drawing.Point(251, 86);
            this.lista_extras.Name = "lista_extras";
            this.lista_extras.Size = new System.Drawing.Size(77, 13);
            this.lista_extras.TabIndex = 7;
            this.lista_extras.Text = "Lista Extras:";
            // 
            // label_preco_estudante
            // 
            this.label_preco_estudante.AutoSize = true;
            this.label_preco_estudante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preco_estudante.Location = new System.Drawing.Point(275, 19);
            this.label_preco_estudante.Name = "label_preco_estudante";
            this.label_preco_estudante.Size = new System.Drawing.Size(133, 13);
            this.label_preco_estudante.TabIndex = 10;
            this.label_preco_estudante.Text = "Preço para estudante:";
            // 
            // label_preco_prof
            // 
            this.label_preco_prof.AutoSize = true;
            this.label_preco_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preco_prof.Location = new System.Drawing.Point(275, 48);
            this.label_preco_prof.Name = "label_preco_prof";
            this.label_preco_prof.Size = new System.Drawing.Size(130, 13);
            this.label_preco_prof.TabIndex = 11;
            this.label_preco_prof.Text = "Preço para Professor:";
            // 
            // textBox_precoprof
            // 
            this.textBox_precoprof.Location = new System.Drawing.Point(411, 49);
            this.textBox_precoprof.Name = "textBox_precoprof";
            this.textBox_precoprof.Size = new System.Drawing.Size(56, 20);
            this.textBox_precoprof.TabIndex = 12;
            // 
            // textBox_precoest
            // 
            this.textBox_precoest.Location = new System.Drawing.Point(411, 19);
            this.textBox_precoest.Name = "textBox_precoest";
            this.textBox_precoest.Size = new System.Drawing.Size(56, 20);
            this.textBox_precoest.TabIndex = 13;
            // 
            // listBox_menu
            // 
            this.listBox_menu.FormattingEnabled = true;
            this.listBox_menu.Location = new System.Drawing.Point(288, 102);
            this.listBox_menu.Name = "listBox_menu";
            this.listBox_menu.Size = new System.Drawing.Size(494, 264);
            this.listBox_menu.TabIndex = 14;
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(571, 86);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(48, 13);
            this.label_menu.TabIndex = 15;
            this.label_menu.Text = "Menus:";
            // 
            // button_criar_menu
            // 
            this.button_criar_menu.Location = new System.Drawing.Point(496, 372);
            this.button_criar_menu.Name = "button_criar_menu";
            this.button_criar_menu.Size = new System.Drawing.Size(92, 23);
            this.button_criar_menu.TabIndex = 18;
            this.button_criar_menu.Text = "Criar";
            this.button_criar_menu.UseVisualStyleBackColor = true;
            this.button_criar_menu.Click += new System.EventHandler(this.button_criar_menu_Click);
            // 
            // button_apagar_menu
            // 
            this.button_apagar_menu.Location = new System.Drawing.Point(604, 372);
            this.button_apagar_menu.Name = "button_apagar_menu";
            this.button_apagar_menu.Size = new System.Drawing.Size(92, 23);
            this.button_apagar_menu.TabIndex = 19;
            this.button_apagar_menu.Text = "Apagar";
            this.button_apagar_menu.UseVisualStyleBackColor = true;
            this.button_apagar_menu.Click += new System.EventHandler(this.button_apagar_menu_Click);
            // 
            // Formulario_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 428);
            this.Controls.Add(this.button_apagar_menu);
            this.Controls.Add(this.button_criar_menu);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.listBox_menu);
            this.Controls.Add(this.textBox_precoest);
            this.Controls.Add(this.textBox_precoprof);
            this.Controls.Add(this.label_preco_prof);
            this.Controls.Add(this.label_preco_estudante);
            this.Controls.Add(this.lista_extras);
            this.Controls.Add(this.lista_pratos);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.data);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox_extras);
            this.Controls.Add(this.listBox_pratos);
            this.Name = "Formulario_Menu";
            this.Text = "Formulario_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_pratos;
        private System.Windows.Forms.ListBox listBox_extras;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label lista_pratos;
        private System.Windows.Forms.Label lista_extras;
        private System.Windows.Forms.Label label_preco_estudante;
        private System.Windows.Forms.Label label_preco_prof;
        private System.Windows.Forms.TextBox textBox_precoprof;
        private System.Windows.Forms.TextBox textBox_precoest;
        private System.Windows.Forms.ListBox listBox_menu;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Button button_criar_menu;
        private System.Windows.Forms.Button button_apagar_menu;
    }
}