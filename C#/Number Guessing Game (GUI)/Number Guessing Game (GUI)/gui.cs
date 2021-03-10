using System;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace NGG_GUI
{
    public partial class gui : Form
    {
        public gui()
        {
            InitializeComponent();
        }

        private void compare(object sender, EventArgs e)
        {
            string input = this.guess.Text;
            bool isNumber = int.TryParse(input, out int inp);
            if(isNumber)
            {
                int rand = new Random().Next(0, 100);
                if(inp > 100) MessageBox.Show("Your Number was too high, please Select One between 0 and 100" , "Number Too Large");
                else if(inp < 0) MessageBox.Show("Your Number was too low, please Select One between 0 and 100", "Number Too Small");
                else if(inp == rand) AppendLine(this.lastNumbers, "You've Enterred the Correct Number, Congratulations");
                else AppendLine(this.lastNumbers, "You've guessed wrong, the Number was: " + Convert.ToString(rand));
            } else MessageBox.Show("You Did Not Enter a Number", "Please Enter a Number");
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (this.guess.Text == "Please A Number Between 1-100") this.guess.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.guess.Text)) this.guess.Text = "Please A Number Between 1-100";
        }

        public static void AppendLine(TextBox source, string value)
        {
            if (source.Text.Length == 0) source.Text = value;
            else source.AppendText("\r\n" + value);
        }

        private void guess_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) compare(null, null);
        }
    }
}
