namespace ChallengeOneLibraryDAS01.Forms
{
    partial class ConfirmDialog
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
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(257, 66);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 3;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(96, 66);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(150, 41);
            button3.TabIndex = 6;
            button3.Text = "CONFIRMAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 23);
            label1.Name = "label1";
            label1.Size = new Size(450, 21);
            label1.TabIndex = 7;
            label1.Text = "¿Estas seguro que deseas confirmar esta acción ?";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(12, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 131);
            panel1.TabIndex = 8;
            // 
            // ConfirmDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 160);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "ConfirmDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmDialog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Label label1;
        private Panel panel1;
    }
}