///================== Void Studios (ZanyLeonic) 2015 ==================
/// PURPOSE: The about UI of the program
/// Version: 0.1
/// Created by ZanyLeonic (Leo Durrant) 16/12/15
///====================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSUpdaterLib;

namespace POSUpdater.Forms
{
    partial class about : Form
    {
        functions func = new functions();
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void gameGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            func.OpenUri("http://github.com/VoidStudiosDev/ProjectOminous");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            func.OpenUri("http://github.com/VoidStudiosDev/ProjectOminous-Updater");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
