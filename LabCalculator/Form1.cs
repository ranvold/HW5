﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            LabelResult.Text = Calculator.Evaluate(TextInput.Text).ToString();
        }
    }
}
