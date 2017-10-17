using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGeneric1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PruebaGenerics1();
        }

        public void PruebaGenerics1()
        {
            IList enteros = new System.Collections.ArrayList();

            enteros.Add("hola");
            enteros.Add(1);
            enteros.Add(new StringBuilder());

            foreach (object o in enteros)
            {
               MessageBox.Show(o.ToString());
            }
        }


        public void PruebaGenerics1_2()
        {
            IList enteros = new System.Collections.ArrayList();

            enteros.Add("hola");
            enteros.Add(1);

            enteros.Add(new StringBuilder().Append("hola string builder"));

            foreach (object o in enteros)
            {
                MessageBox.Show(o.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PruebaGenerics1_2();
        }


        public void PruebaGenerics2()
        {
            IList<int> enteros = new List<int>();

            //enteros.Add("hola");
            enteros.Add(1);
            //enteros.Add(new StringBuilder());

            foreach (int o in enteros)
            {
                MessageBox.Show(o.ToString());
            }
        }



        public void PruebaGeneric3<T>(T objetoGerico)
        {
            IList listaGenerica = new List<T>();

            listaGenerica.Add(objetoGerico);

            foreach (T item in listaGenerica)
            {
                if (item is Int32)
                {
                    MessageBox.Show("soy un entero que vale {0}", item.ToString());
                }
                else
                {
                    MessageBox.Show("No soy entero {0}", item.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PruebaGenerics2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PruebaGeneric3<int>(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PruebaGenerics6<int> claseGenerica = new PruebaGenerics6<int>();
            claseGenerica.PruebaGeneric(1);
        }
    }



    public class PruebaGenerics6<T>
    {
        public void PruebaGeneric(T objetoGerico)
        {
            IList listaGenerica = new List<T>();

            listaGenerica.Add(objetoGerico);

            foreach (T item in listaGenerica)
            {
                if (item is Int32)
                {
                    MessageBox.Show("soy un entero que vale {0}", item.ToString());
                }
                else
                {
                    MessageBox.Show("No soy entero {0}", item.ToString());
                }
            }
        }
    }



    interface IFantasma
    {
        void MetodoFantasma();
    }

    //public class PruebaGenerics7<T> where T : IFantasma
    //{
    //    public void PruebaGeneric(T objetoGerico)
    //    {
    //        IList listaGenerica = new List<T>();

    //        listaGenerica.Add(objetoGerico);

    //        foreach (T item in listaGenerica)
    //        {
    //            item.MetodoFantasma();
    //        }
    //    }
    //}
}
 


