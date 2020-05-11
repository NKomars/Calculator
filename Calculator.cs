﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            InitializeCalculator();
        }

        private void InitializeCalculator()
        {
            this.BackColor = Color.Purple;
            Display.Font = new Font("Tahoma", 22f);


            string buttonName = null;
            Button button = null;
            for (int i = 0; i < 10; i++)
            {
                buttonName = "button" + i;
                button = (Button)this.Controls[buttonName];
                button.Text = i.ToString();
                button.BackColor = Color.Pink;
                button.Font = new Font("Roboto", 22f);
            }        
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Display.Text += button.Text;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            
            if (!Display.Text.Contains("."))
            {
                if (Display.Text==string.Empty)
                {
                    Display.Text += "0.";
                }
                else
                {
                    Display.Text +=".";
                }

                
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = Display.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = string.Empty;
            }
            Display.Text = s;
        }
    }
}
