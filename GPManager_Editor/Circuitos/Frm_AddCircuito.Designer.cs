namespace GPManager_Editor.Circuitos
{
    partial class Frm_AddCircuito
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
            numericUpDown1 = new NumericUpDown();
            Lbl_Titulo = new Label();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            Btn_Confirmar = new Button();
            Btn_Cancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Txt_Nome = new TextBox();
            Txt_Circuito = new TextBox();
            numericUpDown3 = new NumericUpDown();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(129, 172);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.RightToLeft = RightToLeft.Yes;
            numericUpDown1.Size = new Size(39, 27);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Lbl_Titulo.Location = new Point(97, 9);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(193, 40);
            Lbl_Titulo.TabIndex = 6;
            Lbl_Titulo.Text = "Edição do GP";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(129, 202);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.RightToLeft = RightToLeft.Yes;
            numericUpDown2.Size = new Size(39, 27);
            numericUpDown2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 89);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 8;
            label1.Text = "Nome do GP:";
            // 
            // Btn_Confirmar
            // 
            Btn_Confirmar.BackColor = SystemColors.ActiveCaptionText;
            Btn_Confirmar.Font = new Font("Segoe UI", 12F);
            Btn_Confirmar.ForeColor = SystemColors.ButtonHighlight;
            Btn_Confirmar.Location = new Point(12, 357);
            Btn_Confirmar.Name = "Btn_Confirmar";
            Btn_Confirmar.Size = new Size(362, 45);
            Btn_Confirmar.TabIndex = 9;
            Btn_Confirmar.Text = "Confirmar";
            Btn_Confirmar.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.BackColor = SystemColors.ActiveCaptionText;
            Btn_Cancelar.Font = new Font("Segoe UI", 12F);
            Btn_Cancelar.ForeColor = SystemColors.ButtonHighlight;
            Btn_Cancelar.Location = new Point(12, 306);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(362, 45);
            Btn_Cancelar.TabIndex = 10;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 119);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 11;
            label2.Text = "Circuito:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 149);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 12;
            label3.Text = "País:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 239);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 15;
            label4.Text = "Curvas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 209);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 14;
            label5.Text = "Retas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 179);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 13;
            label6.Text = "Voltas:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 269);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 16;
            label7.Text = "Tempo Base:";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Location = new Point(129, 82);
            Txt_Nome.MaxLength = 100;
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(245, 27);
            Txt_Nome.TabIndex = 17;
            // 
            // Txt_Circuito
            // 
            Txt_Circuito.Location = new Point(129, 112);
            Txt_Circuito.MaxLength = 100;
            Txt_Circuito.Name = "Txt_Circuito";
            Txt_Circuito.Size = new Size(245, 27);
            Txt_Circuito.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(129, 232);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.RightToLeft = RightToLeft.Yes;
            numericUpDown3.Size = new Size(39, 27);
            numericUpDown3.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 28);
            comboBox1.TabIndex = 20;
            // 
            // Frm_AddCircuito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 411);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown3);
            Controls.Add(Txt_Circuito);
            Controls.Add(Txt_Nome);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Confirmar);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(Lbl_Titulo);
            Controls.Add(numericUpDown1);
            Name = "Frm_AddCircuito";
            ShowIcon = false;
            Text = "Editar circuito";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label Lbl_Titulo;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Button Btn_Confirmar;
        private Button Btn_Cancelar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Txt_Nome;
        private TextBox Txt_Circuito;
        private NumericUpDown numericUpDown3;
        private ComboBox comboBox1;
    }
}