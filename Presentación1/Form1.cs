using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTconteo_Click(object sender, EventArgs e)
        {
            LBLpuntos.Text = Devolucion();
            int Puntos = System.Convert.ToInt32(LBLpuntos.Text);
            string Guardar;
            if (Puntos >= 120 && Puntos <= 210)
            {
                Guardar = "Usted puede acceder a la beca";
            }
            else if (Puntos >= 60 && Puntos <= 119)
            {
                Guardar = "Usted queda en lista de espera";
            }
            else
            {
                Guardar = "Lo sentimos Usted esta afuera de la beca";
            }
            LBLpuntos.Text = Guardar;
        }
        private string Devolucion()
        {
            Decimal Num1 = System.Convert.ToInt32(TXTconteo.Text);
            Decimal Acumulador = 0;
            for (Decimal i = Num1; i <= 20; i++)
            {
                Acumulador = Acumulador + i;
            }
            LBLresult.Text = Acumulador.ToString();
            return LBLresult.Text;
        }
        
    }
}
