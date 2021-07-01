
namespace PV1._0
{
    partial class FormUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_NU = new System.Windows.Forms.Button();
            this.btn_MU = new System.Windows.Forms.Button();
            this.bnt_EU = new System.Windows.Forms.Button();
            this.bnt_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pass);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(389, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de acceso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Contraseña";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(12, 364);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(160, 20);
            this.txt_nom.TabIndex = 4;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(178, 364);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(179, 20);
            this.txt_apellido.TabIndex = 5;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(8, 35);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(126, 20);
            this.txt_user.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(150, 35);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(164, 20);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // btn_NU
            // 
            this.btn_NU.Location = new System.Drawing.Point(9, 404);
            this.btn_NU.Name = "btn_NU";
            this.btn_NU.Size = new System.Drawing.Size(100, 22);
            this.btn_NU.TabIndex = 6;
            this.btn_NU.Text = "Nuevo Usuario";
            this.btn_NU.UseVisualStyleBackColor = true;
            this.btn_NU.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_MU
            // 
            this.btn_MU.Location = new System.Drawing.Point(120, 404);
            this.btn_MU.Name = "btn_MU";
            this.btn_MU.Size = new System.Drawing.Size(102, 21);
            this.btn_MU.TabIndex = 7;
            this.btn_MU.Text = "Modificar Usuario";
            this.btn_MU.UseVisualStyleBackColor = true;
            this.btn_MU.Click += new System.EventHandler(this.btn_MU_Click);
            // 
            // bnt_EU
            // 
            this.bnt_EU.Location = new System.Drawing.Point(231, 404);
            this.bnt_EU.Name = "bnt_EU";
            this.bnt_EU.Size = new System.Drawing.Size(98, 21);
            this.bnt_EU.TabIndex = 8;
            this.bnt_EU.Text = "Eliminar Usuario";
            this.bnt_EU.UseVisualStyleBackColor = true;
            this.bnt_EU.Click += new System.EventHandler(this.bnt_EU_Click);
            // 
            // bnt_cerrar
            // 
            this.bnt_cerrar.Location = new System.Drawing.Point(503, 424);
            this.bnt_cerrar.Name = "bnt_cerrar";
            this.bnt_cerrar.Size = new System.Drawing.Size(61, 20);
            this.bnt_cerrar.TabIndex = 9;
            this.bnt_cerrar.Text = "Cerrar";
            this.bnt_cerrar.UseVisualStyleBackColor = true;
            this.bnt_cerrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_cerrar);
            this.Controls.Add(this.bnt_EU);
            this.Controls.Add(this.btn_MU);
            this.Controls.Add(this.btn_NU);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUsers";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Button btn_NU;
        private System.Windows.Forms.Button btn_MU;
        private System.Windows.Forms.Button bnt_EU;
        private System.Windows.Forms.Button bnt_cerrar;
    }
}