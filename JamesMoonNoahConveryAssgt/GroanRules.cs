/*
    Name: James Moon & Noah Convery
    Date: 12/5/21
    Description: A page that displays the rules for the game
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesMoonNoahConveryAssgt
{
    public partial class GroanRules : Form
    {
        public GroanRules()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)                    // hides GroanRules window
        {
            Hide();
        }
    }
}
