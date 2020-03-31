﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_us
{
    public partial class frm_subcategorias : Form
    {
        //Se usa para consultar la tabla
        public static DataRow Fila;

        //Tabla que uso para guardar los datos de las consultas
        public static DataTable Tabla = new DataTable();

        //Datos generales del usuario
        public int id, tipo;

        //Sirve para ver la contraseña
        int ver = 0;

        //Mas de los datos
        public string nombre, apellido, usuario, contraseña;
        public void llenardatos(string tipo)
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(tipo));
            Tabla = this.tb_subtipoTableAdapter.ObtenerDatos(id_tipos);
            comboBox1.Items.Clear();
            foreach (DataRow row in Tabla.Rows)
            {
                comboBox1.Items.Add(row["nombre"]);                
            }
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                
            }
            txtNombre.Text = comboBox1.Text;
        }
        public frm_subcategorias()
        {
            InitializeComponent();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNombre.Text == "Nombre")
                {
                    MessageBox.Show("Existe un error");
                }
                else
                {
                    this.tb_subtipoTableAdapter.agregar_subtipo(txtNombre.Text, this.tb_tipoTableAdapter.Consultar_id(comboBox2.Text));
                    MessageBox.Show("Ingresado Correctamente");
                    txtNombre.Text = "Nombre";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Existe un error");
            }
        }
        private void tb_subtipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_subtipoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asiloDataSet);
        }
        private void frm_subcategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_subtipo' Puede moverla o quitarla según sea necesario.
            this.tb_subtipoTableAdapter.Fill(this.db_asiloDataSet.tb_subtipo);
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == comboBox1.Text)
            {
                int id_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox2.Text));
                int id_subtipo = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipo, comboBox1.Text));
                this.tb_subtipoTableAdapter.borrar_subtipo(id_subtipo);
                llenardatos(comboBox2.Text);
            } else
            {

            }

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre" || txtNombre.Text == comboBox1.Text)
            {
                txtNombre.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = comboBox1.Text;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.TextLength == 0)
            {
                if(checkBox2.Checked == true)
                {
                    txtNombre.Text = comboBox1.Text;
                }else
                {
                    txtNombre.Text = "Nombre";
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == comboBox1.Text)
            {

            }
            else
            {
                int id_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox2.Text));
                int id_subtipo = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipo, comboBox1.Text));
                int existe = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_si_existe(txtNombre.Text, id_tipo));
                if (existe == 0)
                {
                    this.tb_subtipoTableAdapter.modificar_subtipo(txtNombre.Text, id_subtipo);
                    MessageBox.Show("Modificado Correctamente");
                    llenardatos(comboBox2.Text);
                }
                else
                {
                    MessageBox.Show("Error ya existe el que quiere Modificar");
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatos(comboBox2.Text);
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //define si se agrega o ya esta agregado, true=nuevo false=ya existe

            if (checkBox2.Checked == true)
            {

                comboBox1_nombre.Visible = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnAgregar.Enabled = false;
                llenardatos(comboBox2.Text);

            }
            else
            {
                comboBox1_nombre.Visible = false;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtNombre.Text = "Nombre";
            }

        }
        private void comboBox1_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
