namespace VisorDeImagenes
{
    partial class VisorImagenes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorImagenes));
            menuStrip1 = new MenuStrip();
            archivo = new ToolStripMenuItem();
            archivo_nuevo = new ToolStripMenuItem();
            archivo_cargar = new ToolStripMenuItem();
            archivo_abrir = new ToolStripMenuItem();
            archivo_cerrar = new ToolStripMenuItem();
            archivo_salir = new ToolStripMenuItem();
            ver = new ToolStripMenuItem();
            ver_ocultarBarraDeEstado = new ToolStripMenuItem();
            ventana = new ToolStripMenuItem();
            ventana_cascada = new ToolStripMenuItem();
            ventana_mosaicoHorizontal = new ToolStripMenuItem();
            ventana_mosaicoVertical = new ToolStripMenuItem();
            ayuda = new ToolStripMenuItem();
            barraDeHerramientas = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            etiquetaEstado = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            barraDeHerramientas.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivo, ver, ventana, ayuda });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = ventana;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivo
            // 
            archivo.DropDownItems.AddRange(new ToolStripItem[] { archivo_nuevo, archivo_cargar, archivo_abrir, archivo_cerrar, archivo_salir });
            archivo.Name = "archivo";
            archivo.Size = new Size(60, 20);
            archivo.Text = "Archivo";
            // 
            // archivo_nuevo
            // 
            archivo_nuevo.Name = "archivo_nuevo";
            archivo_nuevo.Size = new Size(180, 22);
            archivo_nuevo.Text = "Nuevo";
            archivo_nuevo.Click += archivo_nuevo_Click;
            archivo_nuevo.MouseEnter += archivo_nuevo_MouseEnter;
            archivo_nuevo.MouseLeave += archivo_nuevo_MouseLeave;
            // 
            // archivo_cargar
            // 
            archivo_cargar.Name = "archivo_cargar";
            archivo_cargar.Size = new Size(180, 22);
            archivo_cargar.Text = "Cargar";
            archivo_cargar.Click += archivo_cargar_Click;
            archivo_cargar.MouseEnter += archivo_cargar_MouseEnter;
            archivo_cargar.MouseLeave += archivo_cargar_MouseLeave;
            // 
            // archivo_abrir
            // 
            archivo_abrir.Name = "archivo_abrir";
            archivo_abrir.Size = new Size(180, 22);
            archivo_abrir.Text = "Abrir";
            archivo_abrir.Click += archivo_abrir_Click;
            archivo_abrir.MouseEnter += archivo_abrir_MouseEnter;
            archivo_abrir.MouseLeave += archivo_abrir_MouseLeave;
            // 
            // archivo_cerrar
            // 
            archivo_cerrar.Name = "archivo_cerrar";
            archivo_cerrar.Size = new Size(180, 22);
            archivo_cerrar.Text = "Cerrar";
            archivo_cerrar.Click += archivo_cerrar_Click;
            archivo_cerrar.MouseEnter += archivo_cerrar_MouseEnter;
            archivo_cerrar.MouseLeave += archivo_cerrar_MouseLeave;
            // 
            // archivo_salir
            // 
            archivo_salir.Name = "archivo_salir";
            archivo_salir.Size = new Size(180, 22);
            archivo_salir.Text = "Salir";
            archivo_salir.Click += archivo_salir_Click;
            archivo_salir.MouseEnter += archivo_salir_MouseEnter;
            archivo_salir.MouseLeave += archivo_salir_MouseLeave;
            // 
            // ver
            // 
            ver.DropDownItems.AddRange(new ToolStripItem[] { ver_ocultarBarraDeEstado });
            ver.Name = "ver";
            ver.Size = new Size(35, 20);
            ver.Text = "Ver";
            // 
            // ver_ocultarBarraDeEstado
            // 
            ver_ocultarBarraDeEstado.Name = "ver_ocultarBarraDeEstado";
            ver_ocultarBarraDeEstado.Size = new Size(197, 22);
            ver_ocultarBarraDeEstado.Text = "Ocultar Barra de estado";
            ver_ocultarBarraDeEstado.Click += ver_ocultarBarraDeEstado_Click;
            // 
            // ventana
            // 
            ventana.DropDownItems.AddRange(new ToolStripItem[] { ventana_cascada, ventana_mosaicoHorizontal, ventana_mosaicoVertical });
            ventana.Name = "ventana";
            ventana.Size = new Size(61, 20);
            ventana.Text = "Ventana";
            // 
            // ventana_cascada
            // 
            ventana_cascada.Name = "ventana_cascada";
            ventana_cascada.Size = new Size(177, 22);
            ventana_cascada.Text = "Cascada";
            ventana_cascada.Click += ventana_cascada_Click;
            ventana_cascada.MouseEnter += ventana_cascada_MouseEnter;
            ventana_cascada.MouseLeave += ventana_cascada_MouseLeave;
            // 
            // ventana_mosaicoHorizontal
            // 
            ventana_mosaicoHorizontal.Name = "ventana_mosaicoHorizontal";
            ventana_mosaicoHorizontal.Size = new Size(177, 22);
            ventana_mosaicoHorizontal.Text = "Mosaico Horizontal";
            ventana_mosaicoHorizontal.Click += ventana_mosaicoHorizontal_Click;
            ventana_mosaicoHorizontal.MouseEnter += ventana_mosaicoHorizontal_MouseEnter;
            ventana_mosaicoHorizontal.MouseLeave += ventana_mosaicoHorizontal_MouseLeave;
            // 
            // ventana_mosaicoVertical
            // 
            ventana_mosaicoVertical.Name = "ventana_mosaicoVertical";
            ventana_mosaicoVertical.Size = new Size(177, 22);
            ventana_mosaicoVertical.Text = "Mosaico Vertical";
            ventana_mosaicoVertical.Click += ventana_mosaicoVertical_Click;
            ventana_mosaicoVertical.MouseEnter += ventana_mosaicoVertical_MouseEnter;
            ventana_mosaicoVertical.MouseLeave += ventana_mosaicoVertical_MouseLeave;
            // 
            // ayuda
            // 
            ayuda.Name = "ayuda";
            ayuda.Size = new Size(53, 20);
            ayuda.Text = "Ayuda";
            ayuda.Click += ayuda_Click;
            // 
            // barraDeHerramientas
            // 
            barraDeHerramientas.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            barraDeHerramientas.Location = new Point(0, 24);
            barraDeHerramientas.Name = "barraDeHerramientas";
            barraDeHerramientas.Size = new Size(800, 25);
            barraDeHerramientas.TabIndex = 3;
            barraDeHerramientas.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Nuevo";
            toolStripButton1.Click += archivo_nuevo_Click;
            toolStripButton1.MouseEnter += archivo_nuevo_MouseEnter;
            toolStripButton1.MouseLeave += archivo_nuevo_MouseLeave;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "Abrir";
            toolStripButton2.Click += archivo_abrir_Click;
            toolStripButton2.MouseEnter += archivo_abrir_MouseEnter;
            toolStripButton2.MouseLeave += archivo_abrir_MouseLeave;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "Acerca de";
            toolStripButton3.Click += ayuda_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { etiquetaEstado });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // etiquetaEstado
            // 
            etiquetaEstado.Name = "etiquetaEstado";
            etiquetaEstado.Size = new Size(785, 17);
            etiquetaEstado.Spring = true;
            etiquetaEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // VisorImagenes
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(barraDeHerramientas);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "VisorImagenes";
            Text = "Form1";
            MdiChildActivate += VisorImagenes_MdiChildActivate;
            DragDrop += VisorImagenes_DragDrop;
            DragEnter += VisorImagenes_DragEnter;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            barraDeHerramientas.ResumeLayout(false);
            barraDeHerramientas.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivo;
        private ToolStripMenuItem ver;
        private ToolStripMenuItem ventana;
        private ToolStripMenuItem ayuda;
        private ToolStripMenuItem ventana_cascada;
        private ToolStripMenuItem ventana_mosaicoHorizontal;
        private ToolStripMenuItem ventana_mosaicoVertical;
        private ToolStripMenuItem archivo_nuevo;
        private ToolStripMenuItem archivo_cerrar;
        private ToolStripMenuItem archivo_salir;
        private ToolStripMenuItem archivo_cargar;
        private ToolStripMenuItem archivo_abrir;
        private ToolStrip barraDeHerramientas;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        public StatusStrip statusStrip1;
        public ToolStripStatusLabel etiquetaEstado;
        private ToolStripMenuItem ver_ocultarBarraDeEstado;
    }
}