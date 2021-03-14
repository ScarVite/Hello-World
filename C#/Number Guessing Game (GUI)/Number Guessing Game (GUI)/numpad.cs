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
            if (numpadBtn.Text.Equals("DEL")) Gui.delChar();
            else if (numpadBtn.Text.Equals("Ka")) Gui.delChar(); // Dummy Call, will need to changed to something usefull
            else Gui.addGuess(numpadBtn.Text);
        }
    }
}
