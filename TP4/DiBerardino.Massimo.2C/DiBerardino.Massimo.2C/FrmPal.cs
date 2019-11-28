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
        private Correo cr;

        /// <summary>
        /// Pongo en el centro el form
        /// Inicializo el correo
        /// Agrego al evento errorsql el handler del evento
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
        /// Si no pudo se muestra un messagebox por pantalla
        /// Se actualizan los datos
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
                MessageBox.Show("Cargar los datos del envio de forma correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActualizarEstados();
        }


        /// <summary>
        /// Se llama al metodo mostrardatos pasandole una lista de paquetes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            this.MostrarDatos<List<Paquete>>((IMostrar<List<Paquete>>)this.cr);
        }


        /// <summary>
        /// Agrega en listbox segun el estado actual del pedido
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
        /// Handler del evento que se encarga de actualizar los estados cuando se invoca a los eventos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(Object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }

        }

        /// <summary>
        /// Handler del evento que si se llama es por que hubo un error y se encarga de mostrarlo por pantalla
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
        /// Metodo que se encarga de mostrar info que se le pasa como parametro en el rich text box del form y guardar la info en un archivo en el desktop
        /// Si sale algo mal lo muestra por pantalla.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="e"></param>
        public void MostrarDatos<T>(IMostrar<T> e)
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
        /// Limpia todas las listbox
        /// </summary>
        private void limpiarListBox()
        {
            this.lbxEntregado.Items.Clear();
            this.lbxEnViaje.Items.Clear();
            this.lbxIngresado.Items.Clear();
        }


        /// <summary>
        /// Agrego un evento para que se invoque cuando se cierre el form que mate todos los threads 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void killThreads(object sender, EventArgs e)
        {
            this.cr.FinEntregas();
        }


        /// <summary>
        /// LLama al metodo mostrardatos pasandole un solo paquete que es seleccionado si y solo si el paquete esta en entregado
        /// Si hubo un error al seleccionarlo se encarga de avisar por pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.MostrarDatos<Paquete>((IMostrar<Paquete>)this.cr.Paquetes[this.lbxEntregado.SelectedIndex]);
            }
            catch (Exception)
            {
                MessageBox.Show("Mas tranqui en elegir porfa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
