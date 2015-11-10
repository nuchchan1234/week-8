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
    public partial class ScoreView : Form,View
    {
        
        public ScoreView()
        {
            InitializeComponent();
        }

        public void Notify(Model m)
        {
            Updatescore(((TwoZeroFourEightModel)m).GetTotal());
        }

        private void Updatescore(int sum)
        {
            lblScore.Text = Convert.ToString(sum);
            
        }
        private void Score_Load(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}
