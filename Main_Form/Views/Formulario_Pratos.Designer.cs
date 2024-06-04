namespace iCantina.Views
{
    partial class Formulario_Pratos
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_descricaoExtra = new System.Windows.Forms.Label();
            this.label_precoExtra = new System.Windows.Forms.Label();
            this.textBox_descricaoPrato = new System.Windows.Forms.TextBox();
            this.textBox_tipoPrato = new System.Windows.Forms.TextBox();
            this.listBox_Pratos = new System.Windows.Forms.ListBox();
            this.button_registarPrato = new System.Windows.Forms.Button();
            this.button_apagarPrato = new System.Windows.Forms.Button();
            this.button_editarPrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(461, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ativar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_descricaoExtra
            // 
            this.label_descricaoExtra.AutoSize = true;
            this.label_descricaoExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descricaoExtra.Location = new System.Drawing.Point(90, 111);
            this.label_descricaoExtra.Name = "label_descricaoExtra";
            this.label_descricaoExtra.Size = new System.Drawing.Size(68, 13);
            this.label_descricaoExtra.TabIndex = 1;
            this.label_descricaoExtra.Text = "Descricao:";
            // 
            // label_precoExtra
            // 
            this.label_precoExtra.AutoSize = true;
            this.label_precoExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precoExtra.Location = new System.Drawing.Point(101, 165);
            this.label_precoExtra.Name = "label_precoExtra";
            this.label_precoExtra.Size = new System.Drawing.Size(36, 13);
            this.label_precoExtra.TabIndex = 2;
            this.label_precoExtra.Text = "Tipo:";
            // 
            // textBox_descricaoPrato
            // 
            this.textBox_descricaoPrato.Location = new System.Drawing.Point(176, 111);
            this.textBox_descricaoPrato.Name = "textBox_descricaoPrato";
            this.textBox_descricaoPrato.Size = new System.Drawing.Size(338, 20);
            this.textBox_descricaoPrato.TabIndex = 3;
            // 
            // textBox_tipoPrato
            // 
            this.textBox_tipoPrato.Location = new System.Drawing.Point(176, 162);
            this.textBox_tipoPrato.Name = "textBox_tipoPrato";
            this.textBox_tipoPrato.Size = new System.Drawing.Size(338, 20);
            this.textBox_tipoPrato.TabIndex = 4;
            // 
            // listBox_Pratos
            // 
            this.listBox_Pratos.FormattingEnabled = true;
            this.listBox_Pratos.Location = new System.Drawing.Point(574, 51);
            this.listBox_Pratos.Name = "listBox_Pratos";
            this.listBox_Pratos.Size = new System.Drawing.Size(257, 264);
            this.listBox_Pratos.TabIndex = 5;
            // 
            // button_registarPrato
            // 
            this.button_registarPrato.Location = new System.Drawing.Point(52, 256);
            this.button_registarPrato.Name = "button_registarPrato";
            this.button_registarPrato.Size = new System.Drawing.Size(127, 34);
            this.button_registarPrato.TabIndex = 6;
            this.button_registarPrato.Text = "Registar";
            this.button_registarPrato.UseVisualStyleBackColor = true;
            this.button_registarPrato.Click += new System.EventHandler(this.button_registarPrato_Click);
            // 
            // button_apagarPrato
            // 
            this.button_apagarPrato.Location = new System.Drawing.Point(222, 256);
            this.button_apagarPrato.Name = "button_apagarPrato";
            this.button_apagarPrato.Size = new System.Drawing.Size(127, 34);
            this.button_apagarPrato.TabIndex = 7;
            this.button_apagarPrato.Text = "Apagar";
            this.button_apagarPrato.UseVisualStyleBackColor = true;
            this.button_apagarPrato.Click += new System.EventHandler(this.button_apagarPrato_Click);
            // 
            // button_editarPrato
            // 
            this.button_editarPrato.Location = new System.Drawing.Point(387, 256);
            this.button_editarPrato.Name = "button_editarPrato";
            this.button_editarPrato.Size = new System.Drawing.Size(127, 34);
            this.button_editarPrato.TabIndex = 8;
            this.button_editarPrato.Text = "Editar";
            this.button_editarPrato.UseVisualStyleBackColor = true;
            this.button_editarPrato.Click += new System.EventHandler(this.button_editarPrato_Click);
            // 
            // Formulario_Pratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 342);
            this.Controls.Add(this.button_editarPrato);
            this.Controls.Add(this.button_apagarPrato);
            this.Controls.Add(this.button_registarPrato);
            this.Controls.Add(this.listBox_Pratos);
            this.Controls.Add(this.textBox_tipoPrato);
            this.Controls.Add(this.textBox_descricaoPrato);
            this.Controls.Add(this.label_precoExtra);
            this.Controls.Add(this.label_descricaoExtra);
            this.Controls.Add(this.checkBox1);
            this.Name = "Formulario_Pratos";
            this.Text = "Formulario_Extras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_descricaoExtra;
        private System.Windows.Forms.Label label_precoExtra;
        private System.Windows.Forms.TextBox textBox_descricaoPrato;
        private System.Windows.Forms.TextBox textBox_tipoPrato;
        private System.Windows.Forms.ListBox listBox_Pratos;
        private System.Windows.Forms.Button button_registarPrato;
        private System.Windows.Forms.Button button_apagarPrato;
        private System.Windows.Forms.Button button_editarPrato;
    }
}