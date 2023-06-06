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

namespace CalculadoraCen
{
    public partial class Form1 : Form
    {
        
 
    

        public Form1()
        {
            InitializeComponent();
            
        }


        // Campos:
        public void Calculadora()
        {
            resultado = 0.0;
            operacion = string.Empty;
            num1 = string.Empty;
            num2 = "";
            valor = false;
            conteo = 0;
            conteo1 = 0;
            conteo2 = 0;
            conteo3 = 0;
            conteo4 = 0;
            conteo5 = 0;

        }


        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtDisplay2.Text = "0";
            this.Calculadora();
          

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtDisplay2.Text = "0";
            this.Calculadora();
           

        }

            Double resultado = 0.0;
            string operacion = string.Empty;
            string num1, num2;
            bool valor = false;
            int conteo = 0;
            int conteo1 = 0;
            int conteo2 = 0;    
            int conteo3 = 0;    
            int conteo4 = 0;    
            int conteo5 = 0;    


        private void btnMathOperacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultado != 0) btnIgual.PerformClick();
                else resultado = Double.Parse(txtDisplay.Text);

                // resultado += Double.Parse(num1);

                Button boton = (Button)sender;
                operacion = boton.Text;
                valor = true;

                //if (txtDisplay.Text != "0")
               // {
                    txtDisplay2.Text = $"{resultado} {operacion}";
                    txtDisplay.Text = string.Empty;
               // }
            }catch(Exception )
            {
                MessageBox.Show(" DEBES ELEGIR UN NUMERO DEL TECLADO");
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(
                      ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

                SqlCommand cmd = new SqlCommand(
                "Sp_GuardarOperacion", cn);
                cn.Open();

                num2 = txtDisplay.Text;

                txtDisplay2.Text = $"{txtDisplay2.Text} {txtDisplay.Text} ";
                if (txtDisplay.Text != string.Empty)
                {
                   // if (txtDisplay.Text == "0") txtDisplay2.Text = string.Empty;

                    switch (operacion)
                    {
                        case "+":
                            txtDisplay.Text = (resultado + Double.Parse(txtDisplay.Text)).ToString();
                            if (resultado == 0) cmd.Parameters.AddWithValue("@FstNum", num1);
                            else cmd.Parameters.AddWithValue("@FstNum", resultado);
                            cmd.Parameters.AddWithValue("@Operando", operacion);
                            cmd.Parameters.AddWithValue("@SecNum ", num2);
                            cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            SqlCommand cmda = new SqlCommand("select FstNum , Operando, SecNum, Resultado from Historial", cn);

                            DataTable tabla = new DataTable();
                            SqlDataAdapter sda = new SqlDataAdapter(cmda);
                            sda.Fill(tabla);
                            dtgvHistorial.DataSource = tabla;
                            cmda.ExecuteNonQuery();
                            cn.Close();
                            break;

                        case "-":
                            txtDisplay.Text = (resultado - Double.Parse(txtDisplay.Text)).ToString();
                            if (resultado == 0) cmd.Parameters.AddWithValue("@FstNum", num1);
                            else cmd.Parameters.AddWithValue("@FstNum", resultado);
                            cmd.Parameters.AddWithValue("@Operando", operacion);
                            cmd.Parameters.AddWithValue("@SecNum ", num2);
                            cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            SqlCommand cmda1 = new SqlCommand("select FstNum , Operando, SecNum, Resultado from Historial", cn);

                            DataTable tabla1 = new DataTable();
                            SqlDataAdapter sda1 = new SqlDataAdapter(cmda1);
                            sda1.Fill(tabla1);
                            dtgvHistorial.DataSource = tabla1;
                            cmda1.ExecuteNonQuery();
                            cn.Close();
                            break;
                        case "*":
                            txtDisplay.Text = (resultado * Double.Parse(txtDisplay.Text)).ToString();
                            if (resultado == 0) cmd.Parameters.AddWithValue("@FstNum", num1);
                            else cmd.Parameters.AddWithValue("@FstNum", resultado);
                            cmd.Parameters.AddWithValue("@Operando", operacion);
                            cmd.Parameters.AddWithValue("@SecNum ", num2);
                            cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            SqlCommand cmda2 = new SqlCommand("select FstNum , Operando, SecNum, Resultado from Historial", cn);

                            DataTable tabla2 = new DataTable();
                            SqlDataAdapter sda2 = new SqlDataAdapter(cmda2);
                            sda2.Fill(tabla2);
                            dtgvHistorial.DataSource = tabla2;
                            cmda2.ExecuteNonQuery();

                            cn.Close();
                            break;
                        case "/":
                            txtDisplay.Text = (resultado / Double.Parse(txtDisplay.Text)).ToString();
                            if (resultado == 0) cmd.Parameters.AddWithValue("@FstNum", num1);
                            else cmd.Parameters.AddWithValue("@FstNum", resultado);
                            cmd.Parameters.AddWithValue("@Operando", operacion);
                            cmd.Parameters.AddWithValue("@SecNum ", num2);
                            cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            SqlCommand cmda3 = new SqlCommand("select FstNum , Operando, SecNum, Resultado from Historial", cn);

                            DataTable tabla3 = new DataTable();
                            SqlDataAdapter sda3 = new SqlDataAdapter(cmda3);
                            sda3.Fill(tabla3);
                            dtgvHistorial.DataSource = tabla3;
                            cmda3.ExecuteNonQuery();

                            cn.Close();
                            break;
                        case "%":
                            //txtDisplay.Text = (resultado / Double.Parse(txtDisplay.Text)).ToString();
                            
                            txtDisplay.Text = Convert.ToString((Double.Parse(num1) * Double.Parse(num2)) / 100);

                            if (conteo5 < 1) cmd.Parameters.AddWithValue("@FstNum", num1);
                            else cmd.Parameters.AddWithValue("@FstNum", resultado);
                            cmd.Parameters.AddWithValue("@Operando", operacion);
                            cmd.Parameters.AddWithValue("@SecNum ", num2);

                          

                            cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            conteo5++;
                            SqlCommand cmda5 = new SqlCommand("select FstNum , Operando, SecNum, Resultado from Historial", cn);

                            DataTable tabla5 = new DataTable();
                            SqlDataAdapter sda5 = new SqlDataAdapter(cmda5);
                            sda5.Fill(tabla5);
                            dtgvHistorial.DataSource = tabla5;
                            cmda5.ExecuteNonQuery();

                            cn.Close();
                            break;
                        default:
                            num2 = $"{txtDisplay.Text}";
                            txtDisplay2.Text = $"{txtDisplay.Text}= ";
                            break;
                    }

                    resultado = Double.Parse(txtDisplay.Text);
                    operacion = string.Empty;

                }

            }catch(Exception )
            {
                MessageBox.Show(" PRIMERO ELIGE UN NUMERO DEL TECLADO");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);

            if (txtDisplay.Text == string.Empty) txtDisplay.Text = "0";
        }


        private void btnOperacion_Click(object sender, EventArgs e)
        {
            

            SqlConnection cn = new SqlConnection(
                 ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            SqlCommand cmd = new SqlCommand(
            "Sp_GuardarOpe", cn);
            cn.Open();

            Button boton = (Button)sender;
            operacion= boton.Text;

            switch(operacion)
            {
                case "RaizCua":


                    //txtDisplay.Text = Convert.ToString(Math.Sqrt(Double.Parse(txtDisplay.Text)));
                    try
                    {

                        if (conteo < 1) cmd.Parameters.AddWithValue("@FstNum", num1);
                        else cmd.Parameters.AddWithValue("@FstNum", resultado);
                        //cmd.Parameters.AddWithValue("@FstNum", num1);

                        cmd.Parameters.AddWithValue("@Operando", operacion);
                        //cmd.Parameters.AddWithValue("@SecNum ", num2);

                        resultado = Math.Sqrt(Double.Parse(txtDisplay.Text));
                        txtDisplay.Text = Convert.ToString(resultado);

                        cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.ExecuteNonQuery();

                        conteo++;
                        SqlCommand cmda3 = new SqlCommand("select FstNum , Operando, Resultado from Historial", cn);

                        DataTable tabla3 = new DataTable();
                        SqlDataAdapter sda3 = new SqlDataAdapter(cmda3);
                        sda3.Fill(tabla3);
                        dtgvHistorial.DataSource = tabla3;
                        cmda3.ExecuteNonQuery();

                        cn.Close();

                    }catch(Exception )
                    {
                        MessageBox.Show(" DEBES ELEGIR UN NUMERO, Y LUEGO BUSCAS LA RAIZ CUADRADA\n");
                    }
                    
                    break;

                case "^2":
                    //txtDisplay.Text = Convert.ToString((Double.Parse(txtDisplay.Text)) * (Double.Parse(txtDisplay.Text)));

                    try
                    {
                        if (resultado == 0) cmd.Parameters.AddWithValue("@FstNum", num1);
                        else cmd.Parameters.AddWithValue("@FstNum", resultado);
                        cmd.Parameters.AddWithValue("@Operando", operacion);
                        // cmd.Parameters.AddWithValue("@SecNum ", num2);

                        resultado = (Double.Parse(txtDisplay.Text)) * (Double.Parse(txtDisplay.Text));
                        txtDisplay.Text = Convert.ToString(resultado);

                        cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        conteo1++;
                        SqlCommand cmda = new SqlCommand("select FstNum , Operando, Resultado from Historial", cn);

                        DataTable tabla = new DataTable();
                        SqlDataAdapter sda = new SqlDataAdapter(cmda);
                        sda.Fill(tabla);
                        dtgvHistorial.DataSource = tabla;
                        cmda.ExecuteNonQuery();
                        cn.Close();
                    }catch(Exception)
                    {
                        MessageBox.Show(" DEBES ELEGIR UN NUMERO PRIMERO \n" );
                    }
                    break;

                case "1/X":
                    //txtDisplay.Text = Convert.ToString(1.0/(Double.Parse(txtDisplay.Text)));

                    try
                    {
                        if (resultado == 0) cmd.Parameters.AddWithValue("@FstNum", num1);
                        else cmd.Parameters.AddWithValue("@FstNum", resultado);
                        cmd.Parameters.AddWithValue("@Operando", operacion);
                        //cmd.Parameters.AddWithValue("@SecNum ", num2);

                        resultado = 1.0 / (Double.Parse(txtDisplay.Text));
                        txtDisplay.Text = Convert.ToString(resultado);

                        cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        conteo2++;
                        SqlCommand cmda1 = new SqlCommand("select FstNum , Operando , Resultado from Historial", cn);

                        DataTable tabla1 = new DataTable();
                        SqlDataAdapter sda1 = new SqlDataAdapter(cmda1);
                        sda1.Fill(tabla1);
                        dtgvHistorial.DataSource = tabla1;
                        cmda1.ExecuteNonQuery();
                        cn.Close();
                    }catch(Exception )
                    {
                        MessageBox.Show(" DEBES ELEGIR UN NUMERO PRIMERO \n" );
                    }
                   
                    break;

                //case "%":
                //    //txtDisplay.Text = Convert.ToString((Double.Parse(txtDisplay.Text)/Convert.ToDouble(100)));
                //    try
                //    {
                //        if (resultado == 0) cmd.Parameters.AddWithValue("@FstNum", num1);
                //        else cmd.Parameters.AddWithValue("@FstNum", resultado);
                //        cmd.Parameters.AddWithValue("@Operando", operacion);
                //        // cmd.Parameters.AddWithValue("@SecNum ", num2);

                //        resultado = (Double.Parse(txtDisplay.Text) / Convert.ToDouble(100));
                //        txtDisplay.Text = Convert.ToString(resultado);

                //        cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.ExecuteNonQuery();
                //        conteo3++;
                //        SqlCommand cmda2 = new SqlCommand("select FstNum , Operando, Resultado from Historial", cn);

                //        DataTable tabla2 = new DataTable();
                //        SqlDataAdapter sda2 = new SqlDataAdapter(cmda2);
                //        sda2.Fill(tabla2);
                //        dtgvHistorial.DataSource = tabla2;
                //        cmda2.ExecuteNonQuery();

                //        cn.Close();
                //    }catch(Exception)
                //    {
                //        MessageBox.Show(" DEBES ELEGIR UN NUMERO PRIMERO \n" );
                //    }
                    //break;

                case "+-":
                    // txtDisplay.Text = Convert.ToString(-1*(Double.Parse(txtDisplay.Text)));

                    try
                    {
                        if (resultado == 0) cmd.Parameters.AddWithValue("@FstNum", num1);
                        else cmd.Parameters.AddWithValue("@FstNum", resultado);
                        cmd.Parameters.AddWithValue("@Operando", operacion);
                        // cmd.Parameters.AddWithValue("@SecNum ", num2);

                        resultado = -1 * (Double.Parse(txtDisplay.Text));
                        txtDisplay.Text = Convert.ToString(resultado);

                        cmd.Parameters.AddWithValue("@Resultado ", txtDisplay.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        conteo4++;
                        SqlCommand cmda4 = new SqlCommand("select FstNum , Operando, Resultado from Historial", cn);

                        DataTable tabla4 = new DataTable();
                        SqlDataAdapter sda4 = new SqlDataAdapter(cmda4);
                        sda4.Fill(tabla4);
                        dtgvHistorial.DataSource = tabla4;
                        cmda4.ExecuteNonQuery();

                        cn.Close();
                    }catch(Exception )
                    {
                        MessageBox.Show(" DEBES ELEGIR UN NUMERO PRIMERO \n");
                    }
                    break;
                default:
                    break;

            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            panel1.Visible =true;

            SqlConnection cn = new SqlConnection(
              ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            SqlCommand cmd = new SqlCommand(
            "select FstNum , Operando, SecNum, Resultado from Historial", cn );
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            dtgvHistorial.DataSource = tabla;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnDeleteHisto_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
               ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);

            SqlCommand cmd = new SqlCommand(
            "truncate table Historial", cn
                );
            DataTable tabla = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tabla);
            dtgvHistorial.DataSource = tabla;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            try
            {


                
                Button boton = (Button)sender;


                if (txtDisplay.Text != "0" || boton.Text != null)
                {
                    
                    if (num1 == null || txtDisplay.Text =="0") 
                    {
                        num1 = txtDisplay.Text = boton.Text;
                       
                     
                    }

                    

                     else num2 = txtDisplay.Text += boton.Text;





                }



            }
            catch(Exception )
            {
                MessageBox.Show(" DEBES ELEGIR UN NUMERO DEL TECLADO ");
            }
        }


        


          

           
    }
}
