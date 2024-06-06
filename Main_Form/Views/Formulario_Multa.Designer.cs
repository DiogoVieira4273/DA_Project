namespace iCantina.Views
{
    partial class Formulario_Multa
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
            this.textBox_horasMulta = new System.Windows.Forms.TextBox();
            this.textBox_valorMulta = new System.Windows.Forms.TextBox();
            this.listBox_Multas = new System.Windows.Forms.ListBox();
            this.button_registarMulta = new System.Windows.Forms.Button();
            this.button_editarMulta = new System.Windows.Forms.Button();
            this.button_apagarMulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // textBox_horasMulta
            // 
            this.textBox_horasMulta.Location = new System.Drawing.Point(105, 145);
            this.textBox_horasMulta.Name = "textBox_horasMulta";
            this.textBox_horasMulta.Size = new System.Drawing.Size(444, 20);
            this.textBox_horasMulta.TabIndex = 2;
            // 
            // textBox_valorMulta
            // 
            this.textBox_valorMulta.Location = new System.Drawing.Point(105, 218);
            this.textBox_valorMulta.Name = "textBox_valorMulta";
            this.textBox_valorMulta.Size = new System.Drawing.Size(444, 20);
            this.textBox_valorMulta.TabIndex = 3;
            // 
            // listBox_Multas
            // 
            this.listBox_Multas.FormattingEnabled = true;
            this.listBox_Multas.Location = new System.Drawing.Point(555, 68);
            this.listBox_Multas.Name = "listBox_Multas";
            this.listBox_Multas.Size = new System.Drawing.Size(233, 316);
            this.listBox_Multas.TabIndex = 4;
            // 
            // button_registarMulta
            // 
            this.button_registarMulta.Location = new System.Drawing.Point(105, 281);
            this.button_registarMulta.Name = "button_registarMulta";
            this.button_registarMulta.Size = new System.Drawing.Size(75, 27);
            this.button_registarMulta.TabIndex = 5;
            this.button_registarMulta.Text = "Registar";
            this.button_registarMulta.UseVisualStyleBackColor = true;
            this.button_registarMulta.Click += new System.EventHandler(this.button_registarMulta_Click);
            // 
            // button_editarMulta
            // 
            this.button_editarMulta.Location = new System.Drawing.Point(229, 281);
            this.button_editarMulta.Name = "button_editarMulta";
            this.button_editarMulta.Size = new System.Drawing.Size(80, 30);
            this.button_editarMulta.TabIndex = 6;
            this.button_editarMulta.Text = "Editar";
            this.button_editarMulta.UseVisualStyleBackColor = true;
            this.button_editarMulta.Click += new System.EventHandler(this.button_editarMulta_Click);
            // 
            // button_apagarMulta
            // 
            this.button_apagarMulta.Location = new System.Drawing.Point(344, 281);
            this.button_apagarMulta.Name = "button_apagarMulta";
            this.button_apagarMulta.Size = new System.Drawing.Size(79, 30);
            this.button_apagarMulta.TabIndex = 7;
            this.button_apagarMulta.Text = "Apagar";
            this.button_apagarMulta.UseVisualStyleBackColor = true;
            this.button_apagarMulta.Click += new System.EventHandler(this.button_apagarMulta_Click);
            // 
            // Formulario_Multa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_apagarMulta);
            this.Controls.Add(this.button_editarMulta);
            this.Controls.Add(this.button_registarMulta);
            this.Controls.Add(this.listBox_Multas);
            this.Controls.Add(this.textBox_valorMulta);
            this.Controls.Add(this.textBox_horasMulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_Multa";
            this.Text = "Formulario_Multa";
            this.Load += new System.EventHandler(this.Formulario_Multa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_horasMulta;
        private System.Windows.Forms.TextBox textBox_valorMulta;
        private System.Windows.Forms.ListBox listBox_Multas;
        private System.Windows.Forms.Button button_registarMulta;
        private System.Windows.Forms.Button button_editarMulta;
        private System.Windows.Forms.Button button_apagarMulta;
    }
}