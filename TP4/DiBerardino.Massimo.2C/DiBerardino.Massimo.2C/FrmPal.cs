using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace MainCorreo
{
    public partial class FrmPal : Form
    {
        Correo cr;

        /// <summary>
        /// centro el form
        /// Inicializo el correo
        /// Agrego al errorsql el handler
        /// </summary>
        public FrmPal()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.cr = new Correo();
            PaqueteDAO.errorSql += this.paqDao_InformaEstado;
            FormClosing += killThreads;
        }


        /// <summary>
        /// Genera un nuevo envio y lo agrega al correo
        /// en caso de error muestra un messagebox por pantalla
        /// actualizan los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tbDireccion.Text) && this.mtbTrackingId.MaskCompleted)
            {
                Paquete p = new Paquete(this.tbDireccion.Text, this.mtbTrackingId.Text);
                p.InformarEstado += this.paq_InformaEstado;
                try
                {
                    this.cr += p;
                }
                catch (TrackingIdRepetidoException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cargar los datos de forma correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActualizarEstados();
        }


        /// <summary>
        /// Muestra la lista de envios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)cr);
        }


        /// <summary>
        /// listbox segun el estado actual del envio
        /// </summary>
        private void ActualizarEstados()
        {
            this.limpiarListBox();
            foreach (Paquete item in this.cr.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lbxIngresado.Items.Add(item.ToString());
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lbxEnViaje.Items.Add(item.ToString());
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lbxEntregado.Items.Add(item.ToString());
                        break;
                }
            }
        }


        /// <summary>
        /// handler que se encarga de actualizar los estados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(Object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                DelegadoEstado d = new DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }

        }

        /// <summary>
        /// handler que se encarga de mostrar los errores por pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paqDao_InformaEstado(string message)
        {
            if (this.InvokeRequired)
            {
                DelegateSqlError d = new DelegateSqlError(paqDao_InformaEstado);
                this.Invoke(d, new object[] { message });
            }
            else
            {
                MessageBox.Show("Error al guardar en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// mostrar info que se le pasa como parametro en el rich text box del form y guardar la info en un txt
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="e"></param>
        public void MostrarInformacion<T>(IMostrar<T> e)
        {
            if (e != null && e is Correo || e is Paquete)
            {
                this.rtbMostrar.Text = e.MostrarDatos(e);
                try
                {
                    this.rtbMostrar.Text.Guardar("salida.txt");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar la salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// limpia las listbox
        /// </summary>
        private void limpiarListBox()
        {
            this.lbxEntregado.Items.Clear();
            this.lbxEnViaje.Items.Clear();
            this.lbxIngresado.Items.Clear();
        }


        /// <summary>
        /// evento que se invoca cuando se cierre el form y mate todos los threads 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void killThreads(object sender, EventArgs e)
        {
            this.cr.FinEntregas();
        }


        /// <summary>
        /// LLama al metodo mostrardatos pasandole un solo paquete que es seleccionado solo si el paquete esta entregado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MostrarInformacion<Paquete>((IMostrar<Paquete>)this.cr.Paquetes[this.lbxEntregado.SelectedIndex]);
            }
            catch (Exception)
            {
                MessageBox.Show("Elegir mas lento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
