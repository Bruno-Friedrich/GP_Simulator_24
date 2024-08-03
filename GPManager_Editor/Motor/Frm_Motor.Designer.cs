namespace GPManager_Editor.Motor
{
    partial class Frm_Motor
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
            Lbl_Titulo = new Label();
            Dt_Motor = new DataGridView();
            Btn_Voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)Dt_Motor).BeginInit();
            SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            Lbl_Titulo.AutoSize = true;
            Lbl_Titulo.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Lbl_Titulo.Location = new Point(171, 9);
            Lbl_Titulo.Name = "Lbl_Titulo";
            Lbl_Titulo.Size = new Size(132, 40);
            Lbl_Titulo.TabIndex = 6;
            Lbl_Titulo.Text = "Motores";
            // 
            // Dt_Motor
            // 
            Dt_Motor.AllowUserToAddRows = false;
            Dt_Motor.AllowUserToDeleteRows = false;
            Dt_Motor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Motor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dt_Motor.EnableHeadersVisualStyles = false;
            Dt_Motor.Location = new Point(12, 63);
            Dt_Motor.MultiSelect = false;
            Dt_Motor.Name = "Dt_Motor";
            Dt_Motor.ReadOnly = true;
            Dt_Motor.RowHeadersVisible = false;
            Dt_Motor.RowHeadersWidth = 51;
            Dt_Motor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dt_Motor.Size = new Size(469, 317);
            Dt_Motor.TabIndex = 7;
            Dt_Motor.CellDoubleClick += Dt_Motor_CellDoubleClick;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = SystemColors.ActiveCaptionText;
            Btn_Voltar.Font = new Font("Segoe UI", 12F);
            Btn_Voltar.ForeColor = SystemColors.ButtonHighlight;
            Btn_Voltar.Location = new Point(12, 386);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(469, 45);
            Btn_Voltar.TabIndex = 8;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Frm_Motor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 438);
            ControlBox = false;
            Controls.Add(Btn_Voltar);
            Controls.Add(Dt_Motor);
            Controls.Add(Lbl_Titulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Frm_Motor";
            ShowIcon = false;
            Text = "Motores";
            ((System.ComponentModel.ISupportInitialize)Dt_Motor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Titulo;
        private DataGridView Dt_Motor;
        private Button Btn_Voltar;
    }
}