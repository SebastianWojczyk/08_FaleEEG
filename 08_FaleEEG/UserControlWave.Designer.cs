namespace _08_FaleEEG
{
    partial class UserControlWave
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxVisible = new System.Windows.Forms.CheckBox();
            this.numericUpDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAmplitude = new System.Windows.Forms.NumericUpDown();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).BeginInit();
            this.groupBoxName.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxVisible
            // 
            this.checkBoxVisible.AutoSize = true;
            this.checkBoxVisible.Checked = true;
            this.checkBoxVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVisible.Location = new System.Drawing.Point(6, 19);
            this.checkBoxVisible.Name = "checkBoxVisible";
            this.checkBoxVisible.Size = new System.Drawing.Size(56, 17);
            this.checkBoxVisible.TabIndex = 1;
            this.checkBoxVisible.Text = "Visible";
            this.checkBoxVisible.UseVisualStyleBackColor = true;
            this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.parameter_Changed);
            // 
            // numericUpDownFrequency
            // 
            this.numericUpDownFrequency.Location = new System.Drawing.Point(69, 42);
            this.numericUpDownFrequency.Name = "numericUpDownFrequency";
            this.numericUpDownFrequency.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownFrequency.TabIndex = 2;
            this.numericUpDownFrequency.ValueChanged += new System.EventHandler(this.parameter_Changed);
            // 
            // numericUpDownAmplitude
            // 
            this.numericUpDownAmplitude.Location = new System.Drawing.Point(69, 68);
            this.numericUpDownAmplitude.Name = "numericUpDownAmplitude";
            this.numericUpDownAmplitude.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownAmplitude.TabIndex = 3;
            this.numericUpDownAmplitude.ValueChanged += new System.EventHandler(this.parameter_Changed);
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.label2);
            this.groupBoxName.Controls.Add(this.label1);
            this.groupBoxName.Controls.Add(this.numericUpDownAmplitude);
            this.groupBoxName.Controls.Add(this.checkBoxVisible);
            this.groupBoxName.Controls.Add(this.numericUpDownFrequency);
            this.groupBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxName.Location = new System.Drawing.Point(0, 0);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(169, 97);
            this.groupBoxName.TabIndex = 4;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amplitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Frequency";
            // 
            // UserControlWave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxName);
            this.Name = "UserControlWave";
            this.Size = new System.Drawing.Size(169, 97);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplitude)).EndInit();
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxVisible;
        private System.Windows.Forms.NumericUpDown numericUpDownFrequency;
        private System.Windows.Forms.NumericUpDown numericUpDownAmplitude;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
