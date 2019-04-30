namespace SplitFiles
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.lblArchivoInput = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutaCarpeta = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCarpetaSalida = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.txtTamanioParte = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(349, 123);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(160, 23);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.ReadOnly = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(219, 20);
            this.txtRutaArchivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño parte:";
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Items.AddRange(new object[] {
            "Kb",
            "Mb"});
            this.cmbTamanio.Location = new System.Drawing.Point(303, 83);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(121, 21);
            this.cmbTamanio.TabIndex = 4;
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(392, 20);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(32, 23);
            this.btnSeleccionarArchivo.TabIndex = 5;
            this.btnSeleccionarArchivo.Text = "...";
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // lblArchivoInput
            // 
            this.lblArchivoInput.AutoSize = true;
            this.lblArchivoInput.Location = new System.Drawing.Point(46, 30);
            this.lblArchivoInput.Name = "lblArchivoInput";
            this.lblArchivoInput.Size = new System.Drawing.Size(105, 13);
            this.lblArchivoInput.TabIndex = 6;
            this.lblArchivoInput.Text = "Seleccionar Archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione carpeta salida:";
            // 
            // txtRutaCarpeta
            // 
            this.txtRutaCarpeta.Location = new System.Drawing.Point(160, 53);
            this.txtRutaCarpeta.Name = "txtRutaCarpeta";
            this.txtRutaCarpeta.ReadOnly = true;
            this.txtRutaCarpeta.Size = new System.Drawing.Size(219, 20);
            this.txtRutaCarpeta.TabIndex = 9;
            // 
            // btnSeleccionarCarpetaSalida
            // 
            this.btnSeleccionarCarpetaSalida.Location = new System.Drawing.Point(392, 49);
            this.btnSeleccionarCarpetaSalida.Name = "btnSeleccionarCarpetaSalida";
            this.btnSeleccionarCarpetaSalida.Size = new System.Drawing.Size(32, 23);
            this.btnSeleccionarCarpetaSalida.TabIndex = 10;
            this.btnSeleccionarCarpetaSalida.Text = "...";
            this.btnSeleccionarCarpetaSalida.UseVisualStyleBackColor = true;
            this.btnSeleccionarCarpetaSalida.Click += new System.EventHandler(this.btnSeleccionarCarpetaSalida_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslEstado,
            this.tspbProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 171);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(452, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslEstado
            // 
            this.tsslEstado.Name = "tsslEstado";
            this.tsslEstado.Size = new System.Drawing.Size(32, 17);
            this.tsslEstado.Text = "Listo";
            // 
            // tspbProgressBar
            // 
            this.tspbProgressBar.Name = "tspbProgressBar";
            this.tspbProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // txtTamanioParte
            // 
            this.txtTamanioParte.Location = new System.Drawing.Point(160, 84);
            this.txtTamanioParte.Name = "txtTamanioParte";
            this.txtTamanioParte.Size = new System.Drawing.Size(100, 20);
            this.txtTamanioParte.TabIndex = 12;
            this.txtTamanioParte.Text = "10";
            this.txtTamanioParte.TextChanged += new System.EventHandler(this.txtTamanioParte_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 193);
            this.Controls.Add(this.txtTamanioParte);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSeleccionarCarpetaSalida);
            this.Controls.Add(this.txtRutaCarpeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArchivoInput);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.cmbTamanio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.btnProcesar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplitFiles";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.Label lblArchivoInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutaCarpeta;
        private System.Windows.Forms.Button btnSeleccionarCarpetaSalida;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslEstado;
        private System.Windows.Forms.ToolStripProgressBar tspbProgressBar;
        private System.Windows.Forms.MaskedTextBox txtTamanioParte;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

