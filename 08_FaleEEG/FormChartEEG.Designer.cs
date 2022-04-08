namespace _08_FaleEEG
{
    partial class FormChartEEG
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartEEG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanelConfig = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxSum = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEEG)).BeginInit();
            this.flowLayoutPanelConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.Controls.Add(this.chartEEG, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelConfig, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartEEG
            // 
            chartArea3.Name = "ChartArea1";
            this.chartEEG.ChartAreas.Add(chartArea3);
            this.chartEEG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartEEG.Location = new System.Drawing.Point(3, 3);
            this.chartEEG.Name = "chartEEG";
            this.chartEEG.Size = new System.Drawing.Size(609, 424);
            this.chartEEG.TabIndex = 0;
            this.chartEEG.Text = "chart1";
            // 
            // flowLayoutPanelConfig
            // 
            this.flowLayoutPanelConfig.AutoSize = true;
            this.flowLayoutPanelConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelConfig.Controls.Add(this.checkBoxSum);
            this.flowLayoutPanelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelConfig.Location = new System.Drawing.Point(618, 3);
            this.flowLayoutPanelConfig.Name = "flowLayoutPanelConfig";
            this.flowLayoutPanelConfig.Size = new System.Drawing.Size(179, 424);
            this.flowLayoutPanelConfig.TabIndex = 1;
            // 
            // checkBoxSum
            // 
            this.checkBoxSum.AutoSize = true;
            this.checkBoxSum.Location = new System.Drawing.Point(3, 3);
            this.checkBoxSum.Name = "checkBoxSum";
            this.checkBoxSum.Size = new System.Drawing.Size(105, 17);
            this.checkBoxSum.TabIndex = 0;
            this.checkBoxSum.Text = "EEG - wave sum";
            this.checkBoxSum.UseVisualStyleBackColor = true;
            this.checkBoxSum.CheckedChanged += new System.EventHandler(this.checkBoxSum_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 433);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 14);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormChartEEG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormChartEEG";
            this.Text = "ChartEEG";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEEG)).EndInit();
            this.flowLayoutPanelConfig.ResumeLayout(false);
            this.flowLayoutPanelConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEEG;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelConfig;
        private System.Windows.Forms.CheckBox checkBoxSum;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

