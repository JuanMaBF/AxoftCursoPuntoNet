using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPWindowsDelegados
{

    public delegate double Delegate_Prod(int a, int b);
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        static double suma(int val1, int val2)
        {
            return val1 + val2;
        }
        static double resta(int val1, int val2)
        {
            return val1 - val2;
        }
        static double multi(int val1, int val2)
        {
            return val1 * val2;
        }
        static double div(int val1, int val2)
        {
            return val1 / val2;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Delegate_Prod delObj = new Delegate_Prod(suma);
            Delegate_Prod delObj1 = new Delegate_Prod(resta);
            Delegate_Prod delObj2 = new Delegate_Prod(div);
            Delegate_Prod delObj3 = new Delegate_Prod(multi);

            Console.Write("Please Enter Values");

            int v1 = Int32.Parse(this.textBox1.Text);
            int v2 = Int32.Parse(this.textBox2.Text);

            //use a delegate for processing

            double res = delObj(v1, v2);

            MessageBox.Show("Result :" + res);

            double res1 = delObj1(v1, v2);

            MessageBox.Show("Result :" + res1);
            
            double res2 = delObj2(v1, v2);

            MessageBox.Show("Result :" + res2);

            double res3 = delObj3(v1, v2);

            MessageBox.Show("Result :" + res3);
        }


      
    }
}