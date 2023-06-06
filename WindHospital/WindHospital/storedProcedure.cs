using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindHospital
{
    public partial class storedProcedure : Form
    {
        public storedProcedure()
        {
            InitializeComponent();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            SqlCommand cmd = new SqlCommand(
            "UpsListarDoctor", cn );
            cmd.CommandType= CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
           dtgvDoc.DataSource = tabla;
        }
    }
}
