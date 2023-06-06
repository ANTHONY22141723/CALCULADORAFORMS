using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace WindProcedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            SqlCommand cmd = new SqlCommand(
            "Sp_InsertarBoton", cn);

            cn.Open();
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
            cmd.Parameters.AddWithValue("@BHabilitado", txtHabilitado.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            

            SqlCommand cmda = new SqlCommand(
           "select * from Boton", cn);

            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmda);
            sda.Fill(tabla);
            dtgvListarBoton.DataSource = tabla;

            cn.Close();
        }
    }
}
