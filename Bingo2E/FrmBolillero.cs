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
        List<int> numeros;
        List<int> numerosSalidos;

        public FrmBolillero()
        {
            InitializeComponent();
            rnd = new Random();
            numeros = new List<int>();
            numerosSalidos = new List<int>();
            SetearEstadoInicial();
        }

        private void SetearEstadoInicial()
        {
            numerosSalidos.Clear();
            for (int i = 0; i < 100; i++)
            {
                numeros.Add(i);
            }
        }

        private int ObtenerNumero()
        {
            int numeroQueSalio = rnd.Next(0, numeros.Count);

            numeroQueSalio = numeros[numeroQueSalio];
            
            numeros.Remove(numeroQueSalio);
            numerosSalidos.Add(numeroQueSalio);

            return numeroQueSalio;
        }

        private void btn_numero_Click(object sender, EventArgs e)
        {
            int numero = ObtenerNumero();
            lb_salioNumero.Text = $"Salio el numero: {numero}";
        }

        public void Ganador(string nombre)
        {
            MessageBox.Show("Ganador!!! : " + nombre);

            this.btn_numero.Enabled = false;

        }


        private void FrmBolillero_Load(object sender, EventArgs e)
        {

            FrmCarton c1 = new FrmCarton("pepe");
            FrmCarton c2 = new FrmCarton("Juana");
            FrmCarton c3 = new FrmCarton("Caro");


            c1.Show();
            c2.Show();
            c3.Show();

        }
    }
}
