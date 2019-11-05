using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;       //usaremos esta libreria
using System.Data.OleDb; //y esta
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Consulta
{
    public partial class FrmMain : Form
    {
        OleDbConnection conn;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Coneccion a la base de datos del documento "Books.accbd" (documento de access)

            //Para mejor aclaracion fue obtenido de este enlace en: https://www.connectionstrings.com/access/
            //Seleccionado del estandar de seguridad.
            var connstring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\DB\Books.accdb; Persist Security Info = False";
            conn = new OleDbConnection (connstring);
            conn.Open();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close(); 
            conn.Dispose(); //Nos deshacemos de los recursos no administrados
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Contenido del boton
            OleDbCommand command = null;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                command = new OleDbCommand(TxtComando.Text, conn);
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                DgDatos.DataSource = dt; //desplegara los datos en el DataGridView
                LblContador.Text = dt.Rows.Count.ToString(); //desplegara en la etiqueta cuantos datos hay de esa fila
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error en el comando SSQL", MessageBoxButtons.OK, MessageBoxIcon.Error); //Desplegara un messagebox mostrando el error
            }
            command.Dispose();
            adapter.Dispose();
            dt.Dispose();
        }
    }
}
