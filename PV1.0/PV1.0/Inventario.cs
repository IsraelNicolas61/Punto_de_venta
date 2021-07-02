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
    public partial class Inventario : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public Inventario()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaDTI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void btn_almacenar_Click(object sender, EventArgs e)
        {
            cn.InsertarInventario(txt_producto.Text, txt_categoria.Text, txt_precio.Text, txt_cantidad.Text);
            dataGridView1.DataSource = cn.ConsultaDTI();
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            cn.ModificarInventario(txt_producto.Text, txt_categoria.Text, txt_precio.Text, txt_cantidad.Text);
            dataGridView1.DataSource = cn.ConsultaDTI();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            cn.EliminarInventario(txt_producto.Text);
            dataGridView1.DataSource = cn.ConsultaDTI();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
