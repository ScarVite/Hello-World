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
            this.numpadBtn = new System.Windows.Forms.Button();
            this.DifficultyBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // compBt
            // 
            this.compBt.Location = new System.Drawing.Point(207, 469);
            this.compBt.Margin = new System.Windows.Forms.Padding(4);
            this.compBt.Name = "compBt";
            this.compBt.Size = new System.Drawing.Size(261, 60);
            this.compBt.TabIndex = 0;
            this.compBt.Text = "Compare";
            this.compBt.UseVisualStyleBackColor = true;
            this.compBt.Click += new System.EventHandler(this.compare);
            // 
            // guess
            // 
            this.guess.HideSelection = false;
            this.guess.Location = new System.Drawing.Point(85, 395);
            this.guess.Margin = new System.Windows.Forms.Padding(4);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(362, 22);
            this.guess.TabIndex = 1;
            this.guess.Text = "Please A Number Between 1-100";
            this.guess.GotFocus += new System.EventHandler(this.RemoveText);
            this.guess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guess_KeyDown);
            this.guess.LostFocus += new System.EventHandler(this.AddText);
            // 
            // lastNumbers
            // 
            this.lastNumbers.Location = new System.Drawing.Point(13, 73);
            this.lastNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.lastNumbers.Multiline = true;
            this.lastNumbers.Name = "lastNumbers";
            this.lastNumbers.ReadOnly = true;
            this.lastNumbers.Size = new System.Drawing.Size(479, 237);
            this.lastNumbers.TabIndex = 2;
            // 
            // LastNumLabel
            // 
            this.LastNumLabel.AutoSize = true;
            this.LastNumLabel.Location = new System.Drawing.Point(13, 52);
            this.LastNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNumLabel.Name = "LastNumLabel";
            this.LastNumLabel.Size = new System.Drawing.Size(100, 17);
            this.LastNumLabel.TabIndex = 3;
            this.LastNumLabel.Text = "Last Numbers:";
            // 
            // GuessLab
            // 
            this.GuessLab.AutoSize = true;
            this.GuessLab.Location = new System.Drawing.Point(82, 374);
            this.GuessLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GuessLab.Name = "GuessLab";
            this.GuessLab.Size = new System.Drawing.Size(87, 17);
            this.GuessLab.TabIndex = 4;
            this.GuessLab.Text = "Your Guess:";
            // 
            // numpadBtn
            // 
            this.numpadBtn.Location = new System.Drawing.Point(564, 374);
            this.numpadBtn.Name = "numpadBtn";
            this.numpadBtn.Size = new System.Drawing.Size(75, 72);
            this.numpadBtn.TabIndex = 5;
            this.numpadBtn.Text = "Open  Numpad";
            this.numpadBtn.UseVisualStyleBackColor = true;
            this.numpadBtn.Click += new System.EventHandler(this.numpadBtn_Click);
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.CheckOnClick = true;
            this.DifficultyBox.FormattingEnabled = true;
            this.DifficultyBox.Items.AddRange(new object[] {
            "Easy",
            "Middle",
            "Hard",
            "Impossible"});
            this.DifficultyBox.Location = new System.Drawing.Point(519, 76);
            this.DifficultyBox.MultiColumn = true;
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(120, 89);
            this.DifficultyBox.TabIndex = 6;
            this.DifficultyBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DifficultyBox_ItemCheck);
            // 
            // gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 630);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.numpadBtn);
            this.Controls.Add(this.GuessLab);
            this.Controls.Add(this.LastNumLabel);
            this.Controls.Add(this.lastNumbers);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.compBt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Button numpadBtn;
        private System.Windows.Forms.CheckedListBox DifficultyBox;
    }
}

