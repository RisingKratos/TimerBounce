﻿namespace BounceWithTimer
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
            this.components = new System.ComponentModel.Container();
            this.Starter = new System.Windows.Forms.Button();
            this.BouncingTimer = new System.Windows.Forms.Timer(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.OpenAndUseButton = new System.Windows.Forms.Button();
            this.StopTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Starter
            // 
            this.Starter.Location = new System.Drawing.Point(0, 0);
            this.Starter.Name = "Starter";
            this.Starter.Size = new System.Drawing.Size(284, 23);
            this.Starter.TabIndex = 0;
            this.Starter.Text = "Да начнется залипалка!!!";
            this.Starter.UseVisualStyleBackColor = true;
            this.Starter.Click += new System.EventHandler(this.Starter_Click);
            // 
            // BouncingTimer
            // 
            this.BouncingTimer.Interval = 1;
            this.BouncingTimer.Tick += new System.EventHandler(this.BouncingTimer_Tick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(0, 133);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(284, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить залипалку, чтобы потом залипнуть снова";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // OpenAndUseButton
            // 
            this.OpenAndUseButton.Location = new System.Drawing.Point(0, 104);
            this.OpenAndUseButton.Name = "OpenAndUseButton";
            this.OpenAndUseButton.Size = new System.Drawing.Size(284, 23);
            this.OpenAndUseButton.TabIndex = 2;
            this.OpenAndUseButton.Text = "Залипалку с прошлого раза";
            this.OpenAndUseButton.UseVisualStyleBackColor = true;
            this.OpenAndUseButton.Click += new System.EventHandler(this.OpenAndUseButton_Click);
            // 
            // StopTimer
            // 
            this.StopTimer.Location = new System.Drawing.Point(0, 75);
            this.StopTimer.Name = "StopTimer";
            this.StopTimer.Size = new System.Drawing.Size(284, 23);
            this.StopTimer.TabIndex = 3;
            this.StopTimer.Text = "Остановить залипалку";
            this.StopTimer.UseVisualStyleBackColor = true;
            this.StopTimer.Click += new System.EventHandler(this.StopTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.StopTimer);
            this.Controls.Add(this.OpenAndUseButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.Starter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Starter;
        private System.Windows.Forms.Timer BouncingTimer;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button OpenAndUseButton;
        private System.Windows.Forms.Button StopTimer;
    }
}

