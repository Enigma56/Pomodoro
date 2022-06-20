namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.timerStart = new System.Windows.Forms.Button();
            this.timerEnd = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Label();
            this.minuteOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.breakOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.oneMinuteIncrease = new System.Windows.Forms.Button();
            this.oneMinuteDecrease = new System.Windows.Forms.Button();
            this.decreaseFiveSeconds = new System.Windows.Forms.Button();
            this.fiveSecondIncrease = new System.Windows.Forms.Button();
            this.decreaseThirtySeconds = new System.Windows.Forms.Button();
            this.increaseThirtySeconds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // timerStart
            // 
            this.timerStart.Location = new System.Drawing.Point(390, 74);
            this.timerStart.Name = "timerStart";
            this.timerStart.Size = new System.Drawing.Size(150, 46);
            this.timerStart.TabIndex = 1;
            this.timerStart.Text = "Start Timer";
            this.timerStart.UseVisualStyleBackColor = true;
            this.timerStart.Click += new System.EventHandler(this.timerStart_Click);
            // 
            // timerEnd
            // 
            this.timerEnd.Location = new System.Drawing.Point(584, 74);
            this.timerEnd.Name = "timerEnd";
            this.timerEnd.Size = new System.Drawing.Size(150, 46);
            this.timerEnd.TabIndex = 2;
            this.timerEnd.Text = "End Timer";
            this.timerEnd.UseVisualStyleBackColor = true;
            this.timerEnd.Click += new System.EventHandler(this.timerEnd_Click);
            // 
            // timerClock
            // 
            this.timerClock.AutoSize = true;
            this.timerClock.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.timerClock.Location = new System.Drawing.Point(190, 194);
            this.timerClock.Name = "timerClock";
            this.timerClock.Size = new System.Drawing.Size(399, 161);
            this.timerClock.TabIndex = 3;
            this.timerClock.Text = "00:00";
            // 
            // minuteOptions
            // 
            this.minuteOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteOptions.FormattingEnabled = true;
            this.minuteOptions.Location = new System.Drawing.Point(58, 74);
            this.minuteOptions.Name = "minuteOptions";
            this.minuteOptions.Size = new System.Drawing.Size(242, 40);
            this.minuteOptions.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Minute Options:";
            // 
            // breakOptions
            // 
            this.breakOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.breakOptions.FormattingEnabled = true;
            this.breakOptions.Location = new System.Drawing.Point(58, 516);
            this.breakOptions.Name = "breakOptions";
            this.breakOptions.Size = new System.Drawing.Size(242, 40);
            this.breakOptions.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Break Length:";
            // 
            // breakTimer
            // 
            this.breakTimer.Tick += new System.EventHandler(this.breakTimer_Tick);
            // 
            // oneMinuteIncrease
            // 
            this.oneMinuteIncrease.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneMinuteIncrease.Location = new System.Drawing.Point(223, 370);
            this.oneMinuteIncrease.Name = "oneMinuteIncrease";
            this.oneMinuteIncrease.Size = new System.Drawing.Size(82, 52);
            this.oneMinuteIncrease.TabIndex = 9;
            this.oneMinuteIncrease.Text = "+1 M";
            this.oneMinuteIncrease.UseVisualStyleBackColor = true;
            this.oneMinuteIncrease.Click += new System.EventHandler(this.oneMinuteIncrease_Click);
            // 
            // oneMinuteDecrease
            // 
            this.oneMinuteDecrease.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneMinuteDecrease.Location = new System.Drawing.Point(311, 370);
            this.oneMinuteDecrease.Name = "oneMinuteDecrease";
            this.oneMinuteDecrease.Size = new System.Drawing.Size(68, 52);
            this.oneMinuteDecrease.TabIndex = 10;
            this.oneMinuteDecrease.Text = "-1 M";
            this.oneMinuteDecrease.UseVisualStyleBackColor = true;
            // 
            // decreaseFiveSeconds
            // 
            this.decreaseFiveSeconds.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decreaseFiveSeconds.Location = new System.Drawing.Point(485, 370);
            this.decreaseFiveSeconds.Name = "decreaseFiveSeconds";
            this.decreaseFiveSeconds.Size = new System.Drawing.Size(68, 52);
            this.decreaseFiveSeconds.TabIndex = 12;
            this.decreaseFiveSeconds.Text = "-5 S";
            this.decreaseFiveSeconds.UseVisualStyleBackColor = true;
            // 
            // fiveSecondIncrease
            // 
            this.fiveSecondIncrease.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fiveSecondIncrease.Location = new System.Drawing.Point(410, 370);
            this.fiveSecondIncrease.Name = "fiveSecondIncrease";
            this.fiveSecondIncrease.Size = new System.Drawing.Size(68, 52);
            this.fiveSecondIncrease.TabIndex = 11;
            this.fiveSecondIncrease.Text = "+5 S";
            this.fiveSecondIncrease.UseVisualStyleBackColor = true;
            // 
            // decreaseThirtySeconds
            // 
            this.decreaseThirtySeconds.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decreaseThirtySeconds.Location = new System.Drawing.Point(485, 428);
            this.decreaseThirtySeconds.Name = "decreaseThirtySeconds";
            this.decreaseThirtySeconds.Size = new System.Drawing.Size(85, 52);
            this.decreaseThirtySeconds.TabIndex = 14;
            this.decreaseThirtySeconds.Text = "-30 S";
            this.decreaseThirtySeconds.UseVisualStyleBackColor = true;
            // 
            // increaseThirtySeconds
            // 
            this.increaseThirtySeconds.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.increaseThirtySeconds.Location = new System.Drawing.Point(390, 428);
            this.increaseThirtySeconds.Name = "increaseThirtySeconds";
            this.increaseThirtySeconds.Size = new System.Drawing.Size(88, 52);
            this.increaseThirtySeconds.TabIndex = 13;
            this.increaseThirtySeconds.Text = "+30 S";
            this.increaseThirtySeconds.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 617);
            this.Controls.Add(this.decreaseThirtySeconds);
            this.Controls.Add(this.increaseThirtySeconds);
            this.Controls.Add(this.decreaseFiveSeconds);
            this.Controls.Add(this.fiveSecondIncrease);
            this.Controls.Add(this.oneMinuteDecrease);
            this.Controls.Add(this.oneMinuteIncrease);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.breakOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minuteOptions);
            this.Controls.Add(this.timerClock);
            this.Controls.Add(this.timerEnd);
            this.Controls.Add(this.timerStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button timerStart;
        private System.Windows.Forms.Button timerEnd;
        private System.Windows.Forms.Label timerClock;
        private System.Windows.Forms.ComboBox minuteOptions;
        private System.Windows.Forms.Label label1; //"Minute Options"
        private System.Windows.Forms.ComboBox breakOptions;
        private System.Windows.Forms.Label label2; //"Break Length"
        private System.Windows.Forms.Timer breakTimer;
        private System.Windows.Forms.Button oneMinuteIncrease;
        private System.Windows.Forms.Button oneMinuteDecrease;
        private System.Windows.Forms.Button decreaseFiveSeconds;
        private System.Windows.Forms.Button fiveSecondIncrease;
        private System.Windows.Forms.Button decreaseThirtySeconds;
        private System.Windows.Forms.Button increaseThirtySeconds;
    }
}