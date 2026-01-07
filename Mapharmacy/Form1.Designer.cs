namespace Mapharmacy
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            barDeProgression = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            chargementlbl = new Label();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            barDeProgression.SuspendLayout();
            SuspendLayout();
            // 
            // barDeProgression
            // 
            barDeProgression.Controls.Add(chargementlbl);
            barDeProgression.FillColor = Color.SlateBlue;
            barDeProgression.FillThickness = 10;
            barDeProgression.Font = new Font("Segoe UI", 12F);
            barDeProgression.ForeColor = Color.White;
            barDeProgression.Location = new Point(274, 123);
            barDeProgression.Minimum = 0;
            barDeProgression.Name = "barDeProgression";
            barDeProgression.ProgressColor = Color.White;
            barDeProgression.ProgressColor2 = Color.White;
            barDeProgression.ShadowDecoration.CustomizableEdges = customizableEdges1;
            barDeProgression.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            barDeProgression.Size = new Size(162, 162);
            barDeProgression.TabIndex = 0;
            barDeProgression.Text = "guna2CircleProgressBar1";
            // 
            // chargementlbl
            // 
            chargementlbl.AutoSize = true;
            chargementlbl.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chargementlbl.Location = new Point(61, 58);
            chargementlbl.Name = "chargementlbl";
            chargementlbl.Size = new Size(39, 34);
            chargementlbl.TabIndex = 0;
            chargementlbl.Text = "%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(204, 53);
            label1.Name = "label1";
            label1.Size = new Size(301, 34);
            label1.TabIndex = 1;
            label1.Text = "PHARMACY DU COIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(274, 388);
            label2.Name = "label2";
            label2.Size = new Size(182, 22);
            label2.TabIndex = 2;
            label2.Text = "Develope by exhorte space";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(744, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(barDeProgression);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            barDeProgression.ResumeLayout(false);
            barDeProgression.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar barDeProgression;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label chargementlbl;
    }
}
