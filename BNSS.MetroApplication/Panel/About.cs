﻿using System;
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
    public partial class About : PanelSlider
    {
        public About(MainMenu mainMenu, int width, int height):base(mainMenu)
        {
            InitializeComponent();
            Width = width;
            Height = height;
            
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
                this.swipe(false);
            
        }
    }
}
