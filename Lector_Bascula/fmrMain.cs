using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RFIDMEDevKit;
using System.Management;
using System.IO.Ports;
using System.Threading;
using System.IO;
using RestSharp;
using Newtonsoft.Json;

namespace Lector_Bascula
{
    public partial class fmrMain : Form
    {   
        public reader reader;
        private List<String> puertos;
        private String puerto;
        private String readerSelected;
        private SerialPort puertoBascula;
        private Thread thread;
        private Thread thread2;
        private bool hilo2;
        private bool hilo;
        private String peso;
        private String epc;
        private Event ev;
        private Config config;

        public fmrMain()
        {
            InitializeComponent();
            inicializaEntorno();
        }

        private void inicializaEntorno()
        {
            if (this.cargarConfiguracion())
            {
                this.inicializaVariables();
                switch (this.config.modo)
                {
                    case 0: configuracionUsuario();
                        break;
                    case 1: configuracionAdministrador();
                        break;
                } 
            }   
        }

        private void configuracionAdministrador()
        {
        }

        private void configuracionUsuario()
        {

        }

        private void inicializaVariables()
        {
            this.puertos = new List<string>();
            this.puerto = "";
            this.peso = "";
            this.epc = "";
            this.readerSelected = "RFIDME";
            this.puertoBascula = new SerialPort();
            this.puertoBascula.BaudRate = 115200;
            this.puertoBascula.ReadTimeout = 2000;
            this.reader = new reader();
            this.ConectarConDispositivos();
            this.ev = new Event();
            ev.GET();
            this.groupBoxInventory.Text = "Inventario: " + "\"" + ev.name + "\"";
            this.radioButtonInitial.Checked = true;
            this.radioButtonInventory.Checked = true;
            CheckForIllegalCrossThreadCalls = false;
        }

        private bool cargarConfiguracion()
        {
            try
            {
                this.config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo de configuracion\n"+ex.Message);
                return false;
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.inicializaEntorno();
            }
            catch(Exception ex)
            {
            }
        }

        private bool ConectarConDispositivos()
        {
            if (this.DetectaLosPuertos() && this.ConectaConLector() && this.ConectaConElPuerto())
            {
                this.pictureBoxEstado.BackColor = Color.Green;
                this.labelEstado.Text = "CONECTADO";
                this.toolStripConectar.Text = "Restart";
                this.textBox1.Text = "¡¡¡CONEXIÓN CORRECTA!!!" + Environment.NewLine+"¡LISTO PARA LEER!";
                return true;
            }
            return false;
        }

        private bool ConectaConLector()
        {
            try
            {
                this.reader.Activation("Demo");
                if(this.reader.Connect(this.readerSelected).Equals("Connected"))
                {
                    if (this.readerSelected.Equals("RU824"))
                    {
                        this.reader.setDwellTime(50);
                        this.reader.setNumInvCyc(50);
                        this.reader.setPower(240);
                    }
                    else
                    {
                        this.reader.setPower(18);
                    }
                    this.labelAvisos.Text = "Se conectó correctamente el lector " + this.readerSelected;
                    this.pictureBoxLector.BackColor = Color.Green;
                    return true;
                }
                else
                {
                    this.labelAvisos.Text = "No se logró establecer comunicación.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                this.labelAvisos.Text = "No se logró establecer comunicación.\n" + ex.Message;
                return false;
            }
        }

        private bool ConectaConElPuerto()
        {
            try
            {
                if (this.puertos[0].Equals("COM3"))
                {
                    this.puertoBascula.PortName = this.puertos[0];
                    this.puertoBascula.Open();
                    this.labelAvisos.Text = "Se conectó correctamente con el puerto " + this.puertoBascula.PortName + ".";
                    this.puertoBascula.Write(new byte[] { 13, 10 }, 0, 2);
                    this.puertoBascula.ReadExisting().ToString();
                    this.puertoBascula.WriteLine("\r\n");
                    this.pictureBoxBascula.BackColor = Color.Green;
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                this.labelAvisos.Text = "No se logró establecer conexión con el puerto " + this.puertoBascula.PortName + ".\n" + ex.Message;
                return false;
            }
        }

        private bool DetectaLosPuertos()
        {

            try
            {
                this.puertos.Clear();
                foreach (PortInfo pi in PortInfo.GetPortsInfo())
                {
                    this.puertos.Add(pi.Name);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al detectar los puertos. " + ex.Message, "Error al detectar puertos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.puertoBascula.IsOpen)
                {
                    if (MessageBox.Show(this, "¿Seguro que quiere hacer la desconexión?", "Desconectar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.reader.Disconnect();
                        this.puertoBascula.Close();
                        this.pictureBoxLector.BackColor = Color.Red;
                        this.pictureBoxBascula.BackColor = Color.Red;
                        this.pictureBoxListoLeer.BackColor = Color.Red;
                    }
                }
                else
                    MessageBox.Show("Los dispositivos no están conectados", "Dispositivos no conectados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al tratar de desconectar el lector y la bascula.\nError: " + ex.Message, "Error al desconectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            List<String> data = new List<string>();
            Bulk bulk = new Bulk();
            ConvertEPC convertEPC = new ConvertEPC();
            Char[] delimiterChars = {' '};
            String message = "";

            try
            {
                if (this.puertoBascula.IsOpen)
                {
                    this.buttonReadings.Enabled = false;
                    hilo = true;
                    t = new Thread(new ThreadStart(ThreadProc));
                    t.Start();
                    data = realizaLecturas();
                    if (data != null)
                    {
                        if (data[2].Equals("LIBRE"))
                        {
                            convertEPC.Epc = data[0];
                            bulk.epc = data[0];
                            bulk.kg = Double.Parse(data[1].Split(delimiterChars)[1], System.Globalization.CultureInfo.InvariantCulture);
                            bulk.kg = (int)(bulk.kg * 1000);
                            bulk.upc = convertEPC.getUpc();
                            if (this.radioButtonInitial.Checked == true)
                                bulk.inventory = 0;
                            else
                                bulk.inventory = 1;
                            if (this.radioButtonInventory.Checked == true)
                                message = bulk.inventoryPOST();
                            else
                                message = bulk.registerWeightPOST();
                        }
                        else
                            message = "¡LIBERE LAS BARRAS PARA PODER REGISTRAR LOS DATOS!";
                    }
                    hilo = false;
                    t.Join();
                    this.buttonReadings.Enabled = true; this.pictureBoxEstado.BackColor = Color.Green;
                    this.labelEstado.Text = "CONECTADO";
                    this.textBox1.Text = message;
                }
                else
                    MessageBox.Show(this, "Verifica que el lector y la báscula estén conectados correctamente", "Verifica la conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al tratar de iniciar la lectura de tags.", "Error al iniciar lectura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private List<String> realizaLecturas()
        {
            List<String> data = new List<string>();

            try
            {
                data.Add(epc = this.leerEPC());
                if (data[0] != "No tags found")
                {
                    String datos = obtenerPeso();
                    String[] arrays = datos.Split('\r');
                    data.Add(arrays[1]);
                    data.Add(arrays[0]);
                    if (arrays.Length > 1)
                    {
                        String estado = arrays[0];
                        peso = arrays[1];
                        if (epc != null && peso != null)
                        {
                            if (!epc.Equals(""))
                            {
                                if (!peso.Equals(""))
                                {
                                    if (dgvDatos.Rows.Count >= 1)
                                    {
                                        LinkedList<String> epcs = new LinkedList<string>();
                                        LinkedList<String> pesosLista = new LinkedList<string>();
                                        for (int i = 0; i < dgvDatos.Rows.Count; i++)
                                        {
                                            epcs.AddLast(Convert.ToString(dgvDatos.Rows[i].Cells["EPC"].Value));
                                            pesosLista.AddLast(Convert.ToString(dgvDatos.Rows[i].Cells["PESO"].Value));
                                        }
                                        if (!epc.Contains("No tags found"))
                                        {

                                            String po = peso.Trim();
                                            String[] ps = po.Split(new Char[] { ' ' });
                                            if (Convert.ToDouble(ps[0]) >= 0.200)
                                            {
                                                if (estado.Equals("LIBRE"))
                                                {
                                                    dgvDatos.Rows.Insert(dgvDatos.Rows.Count, epc, peso);
                                                    Clipboard.SetText(epc + "," + peso);

                                                }
                                                else
                                                {
                                                    // MessageBox.Show(this,"Libere las barras para poder registrar los datos.", "Barras obstruidas",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                                    this.labelAvisos.Text = "Libere las barras \npara poder registrar \nlos datos.";

                                                }
                                            }
                                            else
                                            {

                                                this.labelAvisos.Text = "Peso menor a 200 gr.";
                                            }
                                        }
                                        else
                                        {
                                            this.labelAvisos.Text = "No se detecto ningún tag\nVuelva a intentar leer ";

                                        }
                                    }
                                    else
                                    {
                                        if (!epc.Equals("No tags found"))
                                        {
                                            String po = peso.Trim();
                                            String[] ps = po.Split(new Char[] { ' ' });
                                            if (Convert.ToDouble(ps[0]) >= 0.200)
                                            {
                                                dgvDatos.Rows.Insert(0, epc, peso);
                                                Clipboard.SetText(epc + "," + peso);

                                            }
                                            else
                                            {
                                                this.labelAvisos.Text = "Peso menor a 200 gr.";
                                            }
                                        }
                                        else
                                        {
                                            this.labelAvisos.Text = "No se detectaron tags.";
                                        }
                                    }
                                }
                                else
                                {
                                    // MessageBox.Show(this,"Asegurese de que la báscula esté conectada y de que hay objetos que pesar.", "Revise la báscula",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                    this.labelAvisos.Text = "Asegurese de que la báscula esté conectada \ny de que haya objetos que pesar.";

                                }
                            }
                            else
                            {
                                // MessageBox.Show(this,"Asegurese de que el Tag no esté dañado o de que haya Tag para escanear, no se detectó ningún valor.", "No se detectó ningún tag",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.labelAvisos.Text = "No se detecto ningún tag\nVuelva a intentar leer ";

                            }
                        }
                        else
                        {
                            this.labelAvisos.Text = "No se detectó ningún dato.\nAsegurese de que hay peso sobre la báscula \ny que hay un tag.";

                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se pudo leer la etiqueta", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error estableciendo datos de lectura y peso.\nError: " + ex.Message, "Error al llenar tabla", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            return data;
        }
        private String leerEPC()
        {
            String data = "No tags found";
            String[] epcs = null;
            int intentos = 0;

            try
            {
                while (data.Equals("No tags found") && intentos != 20)
                {
                    data = reader.ReadEPC(false, ",");
                    epcs = data.Split(',');
                    intentos++;
                    data = epcs[0];
                }

                return data;
            }
            catch (Exception exc)
            {
                if (!exc.Message.Equals("Se interrumpió el estado de espera del subproceso."))
                {
                    MessageBox.Show(this, "Error leyendo EPCS: \n" + exc.Message, "Error al leer Tags", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return null;
            }
        }

        private String obtenerPeso()
        {
            try
            {
                this.puertoBascula.WriteLine("\r\n");
                this.puertoBascula.DiscardOutBuffer();
                this.puertoBascula.DiscardInBuffer();
                String peso = this.puertoBascula.ReadTo("\r\n").ToString();
                return peso;

            }
            catch (Exception ex)
            {
                if (!ex.Message.Equals("Se interrumpió el estado de espera del subproceso."))
                {
                    MessageBox.Show(this, "Error obteniendo peso: \n" + ex.Message, "Error obteniendo peso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {

        }

        public Thread t { get; set; }

        private void ThreadProc()
        {
            while (hilo)
            {
                this.pictureBoxEstado.BackColor = Color.Orange;
                this.labelEstado.Text = "REALIZANDO LECTURA...";
                this.textBox1.Text = "¡REALIZANDO LECTURA!" + Environment.NewLine + "¡ESPERE..........!";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void radioButtonInitial_Click(object sender, EventArgs e)
        {
            this.buttonReadings.Focus();
        }

        private void radioButtonWeight_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxInventory.Enabled = false;
            this.radioButtonInitial.Checked = false;
            this.radioButtonFinal.Checked = false;
            this.buttonReadings.Focus();
        }

        private void radioButtonInventory_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxInventory.Enabled = true;
            this.radioButtonInitial.Checked = true;
            this.buttonReadings.Focus();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.buttonReadings.Focus();
        }

        private void radioButtonInventory_MouseClick(object sender, MouseEventArgs e)
        {
            this.buttonReadings.Focus();
        }

    }
}
