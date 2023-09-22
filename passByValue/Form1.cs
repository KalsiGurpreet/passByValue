using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passByValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            int value= 99;
            MessageBox.Show("The value inside goButton_Click method is " + value);

            MyNumber(value); // calling a method with an argument "value" i.e 99 which gets changed after
            // method call.

            MessageBox.Show("The value inside goButton_Click method is " + value);
        }
        private void MyNumber(int sum)
        {
            sum = 0;

            MessageBox.Show("The value inside MyNumber method is " + sum);
        }
    }
}
