namespace Sort
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bGen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox_Isxodny = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox_Itogovy = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSort = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hysto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.iterations = new System.Windows.Forms.Label();
            this.iterations0 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hysto)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер массива";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(149, 16);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // bGen
            // 
            this.bGen.Location = new System.Drawing.Point(243, 14);
            this.bGen.Margin = new System.Windows.Forms.Padding(4);
            this.bGen.Name = "bGen";
            this.bGen.Size = new System.Drawing.Size(163, 30);
            this.bGen.TabIndex = 2;
            this.bGen.Text = "Сгенерировать";
            this.bGen.UseVisualStyleBackColor = true;
            this.bGen.Click += new System.EventHandler(this.bGen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(4, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 16, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(625, 247);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходный массив данных";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox_Isxodny);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(617, 224);
            this.panel2.TabIndex = 1;
            // 
            // listBox_Isxodny
            // 
            this.listBox_Isxodny.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_Isxodny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Isxodny.ColumnWidth = 45;
            this.listBox_Isxodny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Isxodny.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_Isxodny.FormattingEnabled = true;
            this.listBox_Isxodny.IntegralHeight = false;
            this.listBox_Isxodny.Location = new System.Drawing.Point(13, 0);
            this.listBox_Isxodny.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Isxodny.MultiColumn = true;
            this.listBox_Isxodny.Name = "listBox_Isxodny";
            this.listBox_Isxodny.Size = new System.Drawing.Size(604, 224);
            this.listBox_Isxodny.TabIndex = 0;
            this.listBox_Isxodny.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 597);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(4, 333);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(625, 260);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отсортированный массив";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox_Itogovy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 19);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(617, 237);
            this.panel3.TabIndex = 2;
            // 
            // listBox_Itogovy
            // 
            this.listBox_Itogovy.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_Itogovy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Itogovy.ColumnWidth = 45;
            this.listBox_Itogovy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Itogovy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_Itogovy.FormattingEnabled = true;
            this.listBox_Itogovy.IntegralHeight = false;
            this.listBox_Itogovy.Location = new System.Drawing.Point(13, 0);
            this.listBox_Itogovy.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Itogovy.MultiColumn = true;
            this.listBox_Itogovy.Name = "listBox_Itogovy";
            this.listBox_Itogovy.Size = new System.Drawing.Size(604, 237);
            this.listBox_Itogovy.TabIndex = 1;
            this.listBox_Itogovy.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bSort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bGen);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 54);
            this.panel1.TabIndex = 4;
            // 
            // bSort
            // 
            this.bSort.Location = new System.Drawing.Point(441, 14);
            this.bSort.Margin = new System.Windows.Forms.Padding(4);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(163, 30);
            this.bSort.TabIndex = 3;
            this.bSort.Text = "Сортировать";
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.bSort_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.hysto);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(633, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(988, 597);
            this.panel4.TabIndex = 5;
            // 
            // hysto
            // 
            chartArea1.Name = "ChartArea1";
            this.hysto.ChartAreas.Add(chartArea1);
            this.hysto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hysto.Location = new System.Drawing.Point(0, 0);
            this.hysto.Margin = new System.Windows.Forms.Padding(4);
            this.hysto.Name = "hysto";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.LightGray;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.LabelForeColor = System.Drawing.Color.MidnightBlue;
            series1.Name = "Series1";
            this.hysto.Series.Add(series1);
            this.hysto.Size = new System.Drawing.Size(988, 538);
            this.hysto.TabIndex = 1;
            this.hysto.Text = "chart1";
            this.hysto.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            title1.Name = "Title1";
            title1.Text = "Шкала";
            this.hysto.Titles.Add(title1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.trackBar1);
            this.panel5.Controls.Add(this.iterations);
            this.panel5.Controls.Add(this.iterations0);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 538);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(988, 59);
            this.panel5.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(47, 0);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(894, 59);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // iterations
            // 
            this.iterations.Dock = System.Windows.Forms.DockStyle.Right;
            this.iterations.Location = new System.Drawing.Point(941, 0);
            this.iterations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(47, 59);
            this.iterations.TabIndex = 1;
            this.iterations.Text = "1000";
            this.iterations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iterations0
            // 
            this.iterations0.Dock = System.Windows.Forms.DockStyle.Left;
            this.iterations0.Location = new System.Drawing.Point(0, 0);
            this.iterations0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iterations0.Name = "iterations0";
            this.iterations0.Size = new System.Drawing.Size(47, 59);
            this.iterations0.TabIndex = 0;
            this.iterations0.Text = "0";
            this.iterations0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(629, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 597);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 597);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(647, 426);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка расчёской";
            this.Load += new System.EventHandler(this.Work_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hysto)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bGen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox_Isxodny;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox_Itogovy;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label iterations;
        private System.Windows.Forms.Label iterations0;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart hysto;
    }
}