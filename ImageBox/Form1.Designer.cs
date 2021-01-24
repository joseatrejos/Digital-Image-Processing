namespace ImageBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sovelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroPorRangoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contornosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectarFormasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectarTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.panAndZoomPictureBox2 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.detectarCaraOjosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.procesamientoToolStripMenuItem,
            this.contornosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1331, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.loadVideoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.LoadImageToolStripMenuItem_Click);
            // 
            // loadVideoToolStripMenuItem
            // 
            this.loadVideoToolStripMenuItem.Name = "loadVideoToolStripMenuItem";
            this.loadVideoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadVideoToolStripMenuItem.Text = "Load Video";
            this.loadVideoToolStripMenuItem.Click += new System.EventHandler(this.loadVideoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.RedToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.GreenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.BlueToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyToolStripMenuItem,
            this.sovelToolStripMenuItem,
            this.laplacianToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.filtersToolStripMenuItem.Text = "Border Recognition Filters";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.CannyToolStripMenuItem_Click);
            // 
            // sovelToolStripMenuItem
            // 
            this.sovelToolStripMenuItem.Name = "sovelToolStripMenuItem";
            this.sovelToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sovelToolStripMenuItem.Text = "Sobel";
            this.sovelToolStripMenuItem.Click += new System.EventHandler(this.SovelToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.LaplacianToolStripMenuItem_Click);
            // 
            // procesamientoToolStripMenuItem
            // 
            this.procesamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtroPorRangoToolStripMenuItem,
            this.overlayToolStripMenuItem});
            this.procesamientoToolStripMenuItem.Name = "procesamientoToolStripMenuItem";
            this.procesamientoToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.procesamientoToolStripMenuItem.Text = "Procesamiento";
            // 
            // filtroPorRangoToolStripMenuItem
            // 
            this.filtroPorRangoToolStripMenuItem.Name = "filtroPorRangoToolStripMenuItem";
            this.filtroPorRangoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtroPorRangoToolStripMenuItem.Text = "Filtro por Rango";
            this.filtroPorRangoToolStripMenuItem.Click += new System.EventHandler(this.FiltroPorRangoToolStripMenuItem_Click);
            // 
            // overlayToolStripMenuItem
            // 
            this.overlayToolStripMenuItem.Name = "overlayToolStripMenuItem";
            this.overlayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.overlayToolStripMenuItem.Text = "Overlay";
            this.overlayToolStripMenuItem.Click += new System.EventHandler(this.overlayToolStripMenuItem_Click);
            // 
            // contornosToolStripMenuItem
            // 
            this.contornosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detectarToolStripMenuItem,
            this.detectarFormasToolStripMenuItem,
            this.detectarTextoToolStripMenuItem,
            this.detectarCaraOjosToolStripMenuItem});
            this.contornosToolStripMenuItem.Name = "contornosToolStripMenuItem";
            this.contornosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.contornosToolStripMenuItem.Text = "Contornos";
            // 
            // detectarToolStripMenuItem
            // 
            this.detectarToolStripMenuItem.Name = "detectarToolStripMenuItem";
            this.detectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detectarToolStripMenuItem.Text = "Detectar Objetos";
            this.detectarToolStripMenuItem.Click += new System.EventHandler(this.DetectarToolStripMenuItem_Click);
            // 
            // detectarFormasToolStripMenuItem
            // 
            this.detectarFormasToolStripMenuItem.Name = "detectarFormasToolStripMenuItem";
            this.detectarFormasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detectarFormasToolStripMenuItem.Text = "Detectar Formas";
            this.detectarFormasToolStripMenuItem.Click += new System.EventHandler(this.DetectarFormasToolStripMenuItem_Click_1);
            // 
            // detectarTextoToolStripMenuItem
            // 
            this.detectarTextoToolStripMenuItem.Name = "detectarTextoToolStripMenuItem";
            this.detectarTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detectarTextoToolStripMenuItem.Text = "Detectar Texto";
            this.detectarTextoToolStripMenuItem.Click += new System.EventHandler(this.detectarTextoToolStripMenuItem_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(502, 74);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(328, 120);
            this.histogramBox1.TabIndex = 9;
            // 
            // panAndZoomPictureBox1
            // 
            this.panAndZoomPictureBox1.Location = new System.Drawing.Point(12, 58);
            this.panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            this.panAndZoomPictureBox1.Size = new System.Drawing.Size(290, 292);
            this.panAndZoomPictureBox1.TabIndex = 10;
            this.panAndZoomPictureBox1.TabStop = false;
            // 
            // panAndZoomPictureBox2
            // 
            this.panAndZoomPictureBox2.Location = new System.Drawing.Point(12, 384);
            this.panAndZoomPictureBox2.Name = "panAndZoomPictureBox2";
            this.panAndZoomPictureBox2.Size = new System.Drawing.Size(290, 292);
            this.panAndZoomPictureBox2.TabIndex = 11;
            this.panAndZoomPictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(308, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 528);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(829, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 528);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // detectarCaraOjosToolStripMenuItem
            // 
            this.detectarCaraOjosToolStripMenuItem.Name = "detectarCaraOjosToolStripMenuItem";
            this.detectarCaraOjosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detectarCaraOjosToolStripMenuItem.Text = "Detectar Cara/Ojos";
            this.detectarCaraOjosToolStripMenuItem.Click += new System.EventHandler(this.DetectarCaraOjosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 849);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panAndZoomPictureBox2);
            this.Controls.Add(this.panAndZoomPictureBox1);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sovelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox2;
        private System.Windows.Forms.ToolStripMenuItem procesamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroPorRangoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem overlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contornosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectarFormasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectarTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectarCaraOjosToolStripMenuItem;
    }
}

