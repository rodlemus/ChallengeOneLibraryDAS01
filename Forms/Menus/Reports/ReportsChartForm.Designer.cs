namespace ChallengeOneLibraryDAS01.Forms.Menus.Reports
{
    partial class ReportsChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel4 = new Panel();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            panel3 = new Panel();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            panel2 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(26, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 726);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Controls.Add(chart3);
            panel4.Location = new Point(67, 53);
            panel4.Name = "panel4";
            panel4.Size = new Size(1146, 288);
            panel4.TabIndex = 4;
            // 
            // chart3
            // 
            chart3.BorderlineColor = Color.IndianRed;
            chart3.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart3.Legends.Add(legend1);
            chart3.Location = new Point(4, 4);
            chart3.Name = "chart3";
            chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart3.Series.Add(series1);
            chart3.Size = new Size(1138, 281);
            chart3.TabIndex = 0;
            chart3.Text = "chart3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 16);
            label3.Name = "label3";
            label3.Size = new Size(271, 25);
            label3.TabIndex = 3;
            label3.Text = "Total de préstamos por usuario";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(chart2);
            panel3.Location = new Point(681, 418);
            panel3.Name = "panel3";
            panel3.Size = new Size(532, 288);
            panel3.TabIndex = 4;
            // 
            // chart2
            // 
            chart2.BorderlineColor = Color.IndianRed;
            chart2.BorderlineWidth = 5;
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(4, 4);
            chart2.Name = "chart2";
            chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(524, 281);
            chart2.TabIndex = 0;
            chart2.Text = "chart2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(681, 381);
            label2.Name = "label2";
            label2.Size = new Size(260, 25);
            label2.TabIndex = 3;
            label2.Text = "Número de Libros por Author";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(chart1);
            panel2.Location = new Point(67, 418);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 288);
            panel2.TabIndex = 2;
            // 
            // chart1
            // 
            chart1.BorderlineColor = Color.IndianRed;
            chart1.BorderlineWidth = 5;
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(4, 4);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(524, 281);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 381);
            label1.Name = "label1";
            label1.Size = new Size(260, 25);
            label1.TabIndex = 1;
            label1.Text = "Número de Libros por Author";
            // 
            // button1
            // 
            button1.Location = new Point(1138, 760);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 2;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReportsChartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 801);
            Controls.Add(button1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "ReportsChartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportsChartForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label2;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Label label3;
        private Button button1;
    }
}