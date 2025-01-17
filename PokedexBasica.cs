﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PruebaBBDD
{
    public partial class PokedexBasica : Form
    {
        Conexion miConexion = new Conexion();
        int idActual = 1;
        public PokedexBasica()
        {
            InitializeComponent();
            asignaPokemon();
         }
  
        private void button2_Click(object sender, EventArgs e)
        {//boton derecha
            idActual++;
            if (idActual > 151) {
                idActual = 1;
            }
            asignaPokemon();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual < 1)
            {
                idActual = 151;
            }
            asignaPokemon();
        }

        private void asignaPokemon() {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = pokemonElegido.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            especie.Text = pokemonElegido.Rows[0]["especie"].ToString();
            peso.Text = pokemonElegido.Rows[0]["peso"].ToString();
            altura.Text = pokemonElegido.Rows[0]["altura"].ToString();
        }
 


        private Image convierteBlobAImagen(byte[] img) {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }

        private void caracteristicas_Click(object sender, EventArgs e)
        {
            int id = idActual;
            Info ventana = new Info(id);
            ventana.Show();
        }
    }
}
