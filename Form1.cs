namespace VisorDeImagenes
{
    public partial class VisorImagenes : Form
    {

        public VisorImagenes()
        {
            InitializeComponent();
            ActualizarMenus();
        }

        // formulario ayuda
        private void ayuda_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        // opciones del menu = ventana
        private void ventana_cascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ventana_mosaicoHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ventana_mosaicoVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        // funcion cerrar
        private void archivo_cerrar_Click(object sender, EventArgs e)
        {
            if (this.HijaActiva == null)
            {
                MessageBox.Show("No hay ninguna ventana activa", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.HijaActiva.Close();
        }

        private void archivo_nuevo_Click(object sender, EventArgs e)
        {
            string título = "Doc" + (this.MdiChildren.Length + 1);
            NuevaHija(título);
        }

        private void NuevaHija(string título)
        {
            VentanaHija hija = new VentanaHija(título, this);
            hija.MdiParent = this;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();

            this.HijaActiva.PictureBox.Image = Resource1.Image1;
        }

        private void archivo_cargar_Click(object sender, EventArgs e)
        {
            this.HijaActiva.PictureBox.Image = Resource1.Image1;
        }


        // propiedad para obtener a la ventana hija
        public VentanaHija HijaActiva
        {
            get { return (VentanaHija)this.ActiveMdiChild; }
        }

        // Funcion para abrir un archivo
        private void archivo_abrir_Click(object sender, EventArgs e)
        {
            // Mostrar diálogo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar archivo de imagen";

            // Si el resultado del diálogo es distinto de OK, terminar
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string rutaArchivo = openFileDialog.FileName;

            AbrirArchivo(rutaArchivo);

        }


        // Funcion refactorizada de abrir
        private void AbrirArchivo(string rutaArchivo)
        {
            // Leer el contenido del archivo
            byte[] contenidoArchivo = File.ReadAllBytes(rutaArchivo);

            // Creamos un flujo de tipo MemoryStream pasándole el contenido
            // del archivo
            using (MemoryStream memoryStream = new MemoryStream(contenidoArchivo))
            {
                // Usamos el método FromStream de la clase Image para crear una
                // imagen a partir del flujo
                Image imagen = Image.FromStream(memoryStream);

                // Creamos una nueva ventana hija con el método @,
                // pasándole como título el nombre del archivo abierto.
                VentanaHija nuevaVentana = new VentanaHija(Path.GetFileName(rutaArchivo), this);

                // Obtenemos una referencia a la nueva ventana mediante la
                // propiedad HijaActiva
                this.HijaActiva.PictureBox.Image = imagen;

                //// Le asignamos "imagen" al picture box de la nueva ventana 
                //nuevaVentana.PictureBox.Image = imagen;

                //// Mostramos la nueva ventana
                //nuevaVentana.Show();
            }
        }


        private void VisorImagenes_MdiChildActivate(object sender, EventArgs e)
        {
            ActualizarMenus();

            // ... 
            ToolStripManager.RevertMerge(this.barraDeHerramientas);
            VentanaHija ventanaHijaActiva =
            this.ActiveMdiChild as VentanaHija;
            if (ventanaHijaActiva != null)
                ToolStripManager.Merge(ventanaHijaActiva.barraDeHerramientas,
                this.barraDeHerramientas);
        }

        private void ActualizarMenus()
        {
            archivo_abrir.Enabled = this.HijaActiva != null;
            archivo_cerrar.Enabled = this.HijaActiva != null;
            archivo_cargar.Enabled = this.HijaActiva != null;
            ventana_cascada.Enabled = this.HijaActiva != null;
            ventana_mosaicoHorizontal.Enabled = this.HijaActiva != null;
            ventana_mosaicoVertical.Enabled = this.HijaActiva != null;
        }


        // Funciones de arrastrar y soltar
        private void VisorImagenes_DragEnter(object sender, DragEventArgs e)
        {
            // Nos aseguramos de que lo que se está arrastrando son archivos 
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!file.ToUpper().EndsWith(".JPG") &&
                     !file.ToUpper().EndsWith(".BMP") &&
                     !file.ToUpper().EndsWith(".GIF") &&
                     !file.ToUpper().EndsWith(".PNG") &&
                     !file.ToUpper().EndsWith(".JPEG"))
                {
                    e.Effect = DragDropEffects.None; // Uno de los archivos no 
                                                     // es una imagen 
                    return;
                }
            }
            e.Effect = DragDropEffects.Copy; // Correcto, son todo imágenes 
        }

        private void VisorImagenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                AbrirArchivo(file);
        }


        //opciones de el mouse e informacion en el statuslabel
        private void archivo_nuevo_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Genera una nueva ventana con una imagen predefinida";
        }

        private void archivo_nuevo_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void archivo_cargar_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Carga la imagen predefinida en la ventana actual en caso de haberla cambiado";
        }

        private void archivo_cargar_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void archivo_abrir_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Abre una nueva imagen para insertar en la ventana";
        }

        private void archivo_abrir_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void archivo_cerrar_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Cierra la ventana actual";
        }

        private void archivo_cerrar_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void archivo_salir_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Cerrar el programa!";
        }

        private void archivo_salir_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void ventana_cascada_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Establecer la disposicion de ventana en formato cascada";
        }

        private void ventana_cascada_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void ventana_mosaicoHorizontal_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Establecer la disposicion de ventana en formato Mosaico horizontal";
        }

        private void ventana_mosaicoHorizontal_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }

        private void ventana_mosaicoVertical_MouseEnter(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Establecer la disposicion de ventana en formato Mosaico vertical";
        }

        private void ventana_mosaicoVertical_MouseLeave(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "";
        }


        private bool estaChequeado = false;
        private void ver_ocultarBarraDeEstado_Click(object sender, EventArgs e)
        {
            // Alternar entre chequeado y no chequeado
            estaChequeado = !estaChequeado;
            this.statusStrip1.Visible = estaChequeado;
            ver_ocultarBarraDeEstado.Checked = this.statusStrip1.Visible == false;
        }

        private void archivo_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}