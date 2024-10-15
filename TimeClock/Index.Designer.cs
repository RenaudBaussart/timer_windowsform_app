namespace TimeClock
{
    partial class Index
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TimerSeterTextBox = new System.Windows.Forms.TextBox();
            this.TimerProgessBar = new System.Windows.Forms.ProgressBar();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.MainScreen = new System.Windows.Forms.GroupBox();
            this.SetTimerButton = new System.Windows.Forms.Button();
            this.TimerTimer = new System.Windows.Forms.Timer(this.components);
            this.MainScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Chartreuse;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(158, 371);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Yellow;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(418, 371);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(675, 371);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // TimerSeterTextBox
            // 
            this.TimerSeterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TimerSeterTextBox.Location = new System.Drawing.Point(418, 434);
            this.TimerSeterTextBox.Name = "TimerSeterTextBox";
            this.TimerSeterTextBox.Size = new System.Drawing.Size(75, 23);
            this.TimerSeterTextBox.TabIndex = 5;
            this.TimerSeterTextBox.Text = "00:00:00";
            this.TimerSeterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimerProgessBar
            // 
            this.TimerProgessBar.ForeColor = System.Drawing.Color.Green;
            this.TimerProgessBar.Location = new System.Drawing.Point(148, 307);
            this.TimerProgessBar.Name = "TimerProgessBar";
            this.TimerProgessBar.Size = new System.Drawing.Size(613, 38);
            this.TimerProgessBar.TabIndex = 6;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 45.75F);
            this.TimerLabel.Location = new System.Drawing.Point(319, 166);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(284, 71);
            this.TimerLabel.TabIndex = 4;
            this.TimerLabel.Text = "00:00:00";
            // 
            // MainScreen
            // 
            this.MainScreen.Controls.Add(this.SetTimerButton);
            this.MainScreen.Controls.Add(this.TimerProgessBar);
            this.MainScreen.Controls.Add(this.TimerSeterTextBox);
            this.MainScreen.Controls.Add(this.TimerLabel);
            this.MainScreen.Controls.Add(this.ClearButton);
            this.MainScreen.Controls.Add(this.ResetButton);
            this.MainScreen.Controls.Add(this.StartButton);
            this.MainScreen.Location = new System.Drawing.Point(12, 12);
            this.MainScreen.Name = "MainScreen";
            this.MainScreen.Size = new System.Drawing.Size(919, 482);
            this.MainScreen.TabIndex = 7;
            this.MainScreen.TabStop = false;
            this.MainScreen.Text = "MainScreen";
            // 
            // SetTimerButton
            // 
            this.SetTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimerButton.Location = new System.Drawing.Point(499, 434);
            this.SetTimerButton.Name = "SetTimerButton";
            this.SetTimerButton.Size = new System.Drawing.Size(41, 23);
            this.SetTimerButton.TabIndex = 7;
            this.SetTimerButton.Text = "SET";
            this.SetTimerButton.UseVisualStyleBackColor = true;
            this.SetTimerButton.Click += new System.EventHandler(this.SetTimerButton_Click);
            // 
            // TimerTimer
            // 
            this.TimerTimer.Interval = 1000;
            this.TimerTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 506);
            this.Controls.Add(this.MainScreen);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.Text = "Time Clock";
            this.MainScreen.ResumeLayout(false);
            this.MainScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox TimerSeterTextBox;
        private System.Windows.Forms.ProgressBar TimerProgessBar;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.GroupBox MainScreen;
        private System.Windows.Forms.Button SetTimerButton;
        private System.Windows.Forms.Timer TimerTimer;
    }
}

