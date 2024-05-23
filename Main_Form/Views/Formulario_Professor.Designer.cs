namespace iCantina.Views
{
    partial class Formulario_Professor
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
            this.listBox_Professor = new System.Windows.Forms.ListBox();
            this.button_registarProfessor = new System.Windows.Forms.Button();
            this.button_apagarProfessor = new System.Windows.Forms.Button();
            this.button_editarProfessor = new System.Windows.Forms.Button();
            this.label_nomeProf = new System.Windows.Forms.Label();
            this.label_nifPRof = new System.Windows.Forms.Label();
            this.label_saldoProf = new System.Windows.Forms.Label();
            this.label_emailProf = new System.Windows.Forms.Label();
            this.textBox_nomeProf = new System.Windows.Forms.TextBox();
            this.textBox_nifProf = new System.Windows.Forms.TextBox();
            this.textBox_saldoProf = new System.Windows.Forms.TextBox();
            this.textBox_emailProf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_Professor
            // 
            this.listBox_Professor.FormattingEnabled = true;
            this.listBox_Professor.Location = new System.Drawing.Point(544, 63);
            this.listBox_Professor.Name = "listBox_Professor";
            this.listBox_Professor.Size = new System.Drawing.Size(235, 355);
            this.listBox_Professor.TabIndex = 0;
            // 
            // button_registarProfessor
            // 
            this.button_registarProfessor.Location = new System.Drawing.Point(35, 310);
            this.button_registarProfessor.Name = "button_registarProfessor";
            this.button_registarProfessor.Size = new System.Drawing.Size(117, 41);
            this.button_registarProfessor.TabIndex = 1;
            this.button_registarProfessor.Text = "Registar";
            this.button_registarProfessor.UseVisualStyleBackColor = true;
            this.button_registarProfessor.Click += new System.EventHandler(this.button_registarProfessor_Click);
            // 
            // button_apagarProfessor
            // 
            this.button_apagarProfessor.Location = new System.Drawing.Point(194, 310);
            this.button_apagarProfessor.Name = "button_apagarProfessor";
            this.button_apagarProfessor.Size = new System.Drawing.Size(117, 41);
            this.button_apagarProfessor.TabIndex = 2;
            this.button_apagarProfessor.Text = "Apagar";
            this.button_apagarProfessor.UseVisualStyleBackColor = true;
            this.button_apagarProfessor.Click += new System.EventHandler(this.button_apagarProfessor_Click);
            // 
            // button_editarProfessor
            // 
            this.button_editarProfessor.Location = new System.Drawing.Point(355, 310);
            this.button_editarProfessor.Name = "button_editarProfessor";
            this.button_editarProfessor.Size = new System.Drawing.Size(117, 41);
            this.button_editarProfessor.TabIndex = 3;
            this.button_editarProfessor.Text = "Editar";
            this.button_editarProfessor.UseVisualStyleBackColor = true;
            this.button_editarProfessor.Click += new System.EventHandler(this.button_editarProfessor_Click);
            // 
            // label_nomeProf
            // 
            this.label_nomeProf.AutoSize = true;
            this.label_nomeProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeProf.Location = new System.Drawing.Point(54, 82);
            this.label_nomeProf.Name = "label_nomeProf";
            this.label_nomeProf.Size = new System.Drawing.Size(99, 13);
            this.label_nomeProf.TabIndex = 4;
            this.label_nomeProf.Text = "Nome Completo:";
            // 
            // label_nifPRof
            // 
            this.label_nifPRof.AutoSize = true;
            this.label_nifPRof.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nifPRof.Location = new System.Drawing.Point(54, 112);
            this.label_nifPRof.Name = "label_nifPRof";
            this.label_nifPRof.Size = new System.Drawing.Size(31, 13);
            this.label_nifPRof.TabIndex = 5;
            this.label_nifPRof.Text = "NIF:";
            // 
            // label_saldoProf
            // 
            this.label_saldoProf.AutoSize = true;
            this.label_saldoProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saldoProf.Location = new System.Drawing.Point(54, 142);
            this.label_saldoProf.Name = "label_saldoProf";
            this.label_saldoProf.Size = new System.Drawing.Size(43, 13);
            this.label_saldoProf.TabIndex = 6;
            this.label_saldoProf.Text = "Saldo:";
            // 
            // label_emailProf
            // 
            this.label_emailProf.AutoSize = true;
            this.label_emailProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emailProf.Location = new System.Drawing.Point(54, 169);
            this.label_emailProf.Name = "label_emailProf";
            this.label_emailProf.Size = new System.Drawing.Size(41, 13);
            this.label_emailProf.TabIndex = 7;
            this.label_emailProf.Text = "Email:";
            // 
            // textBox_nomeProf
            // 
            this.textBox_nomeProf.Location = new System.Drawing.Point(174, 82);
            this.textBox_nomeProf.Name = "textBox_nomeProf";
            this.textBox_nomeProf.Size = new System.Drawing.Size(254, 20);
            this.textBox_nomeProf.TabIndex = 8;
            // 
            // textBox_nifProf
            // 
            this.textBox_nifProf.Location = new System.Drawing.Point(174, 109);
            this.textBox_nifProf.Name = "textBox_nifProf";
            this.textBox_nifProf.Size = new System.Drawing.Size(254, 20);
            this.textBox_nifProf.TabIndex = 9;
            // 
            // textBox_saldoProf
            // 
            this.textBox_saldoProf.Location = new System.Drawing.Point(174, 139);
            this.textBox_saldoProf.Name = "textBox_saldoProf";
            this.textBox_saldoProf.Size = new System.Drawing.Size(254, 20);
            this.textBox_saldoProf.TabIndex = 10;
            // 
            // textBox_emailProf
            // 
            this.textBox_emailProf.Location = new System.Drawing.Point(174, 166);
            this.textBox_emailProf.Name = "textBox_emailProf";
            this.textBox_emailProf.Size = new System.Drawing.Size(254, 20);
            this.textBox_emailProf.TabIndex = 11;
            // 
            // Formulario_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_emailProf);
            this.Controls.Add(this.textBox_saldoProf);
            this.Controls.Add(this.textBox_nifProf);
            this.Controls.Add(this.textBox_nomeProf);
            this.Controls.Add(this.label_emailProf);
            this.Controls.Add(this.label_saldoProf);
            this.Controls.Add(this.label_nifPRof);
            this.Controls.Add(this.label_nomeProf);
            this.Controls.Add(this.button_editarProfessor);
            this.Controls.Add(this.button_apagarProfessor);
            this.Controls.Add(this.button_registarProfessor);
            this.Controls.Add(this.listBox_Professor);
            this.Name = "Formulario_Professor";
            this.Text = "Formulario_Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Professor;
        private System.Windows.Forms.Button button_registarProfessor;
        private System.Windows.Forms.Button button_apagarProfessor;
        private System.Windows.Forms.Button button_editarProfessor;
        private System.Windows.Forms.Label label_nomeProf;
        private System.Windows.Forms.Label label_nifPRof;
        private System.Windows.Forms.Label label_saldoProf;
        private System.Windows.Forms.Label label_emailProf;
        private System.Windows.Forms.TextBox textBox_nomeProf;
        private System.Windows.Forms.TextBox textBox_nifProf;
        private System.Windows.Forms.TextBox textBox_saldoProf;
        private System.Windows.Forms.TextBox textBox_emailProf;
    }
}