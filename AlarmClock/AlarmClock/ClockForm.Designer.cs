﻿namespace AlarmClock
{
    partial class ClockForm
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
            this.components = new System.ComponentModel.Container();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.FocusPeriodsButton = new System.Windows.Forms.Button();
            this.TimerButton = new System.Windows.Forms.Button();
            this.StopwatchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.BackColor = System.Drawing.Color.Black;
            this.DisplayLabel.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.DisplayLabel.Location = new System.Drawing.Point(13, 13);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(228, 83);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "00:00:00";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(247, 13);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(120, 23);
            this.AboutButton.TabIndex = 1;
            this.AboutButton.Text = "О программе";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(247, 43);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(120, 23);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AccessibleDescription = "";
            this.ExitButton.Location = new System.Drawing.Point(247, 73);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(120, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Enabled = true;
            this.AlarmTimer.Interval = 1000;
            this.AlarmTimer.Tick += new System.EventHandler(this.AlarmTimer_Tick);
            // 
            // FocusPeriodsButton
            // 
            this.FocusPeriodsButton.Location = new System.Drawing.Point(374, 13);
            this.FocusPeriodsButton.Name = "FocusPeriodsButton";
            this.FocusPeriodsButton.Size = new System.Drawing.Size(132, 23);
            this.FocusPeriodsButton.TabIndex = 4;
            this.FocusPeriodsButton.Text = "Периоды фокусировки";
            this.FocusPeriodsButton.UseVisualStyleBackColor = true;
            this.FocusPeriodsButton.Click += new System.EventHandler(this.FocusPeriodsButton_Click);
            // 
            // TimerButton
            // 
            this.TimerButton.Location = new System.Drawing.Point(374, 43);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(132, 23);
            this.TimerButton.TabIndex = 5;
            this.TimerButton.Text = "Таймер";
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // StopwatchButton
            // 
            this.StopwatchButton.Location = new System.Drawing.Point(374, 73);
            this.StopwatchButton.Name = "StopwatchButton";
            this.StopwatchButton.Size = new System.Drawing.Size(132, 23);
            this.StopwatchButton.TabIndex = 6;
            this.StopwatchButton.Text = "Секундомер";
            this.StopwatchButton.UseVisualStyleBackColor = true;
            this.StopwatchButton.Click += new System.EventHandler(this.StopwatchButton_Click);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 111);
            this.Controls.Add(this.StopwatchButton);
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.FocusPeriodsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.DisplayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClockForm";
            this.Text = "Будильник";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer AlarmTimer;
        private System.Windows.Forms.Button FocusPeriodsButton;
        private System.Windows.Forms.Button TimerButton;
        private System.Windows.Forms.Button StopwatchButton;
    }
}

