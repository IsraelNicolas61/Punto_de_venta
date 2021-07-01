using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace PV1._0
{
    public partial class FormUsers : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public FormUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.InsertarUsuario(txt_nom.Text, txt_apellido.Text, txt_user.Text, txt_pass.Text);
            dataGridView1.DataSource =cn.ConsultaDT();


        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bnt_EU_Click(object sender, EventArgs e)
        {
            cn.EliminarUsuario(txt_user.Text);
            dataGridView1.DataSource = cn.ConsultaDT();
            

        }

        private void btn_MU_Click(object sender, EventArgs e)
        {
            cn.ModificarUsuario(txt_nom.Text, txt_apellido.Text, txt_user.Text, txt_pass.Text);
            dataGridView1.DataSource = cn.ConsultaDT();
            
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
