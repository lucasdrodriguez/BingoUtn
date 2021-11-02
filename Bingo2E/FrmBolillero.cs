using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo2E
{

    public partial class FrmBolillero : Form
    {
        static Random rnd;
        List<int> numerosDisponibles;
        List<int> numerosCantados;
        VerificarNumero delegadoSalioNumero;
        EnviarTxt delegadotexto;

        public FrmBolillero()
        {
            InitializeComponent();
            rnd = new Random();
            numerosDisponibles = new List<int>();
            numerosCantados = new List<int>();
            SetearEstadoInicial();
        }

        private void SetearEstadoInicial()
        {
            numerosCantados.Clear();

            for (int i = 0; i < 100; i++)
            {
                numerosDisponibles.Add(i);
            }
        }                

        private int ObtenerNumero()
        {                                            //99
            int numeroQueSalio = rnd.Next(0, numerosDisponibles.Count);

            numeroQueSalio = numerosDisponibles[numeroQueSalio];
            
            numerosDisponibles.Remove(numeroQueSalio);

            numerosCantados.Add(numeroQueSalio);

            return numeroQueSalio;
        }

        private void btn_numero_Click(object sender, EventArgs e)
        {
            int numero = ObtenerNumero();
            delegadoSalioNumero.Invoke(numero);
            delegadotexto.Invoke(numero.ToString());
        }

        public void CantarBingo(string nombre)
        {
            MessageBox.Show("Ganador!!! : " + nombre);

            this.btn_numero.Enabled = false;

        }


        private void FrmBolillero_Load(object sender, EventArgs e)
        {

            FrmCarton c1 = new FrmCarton("pepe",  this.CantarBingo);
            FrmCarton c2 = new FrmCarton("Juana", this.CantarBingo);
            FrmCarton c3 = new FrmCarton("Caro",  this.CantarBingo);


            c1.Show();
            c2.Show();
            c3.Show();

            delegadotexto = new EnviarTxt(c1.ActualizarUltimoNumero);
            delegadotexto += c2.ActualizarUltimoNumero;
            delegadotexto += c3.ActualizarUltimoNumero;

            delegadoSalioNumero = c1.TacharNumero;
            delegadoSalioNumero += c2.TacharNumero;
            delegadoSalioNumero += c3.TacharNumero;

        }
    }
}
