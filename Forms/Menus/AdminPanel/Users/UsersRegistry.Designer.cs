namespace ChallengeOneLibraryDAS01.Forms.Menus.AdminPanel.Users
{
    partial class UsersRegistry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersRegistry));
            button1 = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            bookAuthorLabel = new Label();
            bookTitleLabel = new Label();
            groupBox2 = new GroupBox();
            searchResultsListBox = new ListBox();
            groupBox3 = new GroupBox();
            rdBtnTitle = new RadioButton();
            rdBtnId = new RadioButton();
            button2 = new Button();
            searchTxtBox = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(12, 544);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(198, 39);
            button1.TabIndex = 5;
            button1.Text = "+ Nuevo Libro";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(bookAuthorLabel);
            groupBox1.Controls.Add(bookTitleLabel);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(701, 193);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(6, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(44, 86);
            panel1.TabIndex = 22;
            panel1.Visible = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(5, 10);
            button4.Name = "button4";
            button4.Size = new Size(37, 28);
            button4.TabIndex = 16;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(2, 46);
            button5.Name = "button5";
            button5.Size = new Size(37, 28);
            button5.TabIndex = 17;
            button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 89);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 12;
            label4.Text = "      ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(125, 49);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 11;
            label3.Text = "      ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(473, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookAuthorLabel.Location = new Point(56, 85);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(78, 22);
            bookAuthorLabel.TabIndex = 7;
            bookAuthorLabel.Text = "Nombre:";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookTitleLabel.Location = new Point(56, 47);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(67, 22);
            bookTitleLabel.TabIndex = 6;
            bookTitleLabel.Text = "Carnet:";
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
            groupBox2.Size = new Size(701, 193);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscador";
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
            button2.Location = new Point(473, 32);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(143, 37);
            button2.TabIndex = 6;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(171, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 8;
            // 
            // UsersRegistry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 601);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "UsersRegistry";
            Text = "UsersRegistry";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label bookAuthorLabel;
        private Label bookTitleLabel;
        private GroupBox groupBox2;
        private ListBox searchResultsListBox;
        private GroupBox groupBox3;
        private RadioButton rdBtnTitle;
        private RadioButton rdBtnId;
        private Button button2;
        private TextBox searchTxtBox;
        private DataGridView dataGridView1;
    }
}