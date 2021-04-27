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
        //frmGroan groanHome = new frmGroan();
        //frmGroanRules groanRules = new frmGroanRules();


        public frmGroanGame()
        {
            InitializeComponent();
            
            //lblPlayer1Name.Text = groanHome.sP1Name;
            //lblPlayer2Name.Text = groanHome.sP2Name;

        }
        
        private void btnRules_Click(object sender, EventArgs e)
        {
            GroanRules GroanRules = new GroanRules();

            GroanRules.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            frmGroanHome GroanHome = new frmGroanHome();

            this.Close();
            GroanHome.Show();
            
        }
    }
}
