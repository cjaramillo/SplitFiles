using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SplitFiles
{

    public partial class Form1 : Form
    {
        private Regex regexTamanioPartes = new Regex("^(?:(?:[0-9]{1,9})|(?:[0-9]{1,9}.[0-9]{1,2}))$");
        private decimal tamanioPartes = 0;

        public Form1()
        {
            InitializeComponent();
            cmbTamanio.SelectedIndex = 1;
            tspbProgressBar.Maximum = 100;
            tspbProgressBar.Step = 1;
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            txtRutaArchivo.Text = openFileDialog1.FileName;
        }

        private void btnSeleccionarCarpetaSalida_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRutaCarpeta.Text = folderBrowserDialog1.SelectedPath;
                Environment.SpecialFolder root = folderBrowserDialog1.RootFolder;
            }

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (!EjecutaValidacion())
                return;
            decimal tamanioBytesParte = this.tamanioPartes;

            switch (cmbTamanio.Text)
            {
                case "Mb":
                    tamanioBytesParte = tamanioBytesParte * 1024 * 1024;
                    break;
                case "Kb":
                    tamanioBytesParte = tamanioBytesParte * 1024;
                    break;
            }
            int tamanioBytesParteInt = 0;
            int.TryParse(tamanioBytesParte.ToString(), out tamanioBytesParteInt);
            SplitFile(txtRutaArchivo.Text, tamanioBytesParteInt, folderBrowserDialog1.SelectedPath);
        }

        private bool EjecutaValidacion()
        {
            errorProvider1.Clear();

            // Validar tamaÑo:
            this.tamanioPartes = 0;
            decimal.TryParse(txtTamanioParte.Text, out this.tamanioPartes);
            if (!regexTamanioPartes.IsMatch(txtTamanioParte.Text) || !(this.tamanioPartes > 0))
            {
                errorProvider1.SetError(txtTamanioParte, "Tamaño no válido");
                return false;
            }
            decimal.TryParse(txtTamanioParte.Text, out this.tamanioPartes);
            
            // Validar archivo entrada:
            if (string.IsNullOrEmpty(txtRutaArchivo.Text))
            {
                errorProvider1.SetError(btnSeleccionarArchivo, "Seleccione un archivo para dividir");
                return false;
            }

            // Validar path salida:
            if (string.IsNullOrEmpty(txtRutaCarpeta.Text))
            {
                errorProvider1.SetError(btnSeleccionarCarpetaSalida, "Seleccione una carpeta de salida");
                return false;
            }

            return true;
        }

        private void SplitFile(string inputFile, int chunkSize, string path)
        {
            btnProcesar.Enabled = false;
            const int BUFFER_SIZE = 20 * 1024;
            byte[] buffer = new byte[BUFFER_SIZE];
            string nombreArchivo = openFileDialog1.FileName.Split('\\')[openFileDialog1.FileName.Split('\\').Length - 1];
            string extensionArchivo = string.Empty;

            string[] tmpNA = nombreArchivo.Split('.');
            if (tmpNA.Length > 1)
            {
                extensionArchivo = tmpNA[tmpNA.Length - 1];
                tmpNA[tmpNA.Length - 1] = "";
                nombreArchivo = string.Join(".", tmpNA);
                nombreArchivo = nombreArchivo.Substring(0, nombreArchivo.Length - 1);
            }

            try
            {
                using (Stream input = File.OpenRead(inputFile))
                {
                    int index = 0;
                    // La barra de progreso funcionará en base al % de avance
                    tspbProgressBar.Value = 0;
                    tsslEstado.Text = "Trabajando";
                    long tmpValue = 0;
                    while (input.Position < input.Length)
                    {
                        using (Stream output = File.Create(path + "\\" + nombreArchivo + "_" + index + "." + extensionArchivo))
                        {
                            int remaining = chunkSize, bytesRead;
                            while (remaining > 0 && (bytesRead = input.Read(buffer, 0,
                                    Math.Min(remaining, BUFFER_SIZE))) > 0)
                            {
                                output.Write(buffer, 0, bytesRead);
                                remaining -= bytesRead;
                            }
                        }
                        tmpValue = input.Position * 100 / input.Length;
                        tspbProgressBar.Value = Int32.Parse(tmpValue.ToString());
                        index++;
                    }
                    btnProcesar.Enabled = true;
                    tsslEstado.Text = "Listo";
                    tspbProgressBar.Value = 0;
                    MessageBox.Show("Proceso Finalizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtTamanioParte_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            btnProcesar.Enabled = true;
        }
    }
}
