using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBBDD
{
    public partial class Info : Form
    {
        public Info(int id)
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            DataTable pokemonElegido = conexion.getPokemonPorId(id);
            pokemon1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            pokemonActual.Text = pokemonElegido.Rows[0]["nombre"].ToString();
            label7.Text = pokemonElegido.Rows[0]["altura"].ToString();
            label8.Text = pokemonElegido.Rows[0]["peso"].ToString();
            label11.Text = pokemonElegido.Rows[0]["especie"].ToString();
            label10.Text = pokemonElegido.Rows[0]["habitat"].ToString();
            label9.Text = pokemonElegido.Rows[0]["tipo1"].ToString();
            label12.Text = pokemonElegido.Rows[0]["tipo2"].ToString();
            label14.Text = pokemonElegido.Rows[0]["descripcion"].ToString();
            label15.Text = pokemonElegido.Rows[0]["habilidad"].ToString();
            label16.Text = pokemonElegido.Rows[0]["movimiento1"].ToString();
            label17.Text = pokemonElegido.Rows[0]["movimiento2"].ToString();
            label18.Text = pokemonElegido.Rows[0]["movimiento3"].ToString();
            label19.Text = pokemonElegido.Rows[0]["movimiento4"].ToString();
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }

        // Pulse sin querer, No lo uso
        private void Info_Load(object sender, EventArgs e)
        {
        }
        // Pulse sin querer, No lo uso
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
