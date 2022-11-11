using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double coste = 0;
            string cadena = txtTelegrama.Text;
            string[] palabras = cadena.Split(' ');




            if (palabras.Length <= 10 && palabras.Length >=1)
            {
                coste = 2.5;
                txtPrecio.Text = coste.ToString() + " euros";
            }
            else 
            {
                coste = 2.5;

                for (int i = 10; i < palabras.Length; i++)
                {
                    
                    coste = coste+0.5;

                }

                    
                txtPrecio.Text = coste.ToString() + " euros";
            }
            if (cbUrgente.Checked == true)
            {
                if (palabras.Length <= 10 && palabras.Length >= 1)
                {
                    coste = 5;
                    txtPrecio.Text = coste.ToString() + " euros";
                }
                else
                {
                    coste = 5;

                    for (int i = 10; i < palabras.Length; i++)
                    {

                        coste = coste + 0.75;

                    }
                    txtPrecio.Text = coste.ToString() + " euros";
                    //
                }
            }

        }
    }
}
