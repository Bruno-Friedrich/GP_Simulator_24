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
            UpDwn_Voltas = new NumericUpDown();
            Lbl_Titulo = new Label();
            UpDwn_Retas = new NumericUpDown();
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
            UpDwn_Curvas = new NumericUpDown();
            Cmb_Pais = new ComboBox();
            Lbl_Volta = new Label();
            label9 = new Label();
            label10 = new Label();
            UpDwn_Minutos = new NumericUpDown();
            label8 = new Label();
            UpDwn_Segundos = new NumericUpDown();
            label11 = new Label();
            UpDwn_Milesimos = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Voltas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Retas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Curvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Minutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Segundos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Milesimos).BeginInit();
            SuspendLayout();
            // 
            // UpDwn_Voltas
            // 
            UpDwn_Voltas.Location = new Point(129, 172);
            UpDwn_Voltas.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            UpDwn_Voltas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDwn_Voltas.Name = "UpDwn_Voltas";
            UpDwn_Voltas.RightToLeft = RightToLeft.Yes;
            UpDwn_Voltas.Size = new Size(39, 27);
            UpDwn_Voltas.TabIndex = 0;
            UpDwn_Voltas.Value = new decimal(new int[] { 50, 0, 0, 0 });
            UpDwn_Voltas.ValueChanged += UpDwn_Voltas_ValueChanged;
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
            // UpDwn_Retas
            // 
            UpDwn_Retas.Location = new Point(129, 202);
            UpDwn_Retas.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            UpDwn_Retas.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            UpDwn_Retas.Name = "UpDwn_Retas";
            UpDwn_Retas.RightToLeft = RightToLeft.Yes;
            UpDwn_Retas.Size = new Size(39, 27);
            UpDwn_Retas.TabIndex = 7;
            UpDwn_Retas.Value = new decimal(new int[] { 50, 0, 0, 0 });
            UpDwn_Retas.ValueChanged += UpDwn_Retas_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 89);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
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
            Btn_Confirmar.Click += Btn_Confirmar_Click;
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
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(60, 119);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Circuito:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(86, 149);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 12;
            label3.Text = "País:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(68, 239);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 15;
            label4.Text = "Curvas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(75, 209);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 14;
            label5.Text = "Retas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(71, 179);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 13;
            label6.Text = "Voltas:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(30, 269);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
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
            // UpDwn_Curvas
            // 
            UpDwn_Curvas.Location = new Point(129, 232);
            UpDwn_Curvas.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            UpDwn_Curvas.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            UpDwn_Curvas.Name = "UpDwn_Curvas";
            UpDwn_Curvas.RightToLeft = RightToLeft.Yes;
            UpDwn_Curvas.Size = new Size(39, 27);
            UpDwn_Curvas.TabIndex = 19;
            UpDwn_Curvas.Value = new decimal(new int[] { 50, 0, 0, 0 });
            UpDwn_Curvas.ValueChanged += UpDwn_Curvas_ValueChanged;
            // 
            // Cmb_Pais
            // 
            Cmb_Pais.FormattingEnabled = true;
            Cmb_Pais.Location = new Point(129, 141);
            Cmb_Pais.Name = "Cmb_Pais";
            Cmb_Pais.Size = new Size(245, 28);
            Cmb_Pais.TabIndex = 20;
            // 
            // Lbl_Volta
            // 
            Lbl_Volta.AutoSize = true;
            Lbl_Volta.Location = new Point(165, 173);
            Lbl_Volta.Name = "Lbl_Volta";
            Lbl_Volta.Size = new Size(48, 20);
            Lbl_Volta.TabIndex = 21;
            Lbl_Volta.Text = "voltas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(165, 204);
            label9.Name = "label9";
            label9.Size = new Size(21, 20);
            label9.TabIndex = 22;
            label9.Text = "%";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(164, 234);
            label10.Name = "label10";
            label10.Size = new Size(21, 20);
            label10.TabIndex = 23;
            label10.Text = "%";
            // 
            // UpDwn_Minutos
            // 
            UpDwn_Minutos.Location = new Point(129, 265);
            UpDwn_Minutos.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            UpDwn_Minutos.Name = "UpDwn_Minutos";
            UpDwn_Minutos.RightToLeft = RightToLeft.Yes;
            UpDwn_Minutos.Size = new Size(33, 27);
            UpDwn_Minutos.TabIndex = 24;
            UpDwn_Minutos.UpDownAlign = LeftRightAlignment.Left;
            UpDwn_Minutos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(161, 268);
            label8.Name = "label8";
            label8.Size = new Size(12, 20);
            label8.TabIndex = 25;
            label8.Text = ":";
            // 
            // UpDwn_Segundos
            // 
            UpDwn_Segundos.Location = new Point(171, 265);
            UpDwn_Segundos.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            UpDwn_Segundos.Name = "UpDwn_Segundos";
            UpDwn_Segundos.RightToLeft = RightToLeft.Yes;
            UpDwn_Segundos.Size = new Size(42, 27);
            UpDwn_Segundos.TabIndex = 26;
            UpDwn_Segundos.UpDownAlign = LeftRightAlignment.Left;
            UpDwn_Segundos.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(212, 267);
            label11.Name = "label11";
            label11.Size = new Size(12, 20);
            label11.TabIndex = 27;
            label11.Text = ".";
            // 
            // UpDwn_Milesimos
            // 
            UpDwn_Milesimos.DecimalPlaces = 3;
            UpDwn_Milesimos.Increment = new decimal(new int[] { 50, 0, 0, 196608 });
            UpDwn_Milesimos.Location = new Point(222, 265);
            UpDwn_Milesimos.Maximum = new decimal(new int[] { 950, 0, 0, 196608 });
            UpDwn_Milesimos.Name = "UpDwn_Milesimos";
            UpDwn_Milesimos.RightToLeft = RightToLeft.Yes;
            UpDwn_Milesimos.Size = new Size(48, 27);
            UpDwn_Milesimos.TabIndex = 28;
            UpDwn_Milesimos.UpDownAlign = LeftRightAlignment.Left;
            // 
            // Frm_AddCircuito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 411);
            Controls.Add(UpDwn_Milesimos);
            Controls.Add(UpDwn_Segundos);
            Controls.Add(UpDwn_Minutos);
            Controls.Add(Cmb_Pais);
            Controls.Add(UpDwn_Curvas);
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
            Controls.Add(UpDwn_Retas);
            Controls.Add(Lbl_Titulo);
            Controls.Add(UpDwn_Voltas);
            Controls.Add(Lbl_Volta);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label11);
            Name = "Frm_AddCircuito";
            ShowIcon = false;
            Text = "Editar circuito";
            ((System.ComponentModel.ISupportInitialize)UpDwn_Voltas).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Retas).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Curvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Minutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Segundos).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDwn_Milesimos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown UpDwn_Voltas;
        private Label Lbl_Titulo;
        private NumericUpDown UpDwn_Retas;
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
        private NumericUpDown UpDwn_Curvas;
        private ComboBox Cmb_Pais;
        private Label Lbl_Volta;
        private Label label9;
        private Label label10;
        private NumericUpDown UpDwn_Minutos;
        private Label label8;
        private NumericUpDown UpDwn_Segundos;
        private Label label11;
        private NumericUpDown UpDwn_Milesimos;
    }
}