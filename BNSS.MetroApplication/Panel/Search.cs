using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace BNSS.MetroApplication.Panel
{
    public partial class Search : PanelSlider
    {
        public Search(Form Owner, int width, int height) :base(Owner)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }
    }
}
