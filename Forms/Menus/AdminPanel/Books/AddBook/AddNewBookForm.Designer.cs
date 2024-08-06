namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books.AddBook
{
    partial class AddNewBookForm
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
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            bookUrlTxtBox = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            bookPortraitPictureBx = new PictureBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            bookAutorTxtBox = new TextBox();
            label2 = new Label();
            bookTitleTxtBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookPortraitPictureBx).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(bookUrlTxtBox);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(bookPortraitPictureBx);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(bookAutorTxtBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bookTitleTxtBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(188, 232);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2024, 8, 6, 0, 0, 0, 0);
            // 
            // bookUrlTxtBox
            // 
            bookUrlTxtBox.Location = new Point(149, 128);
            bookUrlTxtBox.Name = "bookUrlTxtBox";
            bookUrlTxtBox.Size = new Size(274, 27);
            bookUrlTxtBox.TabIndex = 14;
            bookUrlTxtBox.TextChanged += bookUrlTxtBox_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(188, 353);
            button2.Name = "button2";
            button2.Size = new Size(126, 43);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(47, 353);
            button1.Name = "button1";
            button1.Size = new Size(126, 43);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 128);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 11;
            label6.Text = "Portada Url :";
            // 
            // bookPortraitPictureBx
            // 
            bookPortraitPictureBx.BorderStyle = BorderStyle.FixedSingle;
            bookPortraitPictureBx.Location = new Point(476, 20);
            bookPortraitPictureBx.Name = "bookPortraitPictureBx";
            bookPortraitPictureBx.Size = new Size(279, 306);
            bookPortraitPictureBx.SizeMode = PictureBoxSizeMode.StretchImage;
            bookPortraitPictureBx.TabIndex = 10;
            bookPortraitPictureBx.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(163, 282);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(274, 27);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 285);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 8;
            label5.Text = "# Ejemplares : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 232);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 6;
            label3.Text = "Año/Publicación : ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 27);
            textBox4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 179);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 4;
            label4.Text = "Editorial : ";
            // 
            // bookAutorTxtBox
            // 
            bookAutorTxtBox.Location = new Point(135, 81);
            bookAutorTxtBox.Name = "bookAutorTxtBox";
            bookAutorTxtBox.Size = new Size(274, 27);
            bookAutorTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 84);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Autor : ";
            // 
            // bookTitleTxtBox
            // 
            bookTitleTxtBox.Location = new Point(135, 31);
            bookTitleTxtBox.Name = "bookTitleTxtBox";
            bookTitleTxtBox.Size = new Size(274, 27);
            bookTitleTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 34);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Título : ";
            // 
            // AddNewBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AddNewBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewBookForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookPortraitPictureBx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox bookTitleTxtBox;
        private Label label1;
        private TextBox bookAutorTxtBox;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private PictureBox bookPortraitPictureBx;
        private TextBox textBox5;
        private Label label5;
        private TextBox bookUrlTxtBox;
        private Button button2;
        private Button button1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}