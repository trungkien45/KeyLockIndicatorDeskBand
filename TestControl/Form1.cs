﻿using CustomDialog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestControl
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

        private void customColorDialog1_ColorChanged(object sender, ColorChangedEventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomColorDialog customColorDialog1 = new CustomColorDialog();
            Color oldColor = customColorDialog1.Color = BackColor;
            customColorDialog1.ColorChanged += (o, ev) =>
            {
                BackColor = ev.CurrentColor;
            };
            if (customColorDialog1.ShowDialog() != DialogResult.OK)
            {
                BackColor = oldColor;
            };
        }
    }
}
