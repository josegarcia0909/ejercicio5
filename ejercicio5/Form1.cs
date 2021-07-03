using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejecutarbutton_Click(object sender, EventArgs e)
        {
            int n; n = Convert.ToInt32(NtextBox.Text);
            int m; m = Convert.ToInt32(MtextBox.Text);
            Random aleatorio = new Random();

            int[,] matriz = new int[n,m];

            for (int filas = 0; filas < matriz.GetLength(0); filas ++)
            {
                for (int col=0; col < matriz.GetLength(1); col ++)
                {
                    matriz[filas, col] = (aleatorio.Next(1,99 ));
                    listBox1.Items.Add(filas + " , " + col + " = "  + matriz[filas,col] );
                }


            }



        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiarbutton_Click(object sender, EventArgs e)
        {
            NtextBox.Clear();
            MtextBox.Clear();
            listBox1.Items.Clear();
        }
    }
}
