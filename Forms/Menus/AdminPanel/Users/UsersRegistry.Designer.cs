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
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            bookAuthorLabel = new Label();
            bookTitleLabel = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            searchTxtBox = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(12, 598);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(198, 39);
            button1.TabIndex = 2;
            button1.Text = "+ Nuevo Prestamo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(21, 43);
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
            label4.Location = new Point(142, 94);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 12;
            label4.Text = "      ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(140, 54);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 11;
            label3.Text = "      ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(540, 31);
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
            bookAuthorLabel.Location = new Point(71, 90);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(78, 22);
            bookAuthorLabel.TabIndex = 7;
            bookAuthorLabel.Text = "Nombre:";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookTitleLabel.Location = new Point(71, 52);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(67, 22);
            bookTitleLabel.TabIndex = 6;
            bookTitleLabel.Text = "Carnet:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(searchTxtBox);
            groupBox2.Location = new Point(95, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(667, 90);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscador";
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(460, 27);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(143, 37);
            button2.TabIndex = 1;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += handleUserSearchById;
            // 
            // searchTxtBox
            // 
            searchTxtBox.BackColor = SystemColors.Control;
            searchTxtBox.Location = new Point(64, 33);
            searchTxtBox.MaxLength = 100;
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.PlaceholderText = "Buscar";
            searchTxtBox.Size = new Size(379, 27);
            searchTxtBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(795, 204);
            dataGridView1.TabIndex = 8;
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
            groupBox1.Location = new Point(98, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(664, 167);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 307);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(832, 267);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Prestamos Manager";
            // 
            // button3
            // 
            button3.Location = new Point(754, 614);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SeaGreen;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Snow;
            button6.Location = new Point(239, 598);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(198, 39);
            button6.TabIndex = 3;
            button6.Text = "+ Registrar Usuario";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // UsersRegistry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 655);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Name = "UsersRegistry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersRegistry";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label bookAuthorLabel;
        private Label bookTitleLabel;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox searchTxtBox;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button button3;
        private Button button6;
    }
}