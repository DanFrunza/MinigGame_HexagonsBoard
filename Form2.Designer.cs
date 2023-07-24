namespace Proiect7
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            p = new PictureBox();
            Score = new Label();
            label1 = new Label();
            label2 = new Label();
            Pasi = new Label();
            label3 = new Label();
            Score_final = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            cronometru1 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            cronometru2 = new Label();
            label6 = new Label();
            PasiRamasi = new Label();
            label7 = new Label();
            Nume = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            pd = new PrintDialog();
            print = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // p
            // 
            p.BackColor = Color.Transparent;
            p.Location = new Point(42, 188);
            p.Name = "p";
            p.Size = new Size(1000, 640);
            p.TabIndex = 0;
            p.TabStop = false;
            p.Paint += p_Paint;
            p.MouseDown += p_MouseDown;
            p.MouseMove += p_MouseMove;
            p.MouseUp += p_MouseUp;
            // 
            // Score
            // 
            Score.BackColor = Color.Transparent;
            Score.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Score.Location = new Point(107, 124);
            Score.Name = "Score";
            Score.Size = new Size(72, 34);
            Score.TabIndex = 1;
            Score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(89, 35);
            label1.TabIndex = 2;
            label1.Text = "Score :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(185, 124);
            label2.Name = "label2";
            label2.Size = new Size(131, 35);
            label2.TabIndex = 3;
            label2.Text = "Pasi facuti:";
            // 
            // Pasi
            // 
            Pasi.BackColor = Color.Transparent;
            Pasi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Pasi.Location = new Point(322, 126);
            Pasi.Name = "Pasi";
            Pasi.Size = new Size(88, 33);
            Pasi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(402, 124);
            label3.Name = "label3";
            label3.Size = new Size(136, 35);
            label3.TabIndex = 5;
            label3.Text = "Score final:";
            // 
            // Score_final
            // 
            Score_final.BackColor = Color.Transparent;
            Score_final.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Score_final.Location = new Point(544, 127);
            Score_final.Name = "Score_final";
            Score_final.Size = new Size(76, 31);
            Score_final.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(608, 124);
            label4.Name = "label4";
            label4.Size = new Size(147, 35);
            label4.TabIndex = 7;
            label4.Text = "Timp trecut:";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // cronometru1
            // 
            cronometru1.BackColor = Color.Transparent;
            cronometru1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cronometru1.Location = new Point(761, 122);
            cronometru1.Name = "cronometru1";
            cronometru1.Size = new Size(143, 39);
            cronometru1.TabIndex = 8;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(910, 126);
            label5.Name = "label5";
            label5.Size = new Size(151, 35);
            label5.TabIndex = 9;
            label5.Text = "Timp ramas:";
            // 
            // cronometru2
            // 
            cronometru2.BackColor = Color.Transparent;
            cronometru2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cronometru2.Location = new Point(1067, 122);
            cronometru2.Name = "cronometru2";
            cronometru2.Size = new Size(154, 39);
            cronometru2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1083, 188);
            label6.Name = "label6";
            label6.Size = new Size(144, 35);
            label6.TabIndex = 11;
            label6.Text = "Pasi ramasi:";
            // 
            // PasiRamasi
            // 
            PasiRamasi.AutoSize = true;
            PasiRamasi.BackColor = Color.Transparent;
            PasiRamasi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PasiRamasi.Location = new Point(1146, 240);
            PasiRamasi.Name = "PasiRamasi";
            PasiRamasi.Size = new Size(0, 35);
            PasiRamasi.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1048, 275);
            label7.Name = "label7";
            label7.Size = new Size(231, 35);
            label7.TabIndex = 13;
            label7.Text = "Numele jucatorului:";
            // 
            // Nume
            // 
            Nume.BackColor = Color.Transparent;
            Nume.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Nume.Location = new Point(1048, 310);
            Nume.Name = "Nume";
            Nume.Size = new Size(231, 48);
            Nume.TabIndex = 14;
            Nume.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.BackgroundImageLayout = ImageLayout.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1282, 54);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.Save1;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(54, 51);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.Print1;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(54, 51);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.Clasamentt1;
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(54, 51);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // pd
            // 
            pd.UseEXDialog = true;
            // 
            // print
            // 
            print.PrintPage += print_PrintPage;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1298880;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1282, 853);
            Controls.Add(toolStrip1);
            Controls.Add(Nume);
            Controls.Add(label7);
            Controls.Add(PasiRamasi);
            Controls.Add(label6);
            Controls.Add(cronometru2);
            Controls.Add(label5);
            Controls.Add(cronometru1);
            Controls.Add(label4);
            Controls.Add(Score_final);
            Controls.Add(label3);
            Controls.Add(Pasi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Score);
            Controls.Add(p);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox p;
        private Label Score;
        private Label label1;
        private Label label2;
        private Label Pasi;
        private Label label3;
        private Label Score_final;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Label cronometru1;
        private System.Windows.Forms.Timer timer2;
        private Label label5;
        private Label cronometru2;
        private Label label6;
        private Label PasiRamasi;
        private Label label7;
        private Label Nume;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private PrintDialog pd;
        private System.Drawing.Printing.PrintDocument print;
    }
}