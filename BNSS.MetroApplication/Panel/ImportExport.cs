using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BNSS.MetroApplication.Panel
{
    public partial class ImportExport : PanelSlider
    {
        public ImportExport(MainMenu mainMenu, int width, int height):base(mainMenu)
        {
            InitializeComponent();
            Width = width;
            Height = height;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.swipe(false);
        }
    }
}
