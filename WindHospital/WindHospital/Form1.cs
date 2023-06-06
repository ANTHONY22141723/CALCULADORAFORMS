using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace WindHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["cnx"].ConnectionString );

            SqlCommand cmd = new SqlCommand(
            "select * from Doctor", cn);
            DataTable tabla = new DataTable();    
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill( tabla );
            dtgvHospital.DataSource = tabla;
        }
    }
}
