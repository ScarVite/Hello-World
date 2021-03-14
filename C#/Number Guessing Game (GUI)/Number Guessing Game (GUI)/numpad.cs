using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGG_GUI
{
    public partial class numpad : Form
    {
        private gui Gui;
        public numpad(gui gui)
        {
            InitializeComponent();
            this.Gui = gui;
        }

        private void NumpadClick(object sender, EventArgs e)
        {
            Button numpadBtn = sender as Button;
            String guess = "";
            switch(numpadBtn.Text)
            {
                case "1":
                    guess = "1";
                    break;
                case "2":
                    guess = "2";
                    break;
                case "3":
                    guess = "2";
                    break;
                case "4":
                    guess = "4";
                    break;
                case "5":
                    guess = "5";
                    break;
                case "6":
                    guess = "6";
                    break;
                case "7":
                    guess = "7";
                    break;
                case "8":
                    guess = "8";
                    break;
                case "9":
                    guess = "9";
                    break;
                case "0":
                    guess = "0";
                    break;
                case "DEL":
                    Gui.delChar();
                    break;
                case "Ka":
                    break;
                default:
                    break;
            }
            Gui.addGuess(guess);
        }
    }
}
