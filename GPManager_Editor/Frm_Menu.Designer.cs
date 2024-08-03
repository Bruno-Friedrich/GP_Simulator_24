namespace GPManager_Editor
{
    partial class Frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            panel1 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripSeparator();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            Btn_Circuitos = new Button();
            Btn_Motor = new Button();
            Btn_Hall_Fama = new Button();
            Btn_Regras = new Button();
            Btn_Equipes = new Button();
            Btn_Pilotos = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 32);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, -2);
            label1.Name = "label1";
            label1.Size = new Size(382, 28);
            label1.TabIndex = 0;
            label1.Text = "Grand Prix Manager 24 - Editor de Dataset";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(703, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, sairToolStripMenuItem1 });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(167, 6);
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Image = (Image)resources.GetObject("sairToolStripMenuItem1.Image");
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem1.Size = new Size(170, 26);
            sairToolStripMenuItem1.Text = "Sair";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(62, 24);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(121, 37);
            label2.Name = "label2";
            label2.Size = new Size(460, 54);
            label2.TabIndex = 2;
            label2.Text = "Grand Prix Manager 24";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(289, 91);
            label3.Name = "label3";
            label3.Size = new Size(136, 54);
            label3.TabIndex = 3;
            label3.Text = "Editor";
            // 
            // Btn_Circuitos
            // 
            Btn_Circuitos.BackColor = SystemColors.ActiveCaptionText;
            Btn_Circuitos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            Btn_Circuitos.ForeColor = SystemColors.Control;
            Btn_Circuitos.Location = new Point(35, 145);
            Btn_Circuitos.Name = "Btn_Circuitos";
            Btn_Circuitos.Size = new Size(307, 72);
            Btn_Circuitos.TabIndex = 4;
            Btn_Circuitos.Text = "Circuitos";
            Btn_Circuitos.UseVisualStyleBackColor = false;
            Btn_Circuitos.Click += Btn_Circuitos_Click;
            // 
            // Btn_Motor
            // 
            Btn_Motor.BackColor = SystemColors.ActiveCaptionText;
            Btn_Motor.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            Btn_Motor.ForeColor = SystemColors.Control;
            Btn_Motor.Location = new Point(35, 232);
            Btn_Motor.Name = "Btn_Motor";
            Btn_Motor.Size = new Size(307, 72);
            Btn_Motor.TabIndex = 5;
            Btn_Motor.Text = "Motor";
            Btn_Motor.UseVisualStyleBackColor = false;
            Btn_Motor.Click += Btn_Motor_Click;
            // 
            // Btn_Hall_Fama
            // 
            Btn_Hall_Fama.BackColor = SystemColors.ActiveCaptionText;
            Btn_Hall_Fama.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            Btn_Hall_Fama.ForeColor = SystemColors.Control;
            Btn_Hall_Fama.Location = new Point(35, 326);
            Btn_Hall_Fama.Name = "Btn_Hall_Fama";
            Btn_Hall_Fama.Size = new Size(307, 72);
            Btn_Hall_Fama.TabIndex = 6;
            Btn_Hall_Fama.Text = "Hall da Fama";
            Btn_Hall_Fama.UseVisualStyleBackColor = false;
            // 
            // Btn_Regras
            // 
            Btn_Regras.BackColor = SystemColors.ActiveCaptionText;
            Btn_Regras.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            Btn_Regras.ForeColor = SystemColors.Control;
            Btn_Regras.Location = new Point(348, 326);
            Btn_Regras.Name = "Btn_Regras";
            Btn_Regras.Size = new Size(307, 72);
            Btn_Regras.TabIndex = 9;
            Btn_Regras.Text = "Regras";
            Btn_Regras.UseVisualStyleBackColor = false;
            // 
            // Btn_Equipes
            // 
            Btn_Equipes.BackColor = SystemColors.ActiveCaptionText;
            Btn_Equipes.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            Btn_Equipes.ForeColor = SystemColors.Control;
            Btn_Equipes.Location = new Point(348, 232);
            Btn_Equipes.Name = "Btn_Equipes";
            Btn_Equipes.Size = new Size(307, 72);
            Btn_Equipes.TabIndex = 8;
            Btn_Equipes.Text = "Equipes";
            Btn_Equipes.UseVisualStyleBackColor = false;
            // 
            // Btn_Pilotos
            // 
            Btn_Pilotos.BackColor = SystemColors.ActiveCaptionText;
            Btn_Pilotos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            Btn_Pilotos.ForeColor = SystemColors.Control;
            Btn_Pilotos.Location = new Point(348, 145);
            Btn_Pilotos.Name = "Btn_Pilotos";
            Btn_Pilotos.Size = new Size(307, 72);
            Btn_Pilotos.TabIndex = 7;
            Btn_Pilotos.Text = "Pilotos";
            Btn_Pilotos.UseVisualStyleBackColor = false;
            // 
            // Frm_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(703, 450);
            Controls.Add(Btn_Regras);
            Controls.Add(Btn_Equipes);
            Controls.Add(Btn_Pilotos);
            Controls.Add(Btn_Hall_Fama);
            Controls.Add(Btn_Motor);
            Controls.Add(Btn_Circuitos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Frm_Menu";
            Text = "Grand Prix Manager 24 - Editor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripSeparator sairToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Label label2;
        private Label label3;
        private Button Btn_Circuitos;
        private Button Btn_Motor;
        private Button Btn_Hall_Fama;
        private Button Btn_Regras;
        private Button Btn_Equipes;
        private Button Btn_Pilotos;
    }
}
