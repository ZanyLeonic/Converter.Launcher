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
using Converter.Launcher.Lib;
using System.Threading;

namespace Converter.Launcher.App.Forms
{
    partial class About : Form
    {
        //Functions func = new Functions();

        System.Drawing.Point NewPoint = new System.Drawing.Point();
        int X = 0;
        int Y = 0;

        System.Media.SoundPlayer player1 =
        new System.Media.SoundPlayer();

        Update up = new Update();

        public About()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            appName.Text = LauncherAssets.AppName;
            appVersion.Text = LauncherAssets.AppVersion;
            appName.Parent = this;
            appVersion.Parent = this;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void About_MouseDown(object sender, MouseEventArgs e)
        {
            X = Control.MousePosition.X - this.Location.X;
            Y = Control.MousePosition.Y - this.Location.Y;
        }

        private void About_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NewPoint = Control.MousePosition;
                NewPoint.X -= (X);
                NewPoint.Y -= (Y);
                this.Location = NewPoint;
            }
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            if (up.preferences.LauncherButtonSounds)
            {
                Thread thread = new Thread(player1.Play);
                player1.Stream = LauncherAssets.menu_back;
                thread.Start();
            }

            this.Dispose();
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            if (up.preferences.LauncherButtonSounds)
            {
                player1.Stream = LauncherAssets.menu_focus;
                player1.Play();
            }
        }
    }
}
