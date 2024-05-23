namespace iCantina.Views
{
    partial class Formulario_Extras
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
            this.textBox_descricaoExtra = new System.Windows.Forms.TextBox();
            this.textBox_precoExtra = new System.Windows.Forms.TextBox();
            this.listBox_Extras = new System.Windows.Forms.ListBox();
            this.button_registarExtra = new System.Windows.Forms.Button();
            this.button_apagarExtra = new System.Windows.Forms.Button();
            this.button_editarExtra = new System.Windows.Forms.Button();
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
            this.label_precoExtra.Size = new System.Drawing.Size(44, 13);
            this.label_precoExtra.TabIndex = 2;
            this.label_precoExtra.Text = "Preco:";
            // 
            // textBox_descricaoExtra
            // 
            this.textBox_descricaoExtra.Location = new System.Drawing.Point(176, 111);
            this.textBox_descricaoExtra.Name = "textBox_descricaoExtra";
            this.textBox_descricaoExtra.Size = new System.Drawing.Size(338, 20);
            this.textBox_descricaoExtra.TabIndex = 3;
            this.textBox_descricaoExtra.TextChanged += new System.EventHandler(this.textBox_descricaoExtra_TextChanged);
            // 
            // textBox_precoExtra
            // 
            this.textBox_precoExtra.Location = new System.Drawing.Point(176, 162);
            this.textBox_precoExtra.Name = "textBox_precoExtra";
            this.textBox_precoExtra.Size = new System.Drawing.Size(338, 20);
            this.textBox_precoExtra.TabIndex = 4;
            // 
            // listBox_Extras
            // 
            this.listBox_Extras.FormattingEnabled = true;
            this.listBox_Extras.Location = new System.Drawing.Point(574, 51);
            this.listBox_Extras.Name = "listBox_Extras";
            this.listBox_Extras.Size = new System.Drawing.Size(257, 264);
            this.listBox_Extras.TabIndex = 5;
            // 
            // button_registarExtra
            // 
            this.button_registarExtra.Location = new System.Drawing.Point(52, 256);
            this.button_registarExtra.Name = "button_registarExtra";
            this.button_registarExtra.Size = new System.Drawing.Size(127, 34);
            this.button_registarExtra.TabIndex = 6;
            this.button_registarExtra.Text = "Registar";
            this.button_registarExtra.UseVisualStyleBackColor = true;
            this.button_registarExtra.Click += new System.EventHandler(this.button_registarExtra_Click);
            // 
            // button_apagarExtra
            // 
            this.button_apagarExtra.Location = new System.Drawing.Point(222, 256);
            this.button_apagarExtra.Name = "button_apagarExtra";
            this.button_apagarExtra.Size = new System.Drawing.Size(127, 34);
            this.button_apagarExtra.TabIndex = 7;
            this.button_apagarExtra.Text = "Apagar";
            this.button_apagarExtra.UseVisualStyleBackColor = true;
            this.button_apagarExtra.Click += new System.EventHandler(this.button_apagarExtra_Click);
            // 
            // button_editarExtra
            // 
            this.button_editarExtra.Location = new System.Drawing.Point(387, 256);
            this.button_editarExtra.Name = "button_editarExtra";
            this.button_editarExtra.Size = new System.Drawing.Size(127, 34);
            this.button_editarExtra.TabIndex = 8;
            this.button_editarExtra.Text = "Editar";
            this.button_editarExtra.UseVisualStyleBackColor = true;
            // 
            // Formulario_Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 342);
            this.Controls.Add(this.button_editarExtra);
            this.Controls.Add(this.button_apagarExtra);
            this.Controls.Add(this.button_registarExtra);
            this.Controls.Add(this.listBox_Extras);
            this.Controls.Add(this.textBox_precoExtra);
            this.Controls.Add(this.textBox_descricaoExtra);
            this.Controls.Add(this.label_precoExtra);
            this.Controls.Add(this.label_descricaoExtra);
            this.Controls.Add(this.checkBox1);
            this.Name = "Formulario_Extras";
            this.Text = "Formulario_Extras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_descricaoExtra;
        private System.Windows.Forms.Label label_precoExtra;
        private System.Windows.Forms.TextBox textBox_descricaoExtra;
        private System.Windows.Forms.TextBox textBox_precoExtra;
        private System.Windows.Forms.ListBox listBox_Extras;
        private System.Windows.Forms.Button button_registarExtra;
        private System.Windows.Forms.Button button_apagarExtra;
        private System.Windows.Forms.Button button_editarExtra;
    }
}