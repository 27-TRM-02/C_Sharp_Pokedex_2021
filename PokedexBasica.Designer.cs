namespace PruebaBBDD
{
    partial class PokedexBasica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.especie = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.caracteristicas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(156, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(596, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.SystemColors.Control;
            this.nombrePokemon.Location = new System.Drawing.Point(464, 133);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(235, 98);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PruebaBBDD.Properties.Resources.pokedexGood;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(806, 558);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.especie.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especie.Location = new System.Drawing.Point(153, 389);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(213, 67);
            this.especie.TabIndex = 5;
            this.especie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peso
            // 
            this.peso.BackColor = System.Drawing.SystemColors.ControlDark;
            this.peso.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.Location = new System.Drawing.Point(153, 456);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(108, 63);
            this.peso.TabIndex = 6;
            this.peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // altura
            // 
            this.altura.BackColor = System.Drawing.SystemColors.ControlDark;
            this.altura.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(258, 456);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(108, 63);
            this.altura.TabIndex = 7;
            this.altura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caracteristicas
            // 
            this.caracteristicas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.caracteristicas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caracteristicas.Location = new System.Drawing.Point(468, 245);
            this.caracteristicas.Name = "caracteristicas";
            this.caracteristicas.Size = new System.Drawing.Size(228, 92);
            this.caracteristicas.TabIndex = 8;
            this.caracteristicas.Text = "CARACTERÍSTICAS";
            this.caracteristicas.UseVisualStyleBackColor = false;
            this.caracteristicas.Click += new System.EventHandler(this.caracteristicas_Click);
            // 
            // PokedexBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 553);
            this.Controls.Add(this.caracteristicas);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "PokedexBasica";
            this.Text = "PokedexBasica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Button caracteristicas;
    }
}