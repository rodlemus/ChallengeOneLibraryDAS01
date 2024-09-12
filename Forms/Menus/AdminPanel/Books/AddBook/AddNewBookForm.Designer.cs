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
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            bookUrlTxtBox = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            bookPortraitPictureBx = new PictureBox();
            txtBoxStock = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtBoxEditorial = new TextBox();
            label4 = new Label();
            bookAutorTxtBox = new TextBox();
            label2 = new Label();
            bookTitleTxtBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookPortraitPictureBx).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(bookUrlTxtBox);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(bookPortraitPictureBx);
            panel1.Controls.Add(txtBoxStock);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtBoxEditorial);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(bookAutorTxtBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bookTitleTxtBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 426);
            panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(455, 286);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(455, 185);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(455, 141);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(455, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(455, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(175, 243);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(310, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 9, 12, 0, 0, 0, 0);
            // 
            // bookUrlTxtBox
            // 
            bookUrlTxtBox.Location = new Point(175, 141);
            bookUrlTxtBox.Name = "bookUrlTxtBox";
            bookUrlTxtBox.Size = new Size(274, 27);
            bookUrlTxtBox.TabIndex = 3;
            bookUrlTxtBox.TextChanged += bookUrlTxtBox_TextChanged;
            bookUrlTxtBox.Validating += handlePortraitUrlValidation;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(451, 361);
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
            button1.Location = new Point(310, 361);
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
            label6.Location = new Point(79, 141);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 11;
            label6.Text = "Portada Url :";
            // 
            // bookPortraitPictureBx
            // 
            bookPortraitPictureBx.BorderStyle = BorderStyle.FixedSingle;
            bookPortraitPictureBx.Location = new Point(510, 43);
            bookPortraitPictureBx.Name = "bookPortraitPictureBx";
            bookPortraitPictureBx.Size = new Size(266, 270);
            bookPortraitPictureBx.SizeMode = PictureBoxSizeMode.StretchImage;
            bookPortraitPictureBx.TabIndex = 10;
            bookPortraitPictureBx.TabStop = false;
            // 
            // txtBoxStock
            // 
            txtBoxStock.Location = new Point(175, 288);
            txtBoxStock.Name = "txtBoxStock";
            txtBoxStock.Size = new Size(274, 27);
            txtBoxStock.TabIndex = 6;
            txtBoxStock.Validating += handleStockValidation;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 291);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 8;
            label5.Text = "# Ejemplares : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 243);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Publicación : ";
            // 
            // txtBoxEditorial
            // 
            txtBoxEditorial.Location = new Point(175, 185);
            txtBoxEditorial.Name = "txtBoxEditorial";
            txtBoxEditorial.Size = new Size(274, 27);
            txtBoxEditorial.TabIndex = 4;
            txtBoxEditorial.Validating += handleEditorialValidation;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 192);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 4;
            label4.Text = "Editorial : ";
            // 
            // bookAutorTxtBox
            // 
            bookAutorTxtBox.Location = new Point(175, 87);
            bookAutorTxtBox.Name = "bookAutorTxtBox";
            bookAutorTxtBox.Size = new Size(274, 27);
            bookAutorTxtBox.TabIndex = 2;
            bookAutorTxtBox.Validating += handleAuthorValidation;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 94);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Autor : ";
            // 
            // bookTitleTxtBox
            // 
            bookTitleTxtBox.Location = new Point(175, 47);
            bookTitleTxtBox.Name = "bookTitleTxtBox";
            bookTitleTxtBox.Size = new Size(274, 27);
            bookTitleTxtBox.TabIndex = 1;
            bookTitleTxtBox.Validating += handleTitleValidation;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 47);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Título : ";
            // 
            // AddNewBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 450);
            Controls.Add(panel1);
            Name = "AddNewBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewBookForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txtBoxEditorial;
        private Label label4;
        private PictureBox bookPortraitPictureBx;
        private TextBox txtBoxStock;
        private Label label5;
        private TextBox bookUrlTxtBox;
        private Button button2;
        private Button button1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}