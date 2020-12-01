using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Tarea_1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Conectar_Click(object sender, EventArgs e) {

            String CadenadeDeConeccion = @"Data Source = (LocalDB)\MSSQLLocalDB; Integrated Security = True";
            
        using (SqlConnection sqlConnection = new SqlConnection(CadenadeDeConeccion)) {
            try {
                sqlConnection.Open();

                MessageBox.Show("Conectado a : " + sqlConnection.DataSource);
           
            } catch ( Exception Ex) {

                MessageBox.Show( Ex.Message ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            } finally { 
                    
                    sqlConnection.Close();
                    MessageBox.Show("Desconectado de : " + sqlConnection.DataSource);
                    
                }

        }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
