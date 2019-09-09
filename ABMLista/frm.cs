using System;
using System.Windows.Forms;
using ABMLista;
namespace ABMLista
{
    public partial class frm : Form
    {
        #region Constantes
        const int Incremento = 1;
        #endregion

        #region Propiedades
        /*string[] Lista = new string[5];
        int ProximaPosicion = 0;*/
        #endregion
        Clases.Lista Alumnos = new Clases.Lista();
        
        Alumnos alumno = new Alumnos();
        public frm()
        {
            InitializeComponent();
        }

        #region Eventos
        private void BtAgregar_Click(object sender, EventArgs e)
        {
            /*if(ProximaPosicion==Lista.Length)
            {
                this.AgregaRegistro(Incremento);
            }

            Lista[ProximaPosicion] = txt.Text;
            ProximaPosicion++;*/

            if (Alumnos.Agregar(txtNombre.Text))
            {
                lblCarga.Text = Alumnos.MostrarLista();

            }
            else
            {
                MessageBox.Show("e r r o r ");
            }

            txtNombre.SelectAll();
            txtNombre.Focus();

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            int Pos = Alumnos.BuscarPosicion(txtNombre.Text);
            if (Pos == -1)
            {
                lblCarga.Text = "No existe " + txtNombre.Text + " no se encontro";
            }
            else
            {
                lblCarga.Text = "pos es : " + (Pos + 1).ToString();

            }
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            string Resp = Alumnos.BorrarPosicion(txtNombre.Text);
            if (string.IsNullOrEmpty(Resp))
            {
                Resp = " el alumno " + txtNombre.Text + "fue borrado";
            }
            lblCarga.Text = Alumnos.MostrarLista();
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtMostrar_Click(object sender, EventArgs e)
        {
            lblCarga.Text = Alumnos.MostrarLista();
            string eo = Alumnos.Ordenar();
        }

        private void BtOrdenar_Click(object sender, EventArgs e)
        {
            lblCarga.Text = Alumnos.MostrarLista();
            lblOrdenado.Text = Alumnos.Ordenar();
        }
        #endregion

        //private string MostrarLista()
        //{
        //    string Respuesta = "";
        //    if (ProximaPosicion > 0)
        //    {
        //        Respuesta = Lista[0];
        //        for (int i = 1; i < ProximaPosicion; i++)
        //        {
        //            Respuesta = Respuesta + "\r\n" + Lista[i];
        //        }
        //    }
        //    return Respuesta;
        //}

        /*private void AgregaRegistro(int Incremento)
        {
            string[] Temp = new string[Lista.Length + Incremento];
            Lista = this.Copiar(Lista, Temp);

        }*/

        //private string[] Copiar(string[] Origen, string[] Destino)
        //{
        //    for (int i = 0; i < Origen.Length; i++)
        //    {
        //        Destino[i] = Origen[i];
        //    }
        //    return Destino;
        //}
    }
}
