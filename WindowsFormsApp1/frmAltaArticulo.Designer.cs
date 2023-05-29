namespace WindowsFormsApp1
{
    partial class frmAltaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaArticulo));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCateoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblRequerido2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCodigo.Location = new System.Drawing.Point(112, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombre.Location = new System.Drawing.Point(106, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPrecio.Location = new System.Drawing.Point(117, 204);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 17);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(180, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(134, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(180, 204);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(134, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Lavender;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.Location = new System.Drawing.Point(122, 499);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Lavender;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(239, 499);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCateoria
            // 
            this.lblCateoria.AutoSize = true;
            this.lblCateoria.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateoria.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCateoria.Location = new System.Drawing.Point(97, 129);
            this.lblCateoria.Name = "lblCateoria";
            this.lblCateoria.Size = new System.Drawing.Size(71, 17);
            this.lblCateoria.TabIndex = 8;
            this.lblCateoria.Text = "Categoría:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMarca.Location = new System.Drawing.Point(119, 167);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(49, 17);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(180, 129);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(134, 21);
            this.cmbCategoria.TabIndex = 3;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(180, 167);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(134, 21);
            this.cmbMarca.TabIndex = 4;
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackColor = System.Drawing.Color.White;
            this.pbArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbArticulos.Location = new System.Drawing.Point(122, 284);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(192, 195);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 13;
            this.pbArticulos.TabStop = false;
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(180, 240);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(134, 20);
            this.txtImagenUrl.TabIndex = 6;
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUrl.Location = new System.Drawing.Point(131, 240);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 17);
            this.lblUrl.TabIndex = 14;
            this.lblUrl.Text = "URL:";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.Lavender;
            this.btnCargarImagen.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.btnCargarImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnCargarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargarImagen.Location = new System.Drawing.Point(331, 375);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(22, 23);
            this.btnCargarImagen.TabIndex = 7;
            this.btnCargarImagen.Text = "+";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(180, 94);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(134, 20);
            this.txtDescripción.TabIndex = 2;
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDescripción.Location = new System.Drawing.Point(84, 94);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(84, 17);
            this.lblDescripción.TabIndex = 16;
            this.lblDescripción.Text = "Descripción:";
            // 
            // lblRequerido2
            // 
            this.lblRequerido2.AutoSize = true;
            this.lblRequerido2.Location = new System.Drawing.Point(320, 208);
            this.lblRequerido2.Name = "lblRequerido2";
            this.lblRequerido2.Size = new System.Drawing.Size(65, 13);
            this.lblRequerido2.TabIndex = 18;
            this.lblRequerido2.Text = "*(obligatorio)";
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(429, 561);
            this.Controls.Add(this.lblRequerido2);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.lblDescripción);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCateoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 600);
            this.MinimumSize = new System.Drawing.Size(445, 600);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Artículo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCateoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label lblRequerido2;
    }
}