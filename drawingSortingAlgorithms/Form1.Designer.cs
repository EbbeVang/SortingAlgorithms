namespace drawingSortingAlgorithms
{
    partial class Form1
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
            this.labelSortHeader = new System.Windows.Forms.Label();
            this.panelSortingGraphics = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxSortingAlgorithm = new System.Windows.Forms.ComboBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStepForward = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSortHeader
            // 
            this.labelSortHeader.AutoSize = true;
            this.labelSortHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortHeader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSortHeader.Location = new System.Drawing.Point(47, 33);
            this.labelSortHeader.Name = "labelSortHeader";
            this.labelSortHeader.Size = new System.Drawing.Size(272, 26);
            this.labelSortHeader.TabIndex = 0;
            this.labelSortHeader.Text = "Choose a sorting algorithm";
            // 
            // panelSortingGraphics
            // 
            this.panelSortingGraphics.Location = new System.Drawing.Point(46, 75);
            this.panelSortingGraphics.Name = "panelSortingGraphics";
            this.panelSortingGraphics.Size = new System.Drawing.Size(730, 278);
            this.panelSortingGraphics.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(173, 361);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxSortingAlgorithm
            // 
            this.comboBoxSortingAlgorithm.FormattingEnabled = true;
            this.comboBoxSortingAlgorithm.Items.AddRange(new object[] {
            "Selection sort",
            "Insertion sort",
            "Bubble sort",
            "Merge sort",
            "Quick sort"});
            this.comboBoxSortingAlgorithm.Location = new System.Drawing.Point(46, 361);
            this.comboBoxSortingAlgorithm.Name = "comboBoxSortingAlgorithm";
            this.comboBoxSortingAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSortingAlgorithm.TabIndex = 3;
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(254, 361);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 4;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(335, 361);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonStepForward
            // 
            this.buttonStepForward.Location = new System.Drawing.Point(416, 361);
            this.buttonStepForward.Name = "buttonStepForward";
            this.buttonStepForward.Size = new System.Drawing.Size(108, 23);
            this.buttonStepForward.TabIndex = 6;
            this.buttonStepForward.Text = ">> step forward";
            this.buttonStepForward.UseVisualStyleBackColor = true;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(701, 361);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 7;
            this.buttonRandom.Text = "Randomize";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 407);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonStepForward);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.comboBoxSortingAlgorithm);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelSortingGraphics);
            this.Controls.Add(this.labelSortHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSortHeader;
        private System.Windows.Forms.Panel panelSortingGraphics;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxSortingAlgorithm;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStepForward;
        private System.Windows.Forms.Button buttonRandom;
    }
}

