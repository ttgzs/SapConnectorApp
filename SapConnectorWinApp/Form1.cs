﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SapConnector;

namespace SapConnectorWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtAux.Text = string.Empty;
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            SapConnection oSapConnection = new SapConnection();
            txtAux.Text = oSapConnection.test();



        }
    }
}
