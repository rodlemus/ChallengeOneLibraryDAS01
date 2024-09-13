namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Books
{
    partial class BooksRegistryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksRegistryForm));
            groupBox1 = new GroupBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            bookEditorialLabel = new Label();
            bookAuthorLabel = new Label();
            bookTitleLabel = new Label();
            searchResultsListBox = new ListBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            rdBtnTitle = new RadioButton();
            rdBtnId = new RadioButton();
            button2 = new Button();
            searchTxtBox = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(bookEditorialLabel);
            groupBox1.Controls.Add(bookAuthorLabel);
            groupBox1.Controls.Add(bookTitleLabel);
            groupBox1.Location = new Point(12, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 280);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // button9
            // 
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(517, 33);
            button9.Name = "button9";
            button9.Size = new Size(37, 28);
            button9.TabIndex = 21;
            button9.UseVisualStyleBackColor = true;
            button9.Click += handleUpdatePortraitUrlEvent;
            // 
            // button8
            // 
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(6, 196);
            button8.Name = "button8";
            button8.Size = new Size(37, 28);
            button8.TabIndex = 20;
            button8.UseVisualStyleBackColor = true;
            button8.Click += handleUpdateStockEvent;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(6, 157);
            button7.Name = "button7";
            button7.Size = new Size(37, 28);
            button7.TabIndex = 19;
            button7.UseVisualStyleBackColor = true;
            button7.Click += handleUpdatePublicationDateEvent;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(6, 116);
            button6.Name = "button6";
            button6.Size = new Size(37, 28);
            button6.TabIndex = 18;
            button6.UseVisualStyleBackColor = true;
            button6.Click += handleUpdateEditorialEvent;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(6, 82);
            button5.Name = "button5";
            button5.Size = new Size(37, 28);
            button5.TabIndex = 17;
            button5.UseVisualStyleBackColor = true;
            button5.Click += handleUpdateAuthorEvent;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(6, 44);
            button4.Name = "button4";
            button4.Size = new Size(37, 28);
            button4.TabIndex = 16;
            button4.UseVisualStyleBackColor = true;
            button4.Click += handleUpdateTitleEvent;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(404, 225);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(150, 41);
            button3.TabIndex = 5;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 200);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 15;
            label7.Text = "      ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 161);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 14;
            label6.Text = "      ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 127);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 13;
            label5.Text = "      ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 88);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 12;
            label4.Text = "      ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(115, 48);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 11;
            label3.Text = "      ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(404, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 198);
            label2.Name = "label2";
            label2.Size = new Size(169, 22);
            label2.TabIndex = 10;
            label2.Text = "Copias Disponibles :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 160);
            label1.Name = "label1";
            label1.Size = new Size(146, 22);
            label1.TabIndex = 9;
            label1.Text = "Año Publicación :";
            // 
            // bookEditorialLabel
            // 
            bookEditorialLabel.AutoSize = true;
            bookEditorialLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookEditorialLabel.Location = new Point(46, 122);
            bookEditorialLabel.Name = "bookEditorialLabel";
            bookEditorialLabel.Size = new Size(85, 22);
            bookEditorialLabel.TabIndex = 8;
            bookEditorialLabel.Text = "Editorial :";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookAuthorLabel.Location = new Point(46, 84);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(65, 22);
            bookAuthorLabel.TabIndex = 7;
            bookAuthorLabel.Text = "Autor :";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookTitleLabel.Location = new Point(42, 46);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(67, 22);
            bookTitleLabel.TabIndex = 6;
            bookTitleLabel.Text = "Título :";
            // 
            // searchResultsListBox
            // 
            searchResultsListBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            searchResultsListBox.FormattingEnabled = true;
            searchResultsListBox.ItemHeight = 23;
            searchResultsListBox.Location = new Point(29, 71);
            searchResultsListBox.Name = "searchResultsListBox";
            searchResultsListBox.Size = new Size(379, 96);
            searchResultsListBox.TabIndex = 5;
            searchResultsListBox.Visible = false;
            searchResultsListBox.SelectedIndexChanged += handleSelectedBook;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(18, 532);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(198, 39);
            button1.TabIndex = 2;
            button1.Text = "+ Nuevo Libro";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(searchResultsListBox);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(searchTxtBox);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(588, 193);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscador";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdBtnTitle);
            groupBox3.Controls.Add(rdBtnId);
            groupBox3.Location = new Point(29, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 66);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Opciones de búsqueda";
            // 
            // rdBtnTitle
            // 
            rdBtnTitle.AutoSize = true;
            rdBtnTitle.Location = new Point(17, 28);
            rdBtnTitle.Name = "rdBtnTitle";
            rdBtnTitle.Size = new Size(68, 24);
            rdBtnTitle.TabIndex = 1;
            rdBtnTitle.TabStop = true;
            rdBtnTitle.Text = "Título";
            rdBtnTitle.UseVisualStyleBackColor = true;
            // 
            // rdBtnId
            // 
            rdBtnId.AutoSize = true;
            rdBtnId.Location = new Point(124, 28);
            rdBtnId.Name = "rdBtnId";
            rdBtnId.Size = new Size(45, 24);
            rdBtnId.TabIndex = 0;
            rdBtnId.TabStop = true;
            rdBtnId.Text = "ID";
            rdBtnId.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(432, 32);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(143, 37);
            button2.TabIndex = 6;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // searchTxtBox
            // 
            searchTxtBox.BackColor = SystemColors.Control;
            searchTxtBox.Location = new Point(29, 38);
            searchTxtBox.MaxLength = 100;
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.PlaceholderText = "Buscar";
            searchTxtBox.Size = new Size(379, 27);
            searchTxtBox.TabIndex = 0;
            searchTxtBox.Enter += handleEnterSearchFocus;
            // 
            // BooksRegistryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 580);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            MinimumSize = new Size(100, 100);
            Name = "BooksRegistryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BooksRegistryForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label bookEditorialLabel;
        private Label bookAuthorLabel;
        private Label bookTitleLabel;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox searchTxtBox;
        private ListBox searchResultsListBox;
        private Button button1;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private RadioButton rdBtnTitle;
        private RadioButton rdBtnId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button9;
    }
}