namespace ChallengeOneLibraryDAS01
{
    partial class RootMenuForm
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(68, 86);
            button1.Name = "button1";
            button1.Size = new Size(227, 61);
            button1.TabIndex = 0;
            button1.Text = "Panel de Administración";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(68, 183);
            button2.Name = "button2";
            button2.Size = new Size(227, 61);
            button2.TabIndex = 1;
            button2.Text = "Biblioteca Interfaz de Usuario";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(12, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 286);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(293, 24);
            label1.TabIndex = 2;
            label1.Text = "Biblioteca Centro de Control";
            label1.Click += label1_Click;
            // 
            // RootMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(390, 319);
            Controls.Add(panel1);
            MinimumSize = new Size(100, 100);
            Name = "RootMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label1;
    }
}