using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//manda llamar la clase negocios 
using Negocios;

namespace PV1._0
{
    public partial class Form1 : Form
    {

        ConexionSQLN cn = new ConexionSQLN();

        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_salida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnt_entrar_Load(object sender, EventArgs e)
        {

        }

        private void bnt_entrar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txt_usuario.Text, txt_contrasena.Text) == 1)
            {
                //MessageBox.Show("El usuario a sido encontrado");

                this.Hide();

                Ventana v1 = new Ventana();
                v1.Show();


            }
            else
            {
                MessageBox.Show("El usuario no ha sido encontrado");
            }

        }
    }
}
