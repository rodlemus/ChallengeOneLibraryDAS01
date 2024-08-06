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
            panel1 = new Panel();
            searchResultsListBox = new ListBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            searchTxtBox = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bookEditorialLabel = new Label();
            bookAuthorLabel = new Label();
            bookTitleLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(searchResultsListBox);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 729);
            panel1.TabIndex = 0;
            // 
            // searchResultsListBox
            // 
            searchResultsListBox.FormattingEnabled = true;
            searchResultsListBox.ItemHeight = 20;
            searchResultsListBox.Location = new Point(49, 99);
            searchResultsListBox.Name = "searchResultsListBox";
            searchResultsListBox.Size = new Size(218, 104);
            searchResultsListBox.TabIndex = 5;
            searchResultsListBox.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(searchTxtBox);
            groupBox2.Location = new Point(24, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(437, 100);
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
            button2.Location = new Point(265, 32);
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
            searchTxtBox.Location = new Point(29, 38);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.PlaceholderText = "Buscar";
            searchTxtBox.Size = new Size(218, 27);
            searchTxtBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(783, 32);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(133, 100);
            button1.TabIndex = 2;
            button1.Text = "+ Nuevo Libro";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(bookEditorialLabel);
            groupBox1.Controls.Add(bookAuthorLabel);
            groupBox1.Controls.Add(bookTitleLabel);
            groupBox1.Location = new Point(24, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(906, 269);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(368, 100);
            label3.Name = "label3";
            label3.Size = new Size(97, 22);
            label3.TabIndex = 11;
            label3.Text = "Ubicación :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(368, 47);
            label2.Name = "label2";
            label2.Size = new Size(169, 22);
            label2.TabIndex = 10;
            label2.Text = "Copias Disponibles :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 201);
            label1.Name = "label1";
            label1.Size = new Size(146, 22);
            label1.TabIndex = 9;
            label1.Text = "Año Publicación :";
            // 
            // bookEditorialLabel
            // 
            bookEditorialLabel.AutoSize = true;
            bookEditorialLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookEditorialLabel.Location = new Point(29, 151);
            bookEditorialLabel.Name = "bookEditorialLabel";
            bookEditorialLabel.Size = new Size(85, 22);
            bookEditorialLabel.TabIndex = 8;
            bookEditorialLabel.Text = "Editorial :";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookAuthorLabel.Location = new Point(29, 100);
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // BooksRegistryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 800);
            Name = "BooksRegistryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BooksRegistryForm";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox searchTxtBox;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ListBox searchResultsListBox;
        private Label bookTitleLabel;
        private Button button2;
        private Label bookAuthorLabel;
        private Label label1;
        private Label bookEditorialLabel;
        private Label label3;
        private Label label2;
    }
}