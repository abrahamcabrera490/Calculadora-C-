using System;
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
    public partial class Form1 : Form
    {
        string op;
        int acumulatedValue;
        public Form1()
        {
            InitializeComponent();
        }


        private void NumberAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int btnvalue = int.Parse(button.Text);
            int currentvalue = int.Parse(txtVal.Text);
            currentvalue = currentvalue * 10 + btnvalue;
            txtVal.Text = currentvalue.ToString();
        }

        private void Operation_ActionCLick(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
             op = btnOperator.Text;
             acumulatedValue = int.Parse(txtVal.Text);
            txtVal.Text = "0";
             


        }



            private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtVal.Text = "0";
            acumulatedValue = 0;
            op = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
          int acumulatedValue2 = int.Parse(txtVal.Text);
            int resultado = 0;
            if(op == "*")
            {
                 resultado = acumulatedValue * acumulatedValue2;
            }
            if (op == "+")
            {
                resultado = acumulatedValue + acumulatedValue2;
            }
            if (op == "-")
            {
                resultado = acumulatedValue - acumulatedValue2;
            }
            if (op == "/")
            {
                resultado = acumulatedValue / acumulatedValue2;
            }
            txtVal.Text = resultado.ToString();
        }
    }
}
