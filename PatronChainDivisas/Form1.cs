using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using BE;

namespace PatronChainDivisas
{
    public partial class Form1 : Form
    {
        Ahorro ahorro = new Ahorro();
        Turismo turismo = new Turismo();
        PagoServicios pagoServicios = new PagoServicios();
        CompraProductos compraP = new CompraProductos();
        Usuario usuario = new Usuario();

        int totalMeses = 0;
        
        public Form1()
        {
            InitializeComponent();
            ahorro.AgregarSiguiente(turismo);
            turismo.AgregarSiguiente(pagoServicios);
            pagoServicios.AgregarSiguiente(compraP);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public int ObtenerEdad()
        {
            int Age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            return Age;
        }

        public int ObtenerMeses()
        {
            totalMeses = Math.Abs((dateTimePicker2.Value.Month - DateTime.Now.Month) + 12 * (dateTimePicker2.Value.Year - DateTime.Now.Year));
            return totalMeses;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            usuario.edad = ObtenerEdad();
            usuario.meses = ObtenerMeses();
            usuario.nombre = textBox1.Text;
            usuario.motivo = comboBox1.SelectedItem.ToString();
            usuario.monto = Convert.ToDouble(textBox2.Text);

            //rta
            textBox3.Text = ahorro.Procesar(usuario);                 
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();            
        }
    }
}
