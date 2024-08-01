namespace ChallengeOneLibraryDAS01
{
    partial class AdministrationMenuForm
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(320, 108);
            button1.Name = "button1";
            button1.Size = new Size(161, 49);
            button1.TabIndex = 0;
            button1.Text = "Libros registro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(320, 168);
            button2.Name = "button2";
            button2.Size = new Size(161, 49);
            button2.TabIndex = 1;
            button2.Text = "Gestión de usuarios";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(320, 230);
            button3.Name = "button3";
            button3.Size = new Size(161, 49);
            button3.TabIndex = 2;
            button3.Text = "Prestamos registro";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(320, 293);
            button4.Name = "button4";
            button4.Size = new Size(161, 49);
            button4.TabIndex = 3;
            button4.Text = "Reportes";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(645, 409);
            button5.Name = "button5";
            button5.Size = new Size(143, 29);
            button5.TabIndex = 4;
            button5.Text = "Regresar al menú";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AdministrationMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdministrationMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}