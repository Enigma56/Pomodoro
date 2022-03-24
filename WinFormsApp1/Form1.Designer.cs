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
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // timerStart
            // 
            this.timerStart.Location = new System.Drawing.Point(58, 427);
            this.timerStart.Name = "timerStart";
            this.timerStart.Size = new System.Drawing.Size(150, 46);
            this.timerStart.TabIndex = 1;
            this.timerStart.Text = "Start Timer";
            this.timerStart.UseVisualStyleBackColor = true;
            this.timerStart.Click += new System.EventHandler(this.timerStart_Click);
            // 
            // timerEnd
            // 
            this.timerEnd.Location = new System.Drawing.Point(58, 504);
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
            this.timerClock.Location = new System.Drawing.Point(454, 276);
            this.timerClock.Name = "timerClock";
            this.timerClock.Size = new System.Drawing.Size(71, 32);
            this.timerClock.TabIndex = 3;
            this.timerClock.Text = "00:00";
            // 
            // minuteOptions
            // 
            this.minuteOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteOptions.FormattingEnabled = true;
            this.minuteOptions.Location = new System.Drawing.Point(58, 88);
            this.minuteOptions.Name = "minuteOptions";
            this.minuteOptions.Size = new System.Drawing.Size(242, 40);
            this.minuteOptions.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 576);
            this.Controls.Add(this.minuteOptions);
            this.Controls.Add(this.timerClock);
            this.Controls.Add(this.timerEnd);
            this.Controls.Add(this.timerStart);
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
    }
}