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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            bookEditorialLabel = new Label();
            bookAuthorLabel = new Label();
            bookTitleLabel = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            searchTxtBox = new TextBox();
            searchResultsListBox = new ListBox();
            groupBox3 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(bookEditorialLabel);
            groupBox1.Controls.Add(bookAuthorLabel);
            groupBox1.Controls.Add(bookTitleLabel);
            groupBox1.Location = new Point(12, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 266);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(404, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 154);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 199);
            label2.Name = "label2";
            label2.Size = new Size(169, 22);
            label2.TabIndex = 10;
            label2.Text = "Copias Disponibles :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 160);
            label1.Name = "label1";
            label1.Size = new Size(146, 22);
            label1.TabIndex = 9;
            label1.Text = "Año Publicación :";
            // 
            // bookEditorialLabel
            // 
            bookEditorialLabel.AutoSize = true;
            bookEditorialLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookEditorialLabel.Location = new Point(29, 126);
            bookEditorialLabel.Name = "bookEditorialLabel";
            bookEditorialLabel.Size = new Size(85, 22);
            bookEditorialLabel.TabIndex = 8;
            bookEditorialLabel.Text = "Editorial :";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookAuthorLabel.Location = new Point(29, 87);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(65, 22);
            bookAuthorLabel.TabIndex = 7;
            bookAuthorLabel.Text = "Autor :";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookTitleLabel.Location = new Point(25, 47);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(67, 22);
            bookTitleLabel.TabIndex = 6;
            bookTitleLabel.Text = "Título :";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(12, 491);
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
            groupBox2.Size = new Size(588, 170);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscador";
            groupBox2.Enter += groupBox2_Enter;
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
            // 
            // searchResultsListBox
            // 
            searchResultsListBox.FormattingEnabled = true;
            searchResultsListBox.ItemHeight = 20;
            searchResultsListBox.Location = new Point(29, 71);
            searchResultsListBox.Name = "searchResultsListBox";
            searchResultsListBox.Size = new Size(379, 104);
            searchResultsListBox.TabIndex = 5;
            searchResultsListBox.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(29, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 66);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Opciones de búsqueda";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "ID";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(101, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Título";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // BooksRegistryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 544);
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
        private ContextMenuStrip contextMenuStrip1;
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
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}