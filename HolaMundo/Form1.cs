﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo !", "Mensaje de bienvenida",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Hola! " + txtnombre.Text, "Saludo a Usuario",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
