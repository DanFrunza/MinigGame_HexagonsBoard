namespace Proiect7
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            Dim3 = new CheckBox();
            Dim4 = new CheckBox();
            Dim5 = new CheckBox();
            DifEasy = new CheckBox();
            DifMedium = new CheckBox();
            DifHard = new CheckBox();
            label3 = new Label();
            NumeJucator = new TextBox();
            Pasi40 = new CheckBox();
            Pasi30 = new CheckBox();
            Pasi20 = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            timp = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 46);
            label1.TabIndex = 1;
            label1.Text = "Dimensiune Harta: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(180, 46);
            label2.TabIndex = 2;
            label2.Text = "Dificultate:";
            // 
            // Dim3
            // 
            Dim3.Location = new Point(311, 17);
            Dim3.Name = "Dim3";
            Dim3.Size = new Size(41, 38);
            Dim3.TabIndex = 3;
            Dim3.Text = "3";
            Dim3.UseVisualStyleBackColor = true;
            Dim3.Click += Dim3_Click;
            // 
            // Dim4
            // 
            Dim4.AutoSize = true;
            Dim4.Location = new Point(358, 24);
            Dim4.Name = "Dim4";
            Dim4.Size = new Size(39, 24);
            Dim4.TabIndex = 4;
            Dim4.Text = "4";
            Dim4.UseVisualStyleBackColor = true;
            Dim4.Click += Dim4_Click;
            // 
            // Dim5
            // 
            Dim5.AutoSize = true;
            Dim5.Location = new Point(402, 25);
            Dim5.Name = "Dim5";
            Dim5.Size = new Size(39, 24);
            Dim5.TabIndex = 5;
            Dim5.Text = "5";
            Dim5.UseVisualStyleBackColor = true;
            Dim5.Click += Dim5_Click;
            // 
            // DifEasy
            // 
            DifEasy.AutoSize = true;
            DifEasy.Location = new Point(202, 84);
            DifEasy.Name = "DifEasy";
            DifEasy.Size = new Size(60, 24);
            DifEasy.TabIndex = 6;
            DifEasy.Text = "Easy";
            DifEasy.UseVisualStyleBackColor = true;
            DifEasy.Click += DifEasy_Click;
            // 
            // DifMedium
            // 
            DifMedium.AutoSize = true;
            DifMedium.Location = new Point(270, 85);
            DifMedium.Name = "DifMedium";
            DifMedium.Size = new Size(86, 24);
            DifMedium.TabIndex = 7;
            DifMedium.Text = "Medium";
            DifMedium.UseVisualStyleBackColor = true;
            DifMedium.Click += DifMedium_Click;
            // 
            // DifHard
            // 
            DifHard.AutoSize = true;
            DifHard.Location = new Point(362, 84);
            DifHard.Name = "DifHard";
            DifHard.Size = new Size(64, 24);
            DifHard.TabIndex = 8;
            DifHard.Text = "Hard";
            DifHard.UseVisualStyleBackColor = true;
            DifHard.Click += DifHard_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(320, 46);
            label3.TabIndex = 9;
            label3.Text = "Numele jucatorului: ";
            // 
            // NumeJucator
            // 
            NumeJucator.Location = new Point(338, 131);
            NumeJucator.Multiline = true;
            NumeJucator.Name = "NumeJucator";
            NumeJucator.Size = new Size(424, 39);
            NumeJucator.TabIndex = 10;
            // 
            // Pasi40
            // 
            Pasi40.AutoSize = true;
            Pasi40.Location = new Point(438, 85);
            Pasi40.Name = "Pasi40";
            Pasi40.Size = new Size(78, 24);
            Pasi40.TabIndex = 11;
            Pasi40.Text = "40 pasi";
            Pasi40.UseVisualStyleBackColor = true;
            Pasi40.CheckedChanged += Pasi40_CheckedChanged;
            // 
            // Pasi30
            // 
            Pasi30.AutoSize = true;
            Pasi30.Location = new Point(528, 86);
            Pasi30.Name = "Pasi30";
            Pasi30.Size = new Size(78, 24);
            Pasi30.TabIndex = 12;
            Pasi30.Text = "30 pasi";
            Pasi30.UseVisualStyleBackColor = true;
            Pasi30.CheckedChanged += Pasi30_CheckedChanged;
            // 
            // Pasi20
            // 
            Pasi20.AutoSize = true;
            Pasi20.Location = new Point(613, 87);
            Pasi20.Name = "Pasi20";
            Pasi20.Size = new Size(78, 24);
            Pasi20.TabIndex = 13;
            Pasi20.Text = "pasi 20";
            Pasi20.UseVisualStyleBackColor = true;
            Pasi20.CheckedChanged += Pasi20_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(551, 360);
            button1.Name = "button1";
            button1.Size = new Size(195, 55);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(354, 46);
            label4.TabIndex = 15;
            label4.Text = "Timp maxim(secunde):";
            // 
            // timp
            // 
            timp.Location = new Point(383, 193);
            timp.Multiline = true;
            timp.Name = "timp";
            timp.Size = new Size(295, 39);
            timp.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timp);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(Pasi20);
            Controls.Add(Pasi30);
            Controls.Add(Pasi40);
            Controls.Add(NumeJucator);
            Controls.Add(label3);
            Controls.Add(DifHard);
            Controls.Add(DifMedium);
            Controls.Add(DifEasy);
            Controls.Add(Dim5);
            Controls.Add(Dim4);
            Controls.Add(Dim3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox Dim3;
        private CheckBox Dim4;
        private CheckBox Dim5;
        private CheckBox DifEasy;
        private CheckBox DifMedium;
        private CheckBox DifHard;
        private Label label3;
        private TextBox NumeJucator;
        private CheckBox Pasi40;
        private CheckBox Pasi30;
        private CheckBox Pasi20;
        private Button button1;
        private Label label4;
        private TextBox timp;
    }
}