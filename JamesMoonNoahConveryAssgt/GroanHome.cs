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
    public partial class frmGroan : Form
    {
        public frmGroan()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmGroanGame GroanGame = new frmGroanGame();
            GroanGame.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbOnePlayer_CheckedChanged(object sender, EventArgs e)
        {
            lblPlayerTwo.Visible = false;
            
        }

        private void tbScoreLimit_Scroll(object sender, EventArgs e)
        {
            lblScoreLimit.Text = "Score Limit: First to " + tbScoreLimit.Value + " wins!";
        }
    }
}
