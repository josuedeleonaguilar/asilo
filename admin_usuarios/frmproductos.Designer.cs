namespace admin_us
{
    partial class frmproductos
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_objetos = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox_objetos = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1_nombre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_subtipos = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.comboBox_tipos = new System.Windows.Forms.ComboBox();
            this.tbtipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_asiloDataSet = new admin_us.db_asiloDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox_pesos = new System.Windows.Forms.ComboBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tb_tipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_tipoTableAdapter();
            this.tbsubtipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_subtipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_subtipoTableAdapter();
            this.tbobjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_objetoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_objetoTableAdapter();
            this.tb_inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_inventarioTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_inventarioTableAdapter();
            this.tableAdapterManager = new admin_us.db_asiloDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panel_objetos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.comboBox1_nombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbsubtipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbobjetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_objetos);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBox1_nombre);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 679);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(450, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sub categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(464, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Categoria";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox2.Location = new System.Drawing.Point(229, 185);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(199, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Modificar";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(279, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "INGRESO Y MODIFICACIÓN DE PRODUCTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(694, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nuevo";
            // 
            // panel_objetos
            // 
            this.panel_objetos.BackColor = System.Drawing.Color.White;
            this.panel_objetos.Controls.Add(this.label6);
            this.panel_objetos.Controls.Add(this.panel3);
            this.panel_objetos.Location = new System.Drawing.Point(319, 299);
            this.panel_objetos.Name = "panel_objetos";
            this.panel_objetos.Size = new System.Drawing.Size(369, 66);
            this.panel_objetos.TabIndex = 30;
            this.panel_objetos.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(148, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Producto";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.comboBox_objetos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 36);
            this.panel3.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox3.Location = new System.Drawing.Point(5, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox_objetos
            // 
            this.comboBox_objetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_objetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_objetos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_objetos.FormattingEnabled = true;
            this.comboBox_objetos.Location = new System.Drawing.Point(34, 6);
            this.comboBox_objetos.Name = "comboBox_objetos";
            this.comboBox_objetos.Size = new System.Drawing.Size(332, 28);
            this.comboBox_objetos.TabIndex = 20;
            this.comboBox_objetos.SelectedIndexChanged += new System.EventHandler(this.comboBox_objetos_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox1.Location = new System.Drawing.Point(713, 458);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1_nombre
            // 
            this.comboBox1_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.comboBox1_nombre.Controls.Add(this.pictureBox1);
            this.comboBox1_nombre.Controls.Add(this.comboBox_subtipos);
            this.comboBox1_nombre.Location = new System.Drawing.Point(320, 247);
            this.comboBox1_nombre.Name = "comboBox1_nombre";
            this.comboBox1_nombre.Size = new System.Drawing.Size(369, 44);
            this.comboBox1_nombre.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox1.Location = new System.Drawing.Point(5, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_subtipos
            // 
            this.comboBox_subtipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subtipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_subtipos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_subtipos.FormattingEnabled = true;
            this.comboBox_subtipos.Location = new System.Drawing.Point(34, 8);
            this.comboBox_subtipos.Name = "comboBox_subtipos";
            this.comboBox_subtipos.Size = new System.Drawing.Size(332, 28);
            this.comboBox_subtipos.TabIndex = 20;
            this.comboBox_subtipos.SelectedIndexChanged += new System.EventHandler(this.comboBox_subtipos_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.comboBox_tipos);
            this.panel7.Location = new System.Drawing.Point(319, 163);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(369, 44);
            this.panel7.TabIndex = 28;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox5.Location = new System.Drawing.Point(6, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // comboBox_tipos
            // 
            this.comboBox_tipos.DataSource = this.tbtipoBindingSource;
            this.comboBox_tipos.DisplayMember = "nombre";
            this.comboBox_tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_tipos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_tipos.FormattingEnabled = true;
            this.comboBox_tipos.Location = new System.Drawing.Point(34, 8);
            this.comboBox_tipos.Name = "comboBox_tipos";
            this.comboBox_tipos.Size = new System.Drawing.Size(332, 28);
            this.comboBox_tipos.TabIndex = 20;
            this.comboBox_tipos.ValueMember = "nombre";
            this.comboBox_tipos.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipos_SelectedIndexChanged);
            // 
            // tbtipoBindingSource
            // 
            this.tbtipoBindingSource.DataMember = "tb_tipo";
            this.tbtipoBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // db_asiloDataSet
            // 
            this.db_asiloDataSet.DataSetName = "db_asiloDataSet";
            this.db_asiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.PictureBox4);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Location = new System.Drawing.Point(319, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 44);
            this.panel2.TabIndex = 22;
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox4.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.PictureBox4.Location = new System.Drawing.Point(6, 10);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(25, 25);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox4.TabIndex = 8;
            this.PictureBox4.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(37, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(302, 19);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.comboBox_pesos);
            this.panel4.Controls.Add(this.txtPesos);
            this.panel4.Location = new System.Drawing.Point(319, 446);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 44);
            this.panel4.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::admin_us.Properties.Resources.person_6x;
            this.pictureBox2.Location = new System.Drawing.Point(6, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox_pesos
            // 
            this.comboBox_pesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_pesos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_pesos.FormattingEnabled = true;
            this.comboBox_pesos.Location = new System.Drawing.Point(33, 8);
            this.comboBox_pesos.Name = "comboBox_pesos";
            this.comboBox_pesos.Size = new System.Drawing.Size(332, 28);
            this.comboBox_pesos.TabIndex = 21;
            // 
            // txtPesos
            // 
            this.txtPesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtPesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesos.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesos.Location = new System.Drawing.Point(37, 12);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(302, 19);
            this.txtPesos.TabIndex = 1;
            this.txtPesos.Text = "Peso";
            this.txtPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesos.Click += new System.EventHandler(this.txtUsuario_Click);
            this.txtPesos.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnModificar);
            this.panel6.Controls.Add(this.btnAgregar);
            this.panel6.Controls.Add(this.btnEliminar);
            this.panel6.Location = new System.Drawing.Point(319, 507);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(369, 40);
            this.panel6.TabIndex = 26;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(199)))), ((int)(((byte)(56)))));
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(0, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(115, 40);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(127, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 40);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(254, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 40);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tb_tipoTableAdapter
            // 
            this.tb_tipoTableAdapter.ClearBeforeFill = true;
            // 
            // tbsubtipoBindingSource
            // 
            this.tbsubtipoBindingSource.DataMember = "tb_subtipo";
            this.tbsubtipoBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_subtipoTableAdapter
            // 
            this.tb_subtipoTableAdapter.ClearBeforeFill = true;
            // 
            // tbobjetoBindingSource
            // 
            this.tbobjetoBindingSource.DataMember = "tb_objeto";
            this.tbobjetoBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_objetoTableAdapter
            // 
            this.tb_objetoTableAdapter.ClearBeforeFill = true;
            // 
            // tb_inventarioBindingSource
            // 
            this.tb_inventarioBindingSource.DataMember = "tb_inventario";
            this.tb_inventarioBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_inventarioTableAdapter
            // 
            this.tb_inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_bodegaTableAdapter = null;
            this.tableAdapterManager.tb_donacionTableAdapter = null;
            this.tableAdapterManager.tb_ingresosTableAdapter = null;
            this.tableAdapterManager.tb_inventarioTableAdapter = this.tb_inventarioTableAdapter;
            this.tableAdapterManager.tb_objetoTableAdapter = this.tb_objetoTableAdapter;
            this.tableAdapterManager.tb_reportesTableAdapter = null;
            this.tableAdapterManager.tb_salidasTableAdapter = null;
            this.tableAdapterManager.tb_subtipoTableAdapter = this.tb_subtipoTableAdapter;
            this.tableAdapterManager.tb_tipoTableAdapter = this.tb_tipoTableAdapter;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = admin_us.db_asiloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 679);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmproductos";
            this.Load += new System.EventHandler(this.frmproductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_objetos.ResumeLayout(false);
            this.panel_objetos.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.comboBox1_nombre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbsubtipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbobjetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox PictureBox4;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Button btnModificar;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox_tipos;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox_pesos;
        private System.Windows.Forms.Panel comboBox1_nombre;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_subtipos;
        private db_asiloDataSet db_asiloDataSet;
        private System.Windows.Forms.BindingSource tbtipoBindingSource;
        private db_asiloDataSetTableAdapters.tb_tipoTableAdapter tb_tipoTableAdapter;
        private System.Windows.Forms.BindingSource tbsubtipoBindingSource;
        private db_asiloDataSetTableAdapters.tb_subtipoTableAdapter tb_subtipoTableAdapter;
        private System.Windows.Forms.BindingSource tbobjetoBindingSource;
        private db_asiloDataSetTableAdapters.tb_objetoTableAdapter tb_objetoTableAdapter;
        private System.Windows.Forms.Panel panel_objetos;
        internal System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox_objetos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tb_inventarioBindingSource;
        private db_asiloDataSetTableAdapters.tb_inventarioTableAdapter tb_inventarioTableAdapter;
        private db_asiloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
    }
}