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
    public partial class frmGroanGame : Form
    {
        private Graphics graDiceOne;
        private Graphics graDiceTwo;
        private Graphics graDiceThree;
        private Graphics graDiceFour;
        private Graphics graDiceFive;
        private Graphics graDiceSix;
        private frmGroan groanHome;
        private frmGroanRules groanRules;

        public frmGroanGame()
        {
            InitializeComponent();
            lblPlayer1Name.Text = groanHome.sP1Name;
            lblPlayer2Name.Text = groanHome.sP2Name;

        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            groanRules.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
