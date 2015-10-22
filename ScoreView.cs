using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class ScoreView : Form
    {
        public ScoreView()
        {
            InitializeComponent();
        }

        public void showscore(string sc)
        {
            lblScore.Text = sc;
        }
        private void Score_Load(object sender, EventArgs e)
        {

        }
    }
}
