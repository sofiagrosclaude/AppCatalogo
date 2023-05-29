namespace WindowsFormsApp1
{
    partial class frmArticulo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar2 = new System.Windows.Forms.Label();
            this.cmbCualidad = new System.Windows.Forms.ComboBox();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeight = 27;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(257, 107);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.MaximumSize = new System.Drawing.Size(545, 139);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(545, 139);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.RowHeadersWidth = 39;
            this.dgvArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateGray;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Lavender;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvArticulos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(545, 139);
            this.dgvArticulos.StandardTab = true;
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellEnter);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lavender;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(484, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 31);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Lavender;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.Location = new System.Drawing.Point(565, 253);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 31);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.BackColor = System.Drawing.Color.Lavender;
            this.btnEliminarFisico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarFisico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFisico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarFisico.Location = new System.Drawing.Point(646, 253);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(75, 31);
            this.btnEliminarFisico.TabIndex = 8;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = false;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.Lavender;
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetalle.Location = new System.Drawing.Point(467, 511);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(88, 31);
            this.btnDetalle.TabIndex = 9;
            this.btnDetalle.Text = "Ver Detalles";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 564);
            this.panel1.TabIndex = 7;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::WindowsFormsApp1.Properties.Resources.Logo_ArticulosApp;
            this.pbLogo.Location = new System.Drawing.Point(11, 82);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(137, 139);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detallesToolStripMenuItem,
            this.soporteToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // detallesToolStripMenuItem
            // 
            this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            this.detallesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.detallesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.detallesToolStripMenuItem.Text = "Detalles";
            this.detallesToolStripMenuItem.Click += new System.EventHandler(this.detallesToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.soporteToolStripMenuItem.Text = "About";
            this.soporteToolStripMenuItem.Click += new System.EventHandler(this.soporteToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(933, 24);
            this.menu.TabIndex = 8;
            this.menu.Text = "menu";
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackColor = System.Drawing.Color.White;
            this.pbArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbArticulos.Location = new System.Drawing.Point(257, 283);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(204, 259);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 1;
            this.pbArticulos.TabStop = false;
            this.pbArticulos.SizeModeChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            this.pbArticulos.Resize += new System.EventHandler(this.frmArticulo_Load);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBuscar.Location = new System.Drawing.Point(257, 75);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(53, 17);
            this.lblBuscar.TabIndex = 9;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(312, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(84, 25);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar2
            // 
            this.lblBuscar2.AutoSize = true;
            this.lblBuscar2.Location = new System.Drawing.Point(420, 76);
            this.lblBuscar2.Name = "lblBuscar2";
            this.lblBuscar2.Size = new System.Drawing.Size(75, 17);
            this.lblBuscar2.TabIndex = 12;
            this.lblBuscar2.Text = "Buscar por:";
            // 
            // cmbCualidad
            // 
            this.cmbCualidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCualidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCualidad.FormattingEnabled = true;
            this.cmbCualidad.Location = new System.Drawing.Point(492, 72);
            this.cmbCualidad.Name = "cmbCualidad";
            this.cmbCualidad.Size = new System.Drawing.Size(85, 25);
            this.cmbCualidad.TabIndex = 1;
            this.cmbCualidad.SelectedIndexChanged += new System.EventHandler(this.cmbSeleccion_SelectedIndexChanged);
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(583, 72);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(101, 25);
            this.cmbCriterio.TabIndex = 2;
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.Location = new System.Drawing.Point(690, 72);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(66, 25);
            this.txtBuscar2.TabIndex = 3;
            // 
            // btnIr
            // 
            this.btnIr.BackColor = System.Drawing.Color.Lavender;
            this.btnIr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnIr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnIr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIr.Location = new System.Drawing.Point(762, 69);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(40, 31);
            this.btnIr.TabIndex = 4;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = false;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Lavender;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.Location = new System.Drawing.Point(727, 253);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtBuscar2);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.cmbCualidad);
            this.Controls.Add(this.lblBuscar2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(949, 627);
            this.MinimumSize = new System.Drawing.Size(949, 627);
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo Artículos";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar2;
        private System.Windows.Forms.ComboBox cmbCualidad;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.TextBox txtBuscar2;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

