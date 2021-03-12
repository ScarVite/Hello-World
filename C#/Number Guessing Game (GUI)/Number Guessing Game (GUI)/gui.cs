using System;
using System.Windows.Forms;
using Number_Guessing_Game__GUI_;

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
        }

        private void compare(object sender, EventArgs e)
        {
            if (this.DifficultyBox.CheckedItems.Count > 1) MessageBox.Show("Please Select Only One Difficulty", "Too Many Error");
            else
            {
                string input = this.guess.Text;
                bool isNumber = int.TryParse(input, out int inp);
                MessageBox.Show(this.DifficultyBox.CheckedItems[0].ToString());
                if (isNumber)
                {
                    int rand = -1;
                    switch (this.DifficultyBox.CheckedItems[0])
                    {
                        case "Easy":
                            rand = new Random().Next(0, 10);
                            break;
                        case "Middle":
                            rand = new Random().Next(0, 100);
                            break;
                        case "Hard":
                            rand = new Random().Next(0, 1000);
                            break;
                        case "Impossible":
                            rand = new Random().Next(0, new Random().Next(0, 99999));
                            break;
                        default:
                            break;
                    }
                    if (inp > 100) MessageBox.Show("Your Number was too high, please Select One between 0 and 100", "Number Too Large");
                    else if (inp < 0) MessageBox.Show("Your Number was too low, please Select One between 0 and 100", "Number Too Small");
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
            if (string.IsNullOrWhiteSpace(this.guess.Text))
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
            if(e.KeyCode == Keys.Enter) compare(null, null);
        }

        private void numpadBtn_Click(object sender, EventArgs e)
        {
            if (Numpad == null)
            {
                Numpad = new numpad();
                Numpad.Show();
            }
            else
            {
                Numpad.Dispose();
                Numpad = null;
            }
        }

        private void DifficultyBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show(e.NewValue.ToString());
            for (int i = 0; i < this.DifficultyBox.Items.Count; i++)
            {
                if (i != e.Index) this.DifficultyBox.SetItemChecked(i, false);
            }
            //if (e.NewValue.ToString() == "Unchecked" && this.DifficultyBox.GetItemChecked(e.Index)) this.DifficultyBox.SetItemChecked(0, true);
            String text = "Something went wrong";
            switch(this.DifficultyBox.Items[e.Index].ToString())
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
    }
}
