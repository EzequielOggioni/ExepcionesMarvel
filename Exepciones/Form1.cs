using Entidades;
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

namespace Exepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personaje per1 = new Enemigo("Enemigo");
            Personaje per2 = new Enemigo("Enemigo1");
            Personaje per4 = new Enemigo("Enemigo2");

            Personaje per3 = new Advenger("Octavio");
            string salida="";
            
            try
            {
                
                Marvel.AgregarBichito = per1;
                Marvel.AgregarBichito = per2;
                Marvel.AgregarBichito = per3;
                
                salida = Marvel.Mostrar();
            }
            catch (AgregarBichitoException ex )
            {
                
                salida = ex.Message;
            }
            catch(Exception tdd)
            {

            }
          

            
            MessageBox.Show(salida);




        }
    }
}
