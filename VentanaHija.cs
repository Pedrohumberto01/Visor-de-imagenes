using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisorDeImagenes
{
    public partial class VentanaHija : Form
    {
        private VisorImagenes formularioPadre;
        public VentanaHija(string título, VisorImagenes padre)
        {
            InitializeComponent();
            this.Text = título;
            formularioPadre = padre;
        }

        public PictureBox PictureBox
        {
            get { return m_PictureBox; }
        }

        // En la clase VentanaHija
        //public barraDeHerramientas { get; set; }


        private void imagen_ajustarVentana_Click(object sender, EventArgs e)
        {
            // Si no estamos en modo ajustar, activamos este modo 
            if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.AutoSize)
            {
                this.AutoScroll = false;
                this.PictureBox.Size = this.ClientSize;
                this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            // Si estamos en modo ajustar, desactivamos este modo 
            else if (this.PictureBox.SizeMode ==
            PictureBoxSizeMode.Zoom)
            {
                this.AutoScroll = true;
                this.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            imagen_ajustarVentana.Checked =
                this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom;
            ajustar_ventana.Checked =
                this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom;
        }

        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
                this.PictureBox.Size = this.ClientSize;
        }




        // Funcion para rotar la imagen 90 grados
        private void imagen_rotar90_Click(object sender, EventArgs e)
        {
            // Rotar la imagen antes de cambiar el tamaño del PictureBox
            RotateImage();

            // Cambiar el tamaño del PictureBox para evitar pérdida de imagen
            AdjustPictureBoxSize();

            // Actualizar y repintar el PictureBox
            m_PictureBox.Refresh();
        }

        private void RotateImage()
        {
            // Obtener la imagen actual del PictureBox
            Image currentImage = m_PictureBox.Image;

            if (currentImage != null)
            {
                // Rotar la imagen 90 grados en sentido horario
                currentImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }

        private void AdjustPictureBoxSize()
        {
            // Ajustar el tamaño del PictureBox para evitar pérdida de imagen
            int newWidth = m_PictureBox.Height;
            int newHeight = m_PictureBox.Width;

            m_PictureBox.Size = new Size(newWidth, newHeight);
        }




        // Funcion añadir texto
        private void imagen_añadirTexto_Click(object sender, EventArgs e)
        {
            // Asegurarse de que hay una imagen en el m_PictureBox
            if (this.m_PictureBox.Image == null)
            {
                MessageBox.Show("Carga una imagen antes de añadir texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una copia de la imagen original para evitar modificar la original
            using (Image originalImage = this.m_PictureBox.Image.Clone() as Image)
            {
                // Liberar recursos asociados con la imagen original
                this.m_PictureBox.Image.Dispose();

                using (Graphics gfx = Graphics.FromImage(originalImage))
                {
                    // Definir el texto, la fuente y la brocha
                    string texto = "Programación Visual";
                    Font fuente = new Font("Arial", 20);
                    Brush brocha = Brushes.White;

                    // Utilizar el método DrawString de gfx para pintar el texto
                    gfx.DrawString(texto, fuente, brocha, new PointF(0, 0));
                }

                // Actualizar la imagen en el m_PictureBox
                this.m_PictureBox.Image = (Image)originalImage.Clone();
            }

            // Refrescar el m_PictureBox
            this.m_PictureBox.Refresh();
        }




        //Funcion Escala de grises

        private void imagen_escalaDeGrises_Click(object sender, EventArgs e)
        {
            // Asegurarse de que hay una imagen en el PictureBox
            if (this.m_PictureBox.Image == null)
            {
                MessageBox.Show("Carga una imagen antes de aplicar escala de grises.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la imagen del PictureBox
            Image imagen = this.m_PictureBox.Image;

            // Crear una copia de la imagen original para evitar modificar la original
            using (Image imagenOriginal = imagen.Clone() as Image)
            {
                using (Graphics gfx = Graphics.FromImage(imagen))
                {
                    // Matriz para realizar una transformación al gris manteniendo los valores de luminancia correctos
                    ColorMatrix cm = new ColorMatrix(new float[][]{
                        new float[]{0.3f, 0.3f, 0.3f, 0, 0},
                        new float[]{0.59f, 0.59f, 0.59f, 0, 0},
                        new float[]{0.11f, 0.11f, 0.11f, 0, 0},
                        new float[]{0, 0, 0, 1, 0},
                        new float[]{0, 0, 0, 0, 1}
                    });

                    ImageAttributes ia = new ImageAttributes();
                    ia.SetColorMatrix(cm);

                    // Utilizar el método DrawImage de gfx para redibujar la imagen usando los atributos de imagen especificados por ia
                    gfx.DrawImage(imagenOriginal, new Rectangle(0, 0, imagen.Width, imagen.Height), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, ia);
                }
            }

            // Refrescar el PictureBox
            this.m_PictureBox.Refresh();
        }


        //Funcion guardar como
        private void archivo_guardarComo_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }


        // Funcion guardar
        private void archivo_guardar_Click(object sender, EventArgs e)
        {
            // Obtener el título de la ventana activa
            string tituloVentana = this.Text;

            // Verificar si el título de la ventana activa comienza con "Doc"
            if (tituloVentana.StartsWith("Doc"))
            {
                // Si el título comienza con "Doc", entonces la imagen no ha sido guardada previamente
                GuardarComo();
            }
            else
            {
                // Si el título no comienza con "Doc", entonces la imagen ya ha sido guardada previamente
                // Guardar la imagen en la misma ruta del archivo original
                try
                {
                    // Guardar la imagen en la misma ruta del archivo original
                    m_PictureBox.Image.Save(tituloVentana, ImageFormat.Jpeg); // Puedes ajustar el formato según tu necesidad
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //medoto de la refactorizacion
        private void GuardarComo()
        {
            // Mostrar el diálogo SaveFileDialog y configurarlo de forma análoga al OpenFileDialog de la opción "Abrir"
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de imagen|*.bmp;*.jpg;*.gif|Todos los archivos|*.*";
            saveFileDialog.Title = "Guardar archivo de imagen como";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                // El usuario canceló la operación
                return;
            }

            try
            {
                // Obtener el nombre del archivo seleccionado para guardar
                string rutaGuardado = saveFileDialog.FileName;

                // Actualizar el título de la ventana principal con el nuevo nombre de archivo
                this.Text = Path.GetFileName(rutaGuardado);

                // Guardar la imagen en el formato correspondiente
                ImageFormat formato = ImageFormat.Jpeg; // Por defecto, guardaremos como JPEG

                if (rutaGuardado.ToUpper().EndsWith(".BMP"))
                {
                    formato = ImageFormat.Bmp;
                }
                else if (rutaGuardado.ToUpper().EndsWith(".GIF"))
                {
                    formato = ImageFormat.Gif;
                }

                // Guardar la imagen en el formato correspondiente
                m_PictureBox.Image.Save(rutaGuardado, formato);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imagen_ajustarVentana_MouseEnter(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "Ajustar la imagen al tamaño de la ventana";
        }

        private void imagen_ajustarVentana_MouseLeave(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "";
        }

        private void imagen_rotar90_MouseEnter(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "Girar la imagen 90 grados a la derecha";
        }

        private void imagen_rotar90_MouseLeave(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "";
        }

        private void imagen_añadirTexto_MouseEnter(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "Agregar texto a la imagen de la ventana actual";
        }

        private void imagen_añadirTexto_MouseLeave(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "";
        }

        private void imagen_escalaDeGrises_MouseEnter(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "Agregar un filtro de grises a la foto de la ventana actual";
        }

        private void archivo_guardar_MouseEnter(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "Guardar la imagen";
        }

        private void archivo_guardar_MouseLeave(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "";
        }

        private void archivo_guardarComo_MouseEnter(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "Guardar imagen con un nuevo nombre";
        }

        private void archivo_guardarComo_MouseLeave(object sender, EventArgs e)
        {
            formularioPadre.etiquetaEstado.Text = "";
        }
    }
}
