namespace VisorDeImagenes
{
    partial class VentanaHija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaHija));
            m_PictureBox = new PictureBox();
            menuStrip1 = new MenuStrip();
            imagenToolStripMenuItem = new ToolStripMenuItem();
            imagen_ajustarVentana = new ToolStripMenuItem();
            imagen_rotar90 = new ToolStripMenuItem();
            imagen_añadirTexto = new ToolStripMenuItem();
            imagen_escalaDeGrises = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            archivo_guardar = new ToolStripMenuItem();
            archivo_guardarComo = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            barraDeHerramientas = new ToolStrip();
            toolStripButton1 = new ToolStripSeparator();
            ajustar_ventana = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)m_PictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            barraDeHerramientas.SuspendLayout();
            SuspendLayout();
            // 
            // m_PictureBox
            // 
            m_PictureBox.Dock = DockStyle.Fill;
            m_PictureBox.Location = new Point(0, 0);
            m_PictureBox.Name = "m_PictureBox";
            m_PictureBox.Size = new Size(414, 274);
            m_PictureBox.TabIndex = 0;
            m_PictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { imagenToolStripMenuItem, archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(414, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // imagenToolStripMenuItem
            // 
            imagenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imagen_ajustarVentana, imagen_rotar90, imagen_añadirTexto, imagen_escalaDeGrises });
            imagenToolStripMenuItem.MergeAction = MergeAction.Insert;
            imagenToolStripMenuItem.MergeIndex = 2;
            imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            imagenToolStripMenuItem.Size = new Size(59, 20);
            imagenToolStripMenuItem.Text = "Imagen";
            // 
            // imagen_ajustarVentana
            // 
            imagen_ajustarVentana.Name = "imagen_ajustarVentana";
            imagen_ajustarVentana.Size = new Size(156, 22);
            imagen_ajustarVentana.Text = "Ajustar Ventana";
            imagen_ajustarVentana.Click += imagen_ajustarVentana_Click;
            imagen_ajustarVentana.MouseEnter += imagen_ajustarVentana_MouseEnter;
            imagen_ajustarVentana.MouseLeave += imagen_ajustarVentana_MouseLeave;
            // 
            // imagen_rotar90
            // 
            imagen_rotar90.Name = "imagen_rotar90";
            imagen_rotar90.Size = new Size(156, 22);
            imagen_rotar90.Text = "Rotar 90°";
            imagen_rotar90.Click += imagen_rotar90_Click;
            imagen_rotar90.MouseEnter += imagen_rotar90_MouseEnter;
            imagen_rotar90.MouseLeave += imagen_rotar90_MouseLeave;
            // 
            // imagen_añadirTexto
            // 
            imagen_añadirTexto.Name = "imagen_añadirTexto";
            imagen_añadirTexto.Size = new Size(156, 22);
            imagen_añadirTexto.Text = "Añadir texto";
            imagen_añadirTexto.Click += imagen_añadirTexto_Click;
            imagen_añadirTexto.MouseEnter += imagen_añadirTexto_MouseEnter;
            imagen_añadirTexto.MouseLeave += imagen_añadirTexto_MouseLeave;
            // 
            // imagen_escalaDeGrises
            // 
            imagen_escalaDeGrises.Name = "imagen_escalaDeGrises";
            imagen_escalaDeGrises.Size = new Size(156, 22);
            imagen_escalaDeGrises.Text = "Escala de grises";
            imagen_escalaDeGrises.Click += imagen_escalaDeGrises_Click;
            imagen_escalaDeGrises.MouseEnter += imagen_escalaDeGrises_MouseEnter;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { archivo_guardar, archivo_guardarComo, toolStripSeparator1 });
            archivoToolStripMenuItem.MergeAction = MergeAction.MatchOnly;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // archivo_guardar
            // 
            archivo_guardar.MergeAction = MergeAction.Insert;
            archivo_guardar.MergeIndex = 3;
            archivo_guardar.Name = "archivo_guardar";
            archivo_guardar.Size = new Size(152, 22);
            archivo_guardar.Text = "Guardar";
            archivo_guardar.Click += archivo_guardar_Click;
            archivo_guardar.MouseEnter += archivo_guardar_MouseEnter;
            archivo_guardar.MouseLeave += archivo_guardar_MouseLeave;
            // 
            // archivo_guardarComo
            // 
            archivo_guardarComo.MergeAction = MergeAction.Insert;
            archivo_guardarComo.MergeIndex = 4;
            archivo_guardarComo.Name = "archivo_guardarComo";
            archivo_guardarComo.Size = new Size(152, 22);
            archivo_guardarComo.Text = "Guardar Como";
            archivo_guardarComo.Click += archivo_guardarComo_Click;
            archivo_guardarComo.MouseEnter += archivo_guardarComo_MouseEnter;
            archivo_guardarComo.MouseLeave += archivo_guardarComo_MouseLeave;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.MergeAction = MergeAction.Insert;
            toolStripSeparator1.MergeIndex = 5;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(149, 6);
            // 
            // barraDeHerramientas
            // 
            barraDeHerramientas.Items.AddRange(new ToolStripItem[] { toolStripButton1, ajustar_ventana, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6, toolStripSeparator2 });
            barraDeHerramientas.Location = new Point(0, 0);
            barraDeHerramientas.Name = "barraDeHerramientas";
            barraDeHerramientas.Size = new Size(414, 25);
            barraDeHerramientas.TabIndex = 2;
            barraDeHerramientas.Text = "toolStrip1";
            barraDeHerramientas.Visible = false;
            // 
            // toolStripButton1
            // 
            toolStripButton1.MergeAction = MergeAction.Insert;
            toolStripButton1.MergeIndex = 2;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(6, 25);
            // 
            // ajustar_ventana
            // 
            ajustar_ventana.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajustar_ventana.Image = (Image)resources.GetObject("ajustar_ventana.Image");
            ajustar_ventana.ImageTransparentColor = Color.Magenta;
            ajustar_ventana.MergeAction = MergeAction.Insert;
            ajustar_ventana.MergeIndex = 3;
            ajustar_ventana.Name = "ajustar_ventana";
            ajustar_ventana.Size = new Size(23, 22);
            ajustar_ventana.Text = "Guardar";
            ajustar_ventana.Click += archivo_guardar_Click;
            ajustar_ventana.MouseEnter += archivo_guardar_MouseEnter;
            ajustar_ventana.MouseLeave += archivo_guardar_MouseLeave;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.MergeAction = MergeAction.Insert;
            toolStripButton3.MergeIndex = 4;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "Ajustar imagen";
            toolStripButton3.Click += imagen_ajustarVentana_Click;
            toolStripButton3.MouseEnter += imagen_ajustarVentana_MouseEnter;
            toolStripButton3.MouseLeave += imagen_ajustarVentana_MouseLeave;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.MergeAction = MergeAction.Insert;
            toolStripButton4.MergeIndex = 5;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "Girar 90°";
            toolStripButton4.Click += imagen_rotar90_Click;
            toolStripButton4.MouseEnter += imagen_rotar90_MouseEnter;
            toolStripButton4.MouseLeave += imagen_rotar90_MouseLeave;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.MergeAction = MergeAction.Insert;
            toolStripButton5.MergeIndex = 6;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "Añadir texto";
            toolStripButton5.Click += imagen_añadirTexto_Click;
            toolStripButton5.MouseEnter += imagen_añadirTexto_MouseEnter;
            toolStripButton5.MouseLeave += imagen_añadirTexto_MouseLeave;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.MergeAction = MergeAction.Insert;
            toolStripButton6.MergeIndex = 7;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 22);
            toolStripButton6.Text = "Escala de grises";
            toolStripButton6.Click += imagen_escalaDeGrises_Click;
            toolStripButton6.MouseEnter += imagen_escalaDeGrises_MouseEnter;
            toolStripButton6.MouseLeave += archivo_guardar_MouseLeave;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.MergeAction = MergeAction.Insert;
            toolStripSeparator2.MergeIndex = 8;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // VentanaHija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 274);
            Controls.Add(barraDeHerramientas);
            Controls.Add(m_PictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "VentanaHija";
            Text = "VentanaHija";
            Resize += VentanaHija_Resize;
            ((System.ComponentModel.ISupportInitialize)m_PictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            barraDeHerramientas.ResumeLayout(false);
            barraDeHerramientas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox m_PictureBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem imagenToolStripMenuItem;
        private ToolStripMenuItem imagen_ajustarVentana;
        private ToolStripMenuItem imagen_rotar90;
        private ToolStripMenuItem imagen_añadirTexto;
        private ToolStripMenuItem imagen_escalaDeGrises;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem archivo_guardar;
        private ToolStripMenuItem archivo_guardarComo;
        private ToolStripSeparator toolStripSeparator1;
        public ToolStrip barraDeHerramientas;
        private ToolStripSeparator toolStripButton1;
        private ToolStripButton ajustar_ventana;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator2;
    }
}