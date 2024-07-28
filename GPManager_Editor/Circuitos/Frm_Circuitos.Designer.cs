namespace GPManager_Editor.Circuitos
{
    partial class Frm_Circuitos
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
            Btn_Voltar = new Button();
            Btn_AddProva = new Button();
            Lbl_Titulo = new Label();
            Dt_Circuitos = new DataGridView();
            Btn_Sobe = new Button();
            Btn_Desce = new Button();
            Btn_DelProva = new Button();
            ((System.ComponentModel.ISupportInitialize)Dt_Circuitos).BeginInit();
            SuspendLayout();
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = SystemColors.ActiveCaptionText;
            Btn_Voltar.Font = new Font("Segoe UI", 12F);
            Btn_Voltar.ForeColor = SystemColors.ButtonHighlight;
            Btn_Voltar.Location = new Point(12, 477);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(853, 45);
            Btn_Voltar.TabIndex = 0;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Btn_AddProva
            // 
            Btn_AddProva.BackColor = SystemColors.ActiveCaptionText;
            Btn_AddProva.Font = new Font("Segoe UI", 12F);
            Btn_AddProva.ForeColor = SystemColors.ButtonHighlight;
            Btn_AddProva.Location = new Point(12, 426);
            Btn_AddProva.Name = "Btn_AddProva";
            Btn_AddProva.Size = new Size(202, 45);
            Btn_AddProva.TabIndex = 1;
            Btn_AddProva.Text = "Adicionar Prova";
            Btn_AddProva.UseVisualStyleBackColor = false;
            Btn_AddProva.Click += Btn_AddProva_Click;
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Lbl_Titulo.Location = new Point(380, 9);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(138, 40);
            Lbl_Titulo.TabIndex = 5;
            Lbl_Titulo.Text = "Circuitos";
            // 
            // Dt_Circuitos
            // 
            Dt_Circuitos.AllowUserToAddRows = false;
            Dt_Circuitos.AllowUserToDeleteRows = false;
            Dt_Circuitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Circuitos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Circuitos.EnableHeadersVisualStyles = false;
            Dt_Circuitos.Location = new Point(12, 56);
            Dt_Circuitos.MultiSelect = false;
            Dt_Circuitos.Name = "Dt_Circuitos";
            Dt_Circuitos.ReadOnly = true;
            Dt_Circuitos.RowHeadersWidth = 51;
            Dt_Circuitos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dt_Circuitos.Size = new Size(853, 354);
            Dt_Circuitos.TabIndex = 6;
            // 
            // Btn_Sobe
            // 
            Btn_Sobe.BackColor = SystemColors.ControlDarkDark;
            Btn_Sobe.Font = new Font("Segoe UI", 12F);
            Btn_Sobe.ForeColor = SystemColors.ButtonHighlight;
            Btn_Sobe.Location = new Point(233, 426);
            Btn_Sobe.Name = "Btn_Sobe";
            Btn_Sobe.Size = new Size(202, 45);
            Btn_Sobe.TabIndex = 7;
            Btn_Sobe.Text = "Sobe";
            Btn_Sobe.UseVisualStyleBackColor = false;
            // 
            // Btn_Desce
            // 
            Btn_Desce.BackColor = SystemColors.ActiveCaptionText;
            Btn_Desce.Font = new Font("Segoe UI", 12F);
            Btn_Desce.ForeColor = SystemColors.ButtonHighlight;
            Btn_Desce.Location = new Point(441, 426);
            Btn_Desce.Name = "Btn_Desce";
            Btn_Desce.Size = new Size(202, 45);
            Btn_Desce.TabIndex = 8;
            Btn_Desce.Text = "Desce";
            Btn_Desce.UseVisualStyleBackColor = false;
            // 
            // Btn_DelProva
            // 
            Btn_DelProva.BackColor = SystemColors.ActiveCaptionText;
            Btn_DelProva.Font = new Font("Segoe UI", 12F);
            Btn_DelProva.ForeColor = SystemColors.ButtonHighlight;
            Btn_DelProva.Location = new Point(663, 426);
            Btn_DelProva.Name = "Btn_DelProva";
            Btn_DelProva.Size = new Size(202, 45);
            Btn_DelProva.TabIndex = 9;
            Btn_DelProva.Text = "Remover prova";
            Btn_DelProva.UseVisualStyleBackColor = false;
            Btn_DelProva.Click += Btn_DelProva_Click;
            // 
            // Frm_Circuitos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 534);
            Controls.Add(Btn_DelProva);
            Controls.Add(Btn_Desce);
            Controls.Add(Btn_Sobe);
            Controls.Add(Dt_Circuitos);
            Controls.Add(Lbl_Titulo);
            Controls.Add(Btn_AddProva);
            Controls.Add(Btn_Voltar);
            Name = "Frm_Circuitos";
            ShowIcon = false;
            Text = "Circuitos";
            ((System.ComponentModel.ISupportInitialize)Dt_Circuitos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Voltar;
        private Button Btn_AddProva;
        private Label Lbl_Titulo;
        private DataGridView Dt_Circuitos;
        private Button Btn_Sobe;
        private Button Btn_Desce;
        private Button Btn_DelProva;
    }
}