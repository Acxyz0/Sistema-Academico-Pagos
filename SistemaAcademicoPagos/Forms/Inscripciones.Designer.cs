namespace SistemaAcademicoPagos.Forms
{
    partial class Inscripciones
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTelefonoEncargado = new System.Windows.Forms.Label();
            this.lblParentesco = new System.Windows.Forms.Label();
            this.lblFechaInscripcion = new System.Windows.Forms.Label();
            this.dtFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.txtObservaciones = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtEncargado = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.btnGuardar = new SistemaAcademicoPagos.Controls.AcButton();
            this.txtTelefonoEncargado = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtParentesco = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtTelefono = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtDireccion = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtGenero = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtEdad = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtSeccion = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtGrado = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtAnio = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtApellido = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.txtNombre = new SistemaAcademicoPagos.Controls.AcTextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(24, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRES";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.White;
            this.lblNombreCompleto.Location = new System.Drawing.Point(0, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(968, 56);
            this.lblNombreCompleto.TabIndex = 3;
            this.lblNombreCompleto.Text = "NombrePrueba";
            this.lblNombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(24, 152);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(99, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "APELLIDOS";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.White;
            this.lblAnio.Location = new System.Drawing.Point(192, 560);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(43, 20);
            this.lblAnio.TabIndex = 7;
            this.lblAnio.Text = "AÑO";
            // 
            // cbCarrera
            // 
            this.cbCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.cbCarrera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrera.ForeColor = System.Drawing.Color.White;
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Items.AddRange(new object[] {
            "Operador",
            "Programador",
            "Autocad"});
            this.cbCarrera.Location = new System.Drawing.Point(24, 264);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(440, 28);
            this.cbCarrera.TabIndex = 2;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.ForeColor = System.Drawing.Color.White;
            this.lblCarrera.Location = new System.Drawing.Point(24, 232);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(89, 20);
            this.lblCarrera.TabIndex = 9;
            this.lblCarrera.Text = "CARRERA";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.ForeColor = System.Drawing.Color.White;
            this.lblGrado.Location = new System.Drawing.Point(24, 312);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(69, 20);
            this.lblGrado.TabIndex = 10;
            this.lblGrado.Text = "GRADO";
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.ForeColor = System.Drawing.Color.White;
            this.lblSeccion.Location = new System.Drawing.Point(256, 312);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(81, 20);
            this.lblSeccion.TabIndex = 11;
            this.lblSeccion.Text = "SECCIÓN";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.CalendarForeColor = System.Drawing.Color.White;
            this.dtFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.dtFechaNacimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.dtFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.dtFechaNacimiento.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.dtFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaNacimiento.Location = new System.Drawing.Point(24, 424);
            this.dtFechaNacimiento.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(440, 25);
            this.dtFechaNacimiento.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(24, 392);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(194, 20);
            this.lblFechaNacimiento.TabIndex = 15;
            this.lblFechaNacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(24, 472);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 20);
            this.lblEdad.TabIndex = 16;
            this.lblEdad.Text = "EDAD";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(256, 472);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(79, 20);
            this.lblGenero.TabIndex = 17;
            this.lblGenero.Text = "GÉNERO";
            // 
            // lblTelefonoEncargado
            // 
            this.lblTelefonoEncargado.AutoSize = true;
            this.lblTelefonoEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoEncargado.ForeColor = System.Drawing.Color.White;
            this.lblTelefonoEncargado.Location = new System.Drawing.Point(736, 312);
            this.lblTelefonoEncargado.Name = "lblTelefonoEncargado";
            this.lblTelefonoEncargado.Size = new System.Drawing.Size(94, 20);
            this.lblTelefonoEncargado.TabIndex = 33;
            this.lblTelefonoEncargado.Text = "TELÉFONO";
            // 
            // lblParentesco
            // 
            this.lblParentesco.AutoSize = true;
            this.lblParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentesco.ForeColor = System.Drawing.Color.White;
            this.lblParentesco.Location = new System.Drawing.Point(504, 312);
            this.lblParentesco.Name = "lblParentesco";
            this.lblParentesco.Size = new System.Drawing.Size(118, 20);
            this.lblParentesco.TabIndex = 32;
            this.lblParentesco.Text = "PARENTESCO";
            // 
            // lblFechaInscripcion
            // 
            this.lblFechaInscripcion.AutoSize = true;
            this.lblFechaInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInscripcion.ForeColor = System.Drawing.Color.White;
            this.lblFechaInscripcion.Location = new System.Drawing.Point(504, 472);
            this.lblFechaInscripcion.Name = "lblFechaInscripcion";
            this.lblFechaInscripcion.Size = new System.Drawing.Size(199, 20);
            this.lblFechaInscripcion.TabIndex = 31;
            this.lblFechaInscripcion.Text = "FECHA DE INSCRIPCIÓN";
            // 
            // dtFechaInscripcion
            // 
            this.dtFechaInscripcion.CalendarForeColor = System.Drawing.Color.White;
            this.dtFechaInscripcion.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.dtFechaInscripcion.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.dtFechaInscripcion.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.dtFechaInscripcion.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.dtFechaInscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFechaInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInscripcion.Location = new System.Drawing.Point(504, 504);
            this.dtFechaInscripcion.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFechaInscripcion.Name = "dtFechaInscripcion";
            this.dtFechaInscripcion.Size = new System.Drawing.Size(440, 25);
            this.dtFechaInscripcion.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(736, 152);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 20);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Text = "ESTADO";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(504, 152);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(94, 20);
            this.lblTelefono.TabIndex = 26;
            this.lblTelefono.Text = "TELÉFONO";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(504, 72);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(99, 20);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "DIRECCIÓN";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.cbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.White;
            this.cbEstado.ItemHeight = 20;
            this.cbEstado.Items.AddRange(new object[] {
            "Autocad",
            "Operador",
            "Programador"});
            this.cbEstado.Location = new System.Drawing.Point(736, 184);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(7);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(210, 28);
            this.cbEstado.TabIndex = 10;
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncargado.ForeColor = System.Drawing.Color.White;
            this.lblEncargado.Location = new System.Drawing.Point(504, 232);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(113, 20);
            this.lblEncargado.TabIndex = 41;
            this.lblEncargado.Text = "ENCARGADO";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtObservaciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtObservaciones.BorderFocusColor = System.Drawing.Color.White;
            this.txtObservaciones.BorderSize = 4;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.White;
            this.txtObservaciones.Location = new System.Drawing.Point(504, 392);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Names = "txtNombre";
            this.txtObservaciones.Padding = new System.Windows.Forms.Padding(7);
            this.txtObservaciones.PasswordChar = false;
            this.txtObservaciones.Size = new System.Drawing.Size(440, 67);
            this.txtObservaciones.TabIndex = 14;
            this.txtObservaciones.Tag = "Observaciones";
            this.txtObservaciones.Texts = "";
            this.txtObservaciones.UnderlinedStyle = true;
            // 
            // txtEncargado
            // 
            this.txtEncargado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtEncargado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtEncargado.BorderFocusColor = System.Drawing.Color.White;
            this.txtEncargado.BorderSize = 4;
            this.txtEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncargado.ForeColor = System.Drawing.Color.White;
            this.txtEncargado.Location = new System.Drawing.Point(504, 264);
            this.txtEncargado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEncargado.Multiline = false;
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Names = "txtNombre";
            this.txtEncargado.Padding = new System.Windows.Forms.Padding(7);
            this.txtEncargado.PasswordChar = false;
            this.txtEncargado.Size = new System.Drawing.Size(440, 35);
            this.txtEncargado.TabIndex = 11;
            this.txtEncargado.Texts = "";
            this.txtEncargado.UnderlinedStyle = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 15;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(736, 552);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Names = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(210, 35);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtTelefonoEncargado
            // 
            this.txtTelefonoEncargado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefonoEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtTelefonoEncargado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtTelefonoEncargado.BorderFocusColor = System.Drawing.Color.White;
            this.txtTelefonoEncargado.BorderSize = 4;
            this.txtTelefonoEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEncargado.ForeColor = System.Drawing.Color.White;
            this.txtTelefonoEncargado.Location = new System.Drawing.Point(736, 344);
            this.txtTelefonoEncargado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefonoEncargado.Multiline = false;
            this.txtTelefonoEncargado.Name = "txtTelefonoEncargado";
            this.txtTelefonoEncargado.Names = "txtNombre";
            this.txtTelefonoEncargado.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefonoEncargado.PasswordChar = false;
            this.txtTelefonoEncargado.Size = new System.Drawing.Size(210, 35);
            this.txtTelefonoEncargado.TabIndex = 13;
            this.txtTelefonoEncargado.Texts = "";
            this.txtTelefonoEncargado.UnderlinedStyle = true;
            // 
            // txtParentesco
            // 
            this.txtParentesco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtParentesco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtParentesco.BorderFocusColor = System.Drawing.Color.White;
            this.txtParentesco.BorderSize = 4;
            this.txtParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentesco.ForeColor = System.Drawing.Color.White;
            this.txtParentesco.Location = new System.Drawing.Point(504, 344);
            this.txtParentesco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtParentesco.Multiline = false;
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.Names = "txtNombre";
            this.txtParentesco.Padding = new System.Windows.Forms.Padding(7);
            this.txtParentesco.PasswordChar = false;
            this.txtParentesco.Size = new System.Drawing.Size(210, 35);
            this.txtParentesco.TabIndex = 12;
            this.txtParentesco.Texts = "";
            this.txtParentesco.UnderlinedStyle = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.White;
            this.txtTelefono.BorderSize = 4;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(504, 184);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Names = "txtNombre";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.Size = new System.Drawing.Size(210, 35);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.White;
            this.txtDireccion.BorderSize = 4;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(504, 104);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Names = "txtNombre";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.Size = new System.Drawing.Size(440, 35);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlinedStyle = true;
            // 
            // txtGenero
            // 
            this.txtGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtGenero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtGenero.BorderFocusColor = System.Drawing.Color.White;
            this.txtGenero.BorderSize = 4;
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.ForeColor = System.Drawing.Color.White;
            this.txtGenero.Location = new System.Drawing.Point(256, 504);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGenero.Multiline = false;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Names = "txtNombre";
            this.txtGenero.Padding = new System.Windows.Forms.Padding(7);
            this.txtGenero.PasswordChar = false;
            this.txtGenero.Size = new System.Drawing.Size(210, 35);
            this.txtGenero.TabIndex = 7;
            this.txtGenero.Texts = "";
            this.txtGenero.UnderlinedStyle = true;
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtEdad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtEdad.BorderFocusColor = System.Drawing.Color.White;
            this.txtEdad.BorderSize = 4;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.White;
            this.txtEdad.Location = new System.Drawing.Point(24, 504);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEdad.Multiline = false;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Names = "txtNombre";
            this.txtEdad.Padding = new System.Windows.Forms.Padding(7);
            this.txtEdad.PasswordChar = false;
            this.txtEdad.Size = new System.Drawing.Size(210, 35);
            this.txtEdad.TabIndex = 6;
            this.txtEdad.Texts = "";
            this.txtEdad.UnderlinedStyle = true;
            // 
            // txtSeccion
            // 
            this.txtSeccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtSeccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtSeccion.BorderFocusColor = System.Drawing.Color.White;
            this.txtSeccion.BorderSize = 4;
            this.txtSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccion.ForeColor = System.Drawing.Color.White;
            this.txtSeccion.Location = new System.Drawing.Point(256, 344);
            this.txtSeccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSeccion.Multiline = false;
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Names = "txtNombre";
            this.txtSeccion.Padding = new System.Windows.Forms.Padding(7);
            this.txtSeccion.PasswordChar = false;
            this.txtSeccion.Size = new System.Drawing.Size(210, 35);
            this.txtSeccion.TabIndex = 4;
            this.txtSeccion.Texts = "";
            this.txtSeccion.UnderlinedStyle = true;
            // 
            // txtGrado
            // 
            this.txtGrado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtGrado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtGrado.BorderFocusColor = System.Drawing.Color.White;
            this.txtGrado.BorderSize = 4;
            this.txtGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.ForeColor = System.Drawing.Color.White;
            this.txtGrado.Location = new System.Drawing.Point(24, 344);
            this.txtGrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrado.Multiline = false;
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Names = "txtNombre";
            this.txtGrado.Padding = new System.Windows.Forms.Padding(7);
            this.txtGrado.PasswordChar = false;
            this.txtGrado.Size = new System.Drawing.Size(210, 35);
            this.txtGrado.TabIndex = 3;
            this.txtGrado.Texts = "";
            this.txtGrado.UnderlinedStyle = true;
            // 
            // txtAnio
            // 
            this.txtAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtAnio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtAnio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAnio.BorderSize = 4;
            this.txtAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.ForeColor = System.Drawing.Color.White;
            this.txtAnio.Location = new System.Drawing.Point(256, 552);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnio.Multiline = false;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Names = "txtAnio";
            this.txtAnio.Padding = new System.Windows.Forms.Padding(7);
            this.txtAnio.PasswordChar = false;
            this.txtAnio.Size = new System.Drawing.Size(210, 35);
            this.txtAnio.TabIndex = 17;
            this.txtAnio.Texts = "";
            this.txtAnio.UnderlinedStyle = true;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtApellido.BorderFocusColor = System.Drawing.Color.White;
            this.txtApellido.BorderSize = 4;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(24, 184);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Names = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(440, 35);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(168)))), ((int)(((byte)(52)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.White;
            this.txtNombre.BorderSize = 4;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(24, 104);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Names = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.Size = new System.Drawing.Size(440, 35);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = true;
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(968, 600);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.lblEncargado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtTelefonoEncargado);
            this.Controls.Add(this.txtParentesco);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefonoEncargado);
            this.Controls.Add(this.lblParentesco);
            this.Controls.Add(this.lblFechaInscripcion);
            this.Controls.Add(this.dtFechaInscripcion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AcTextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private Controls.AcTextBox txtApellido;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblApellido;
        private Controls.AcTextBox txtAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblSeccion;
        private Controls.AcTextBox txtGrado;
        private Controls.AcTextBox txtSeccion;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblGenero;
        private Controls.AcTextBox txtGenero;
        private Controls.AcTextBox txtEdad;
        private System.Windows.Forms.Label lblTelefonoEncargado;
        private System.Windows.Forms.Label lblParentesco;
        private System.Windows.Forms.Label lblFechaInscripcion;
        private System.Windows.Forms.DateTimePicker dtFechaInscripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private Controls.AcTextBox txtDireccion;
        private Controls.AcTextBox txtTelefono;
        private Controls.AcTextBox txtTelefonoEncargado;
        private Controls.AcTextBox txtParentesco;
        private System.Windows.Forms.ComboBox cbEstado;
        private Controls.AcButton btnGuardar;
        private Controls.AcTextBox txtEncargado;
        private System.Windows.Forms.Label lblEncargado;
        private Controls.AcTextBox txtObservaciones;
    }
}