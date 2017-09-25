﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class myFirstForm : Form
    {
        public myFirstForm()
        {
            Thread splashThread = new Thread(new ThreadStart(splashstart));
            splashThread.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            

            splashThread.Abort();
        }
        public void splashstart()
        {
            Application.Run(new mySplashScreen());
        }

        public void launchMySecondForm()
        {
            Application.Run(new mySecondForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread secondFormThread = new Thread(new ThreadStart(launchMySecondForm));
            secondFormThread.Start();
            Application.Exit();


           
        }
    }
}
