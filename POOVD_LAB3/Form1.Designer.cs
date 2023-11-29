namespace POOVD_LAB3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NNumeric = new System.Windows.Forms.NumericUpDown();
            this.BIntNumeric = new System.Windows.Forms.NumericUpDown();
            this.NLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.DotLabel = new System.Windows.Forms.Label();
            this.BFloatNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BIntNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFloatNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Name = "Series1";
            series7.YValuesPerPoint = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "Series2";
            series8.YValuesPerPoint = 2;
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(1160, 687);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "График Функции Скоростного Смаза";
            this.chart1.Titles.Add(title4);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1054, 675);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ось Y, лучи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ось T, кол-во тактов";
            // 
            // NNumeric
            // 
            this.NNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NNumeric.Location = new System.Drawing.Point(35, 705);
            this.NNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NNumeric.Name = "NNumeric";
            this.NNumeric.Size = new System.Drawing.Size(71, 26);
            this.NNumeric.TabIndex = 3;
            this.NNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NNumeric.ValueChanged += new System.EventHandler(this.NNumeric_ValueChanged);
            // 
            // BIntNumeric
            // 
            this.BIntNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BIntNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BIntNumeric.Location = new System.Drawing.Point(35, 732);
            this.BIntNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BIntNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.BIntNumeric.Name = "BIntNumeric";
            this.BIntNumeric.Size = new System.Drawing.Size(71, 26);
            this.BIntNumeric.TabIndex = 4;
            this.BIntNumeric.ValueChanged += new System.EventHandler(this.BIntNumeric_ValueChanged);
            // 
            // NLabel
            // 
            this.NLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NLabel.Location = new System.Drawing.Point(10, 707);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(21, 20);
            this.NLabel.TabIndex = 6;
            this.NLabel.Text = "N";
            // 
            // BLabel
            // 
            this.BLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BLabel.Location = new System.Drawing.Point(10, 734);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(21, 20);
            this.BLabel.TabIndex = 7;
            this.BLabel.Text = "B";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(1058, 708);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(114, 51);
            this.ApplyButton.TabIndex = 9;
            this.ApplyButton.Text = "Применить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // DotLabel
            // 
            this.DotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DotLabel.AutoSize = true;
            this.DotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DotLabel.Location = new System.Drawing.Point(113, 738);
            this.DotLabel.Name = "DotLabel";
            this.DotLabel.Size = new System.Drawing.Size(14, 20);
            this.DotLabel.TabIndex = 10;
            this.DotLabel.Text = ",";
            // 
            // BFloatNumeric
            // 
            this.BFloatNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BFloatNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BFloatNumeric.Location = new System.Drawing.Point(130, 732);
            this.BFloatNumeric.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.BFloatNumeric.Name = "BFloatNumeric";
            this.BFloatNumeric.Size = new System.Drawing.Size(74, 26);
            this.BFloatNumeric.TabIndex = 11;
            this.BFloatNumeric.ValueChanged += new System.EventHandler(this.BFloatNumeric_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.BFloatNumeric);
            this.Controls.Add(this.DotLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.BIntNumeric);
            this.Controls.Add(this.NNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BIntNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BFloatNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NNumeric;
        private System.Windows.Forms.NumericUpDown BIntNumeric;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label DotLabel;
        private System.Windows.Forms.NumericUpDown BFloatNumeric;
    }
}

