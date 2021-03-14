using System;
using System.Windows.Forms;
using System.Drawing;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace NGG_GUI
{
    public partial class gui : Form
    {
        numpad Numpad = null;   

        public gui()
        {  
            InitializeComponent();
            this.DifficultyBox.SetItemChecked(1, true);
        }

        public void compare(object sender, EventArgs e)
        {
            if (this.DifficultyBox.CheckedItems.Count > 1) MessageBox.Show("Please Select Only One Difficulty", "Many Exception");
            if (this.DifficultyBox.CheckedItems.Count == 0) MessageBox.Show("No Difficulty Selected, Game cannot be Started", "No Exception");
            else
            {
                string input = this.guess.Text;
                bool isNumber = int.TryParse(input, out int inp);
                if (isNumber)
                {
                    String CheckedItem = this.DifficultyBox.CheckedItems[0] as String;
                    int rand = new Random().Next(0, CheckedItem == "Easy" ? 11 : CheckedItem == "Middle" ? 101 : CheckedItem == "Hard" ? 1001 : 100000);
                    int max = CheckedItem == "Easy" ? 10 : CheckedItem == "Middle" ? 100 : CheckedItem == "Hard" ? 1000 : 99999;
                    if (inp > max) MessageBox.Show("Your Number is too high", "Too Large Exception");
                    else if (inp < 0) MessageBox.Show("Your Number is too low", "Too Small Exception");
                    else if (inp == rand) AppendLine(this.lastNumbers, "You've Enterred the Correct Number, Congratulations");
                    else AppendLine(this.lastNumbers, "You've guessed wrong, the Number was: " + Convert.ToString(rand));
                }
                else MessageBox.Show("You Did Not Enter a Number", "Please Enter a Number");
            }
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (!int.TryParse(this.guess.Text, out _)) this.guess.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.guess.Text) && this.DifficultyBox.SelectedIndex >= 0)
            {
                switch (this.DifficultyBox.Items[this.DifficultyBox.SelectedIndex].ToString())
                {
                    case "Easy":
                        this.guess.Text = "Please Enter a Number between 1-10";
                        break;
                    case "Middle":
                        this.guess.Text = "Please Enter a Number between 1-100";
                        break;
                    case "Hard":
                        this.guess.Text = "Please Enter a Number between 1-1000";
                        break;
                    case "Impossible":
                        this.guess.Text = "Please Enter a Number between 1 and a Random Number";
                        break;
                    default:
                        break;
                }
            }
        }

        public static void AppendLine(TextBox source, string value)
        {
            if (source.Text.Length == 0) source.Text = value;
            else source.AppendText("\r\n" + value);
        }

        private void guess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) compare(null, null);
        }

        private void numpadBtn_Click(object sender, EventArgs e)
        {
            if (Numpad == null)
            {
                Numpad = new numpad(this);
                Numpad.Show();
                this.numpadBtn.Text = "Close Numpad";
                Numpad.Location = new Point(this.Left + this.Width, this.Top);
            }
            else
            {
                Numpad.Dispose();
                this.numpadBtn.Text = "Open Numpad";
                Numpad = null;
            }
        }

        private void DifficultyBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < this.DifficultyBox.Items.Count; i++)
            {
                if (i != e.Index) this.DifficultyBox.SetItemChecked(i, false);
            }
            String text = "";
            switch (this.DifficultyBox.Items[e.Index].ToString())
            {
                case "Easy":
                    text = "Please Enter a Number between 1-10";
                    break;
                case "Middle":
                    text = "Please Enter a Number between 1-100";
                    break;
                case "Hard":
                    text = "Please Enter a Number between 1-1000";
                    break;
                case "Impossible":
                    text = "Please Enter a Number between 1 and a Random Number";
                    break;
                default:
                    break;
            }
            this.guess.Text = text;
        }

        public void addGuess(String guess)
        {
            this.RemoveText(null, null);
            this.guess.Text += guess;
        }

        public void delChar()
        {
            if (this.guess.Text.Length > 0) this.guess.Text = this.guess.Text.Remove(this.guess.Text.Length - 1);
            else this.AddText(null, null);
        }
    }
}
