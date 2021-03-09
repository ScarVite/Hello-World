namespace NGG_GUI
{
    partial class gui
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
            this.compBt = new System.Windows.Forms.Button();
            this.guess = new System.Windows.Forms.TextBox();
            this.lastNumbers = new System.Windows.Forms.TextBox();
            this.LastNumLabel = new System.Windows.Forms.Label();
            this.GuessLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compBt
            // 
            this.compBt.Location = new System.Drawing.Point(155, 381);
            this.compBt.Name = "compBt";
            this.compBt.Size = new System.Drawing.Size(196, 49);
            this.compBt.TabIndex = 0;
            this.compBt.Text = "Compare";
            this.compBt.UseVisualStyleBackColor = true;
            this.compBt.Click += new System.EventHandler(this.compare);
            // 
            // guess
            // 
            this.guess.HideSelection = false;
            this.guess.Location = new System.Drawing.Point(155, 327);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(196, 20);
            this.guess.TabIndex = 1;
            this.guess.Text = "Please A Number Between 1-100";
            this.guess.GotFocus += new System.EventHandler(this.RemoveText);
            this.guess.LostFocus += new System.EventHandler(this.AddText);
            // 
            // lastNumbers
            // 
            this.lastNumbers.Location = new System.Drawing.Point(55, 58);
            this.lastNumbers.Multiline = true;
            this.lastNumbers.Name = "lastNumbers";
            this.lastNumbers.ReadOnly = true;
            this.lastNumbers.Size = new System.Drawing.Size(360, 193);
            this.lastNumbers.TabIndex = 2;
            // 
            // LastNumLabel
            // 
            this.LastNumLabel.AutoSize = true;
            this.LastNumLabel.Location = new System.Drawing.Point(52, 42);
            this.LastNumLabel.Name = "LastNumLabel";
            this.LastNumLabel.Size = new System.Drawing.Size(75, 13);
            this.LastNumLabel.TabIndex = 3;
            this.LastNumLabel.Text = "Last Numbers:";
            // 
            // GuessLab
            // 
            this.GuessLab.AutoSize = true;
            this.GuessLab.Location = new System.Drawing.Point(152, 311);
            this.GuessLab.Name = "GuessLab";
            this.GuessLab.Size = new System.Drawing.Size(65, 13);
            this.GuessLab.TabIndex = 4;
            this.GuessLab.Text = "Your Guess:";
            // 
            // gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.GuessLab);
            this.Controls.Add(this.LastNumLabel);
            this.Controls.Add(this.lastNumbers);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.compBt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // TODO: Das geht noch nicht so ganz
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Name = "gui";
            this.Text = "Number Guessing Game GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compBt;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.TextBox lastNumbers;
        private System.Windows.Forms.Label LastNumLabel;
        private System.Windows.Forms.Label GuessLab;
    }
}

