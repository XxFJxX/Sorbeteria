namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCerrar = new Button();
            btnfactura = new Button();
            btnInicio = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtTitulo = new Label();
            txtU = new Label();
            txtC = new Label();
            txbU = new TextBox();
            txbC = new TextBox();
            btnDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(12, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 23);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Visible = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnfactura
            // 
            btnfactura.Location = new Point(429, 232);
            btnfactura.Name = "btnfactura";
            btnfactura.Size = new Size(109, 24);
            btnfactura.TabIndex = 1;
            btnfactura.Text = "Imprimir factura";
            btnfactura.UseVisualStyleBackColor = true;
            btnfactura.Visible = false;
            btnfactura.Click += btnfactura_Click;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(230, 314);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 23);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Iniciar Sesion";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(336, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(355, 25);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(232, 33);
            txtTitulo.TabIndex = 5;
            txtTitulo.Text = "Sorbetería Riki´s";
            // 
            // txtU
            // 
            txtU.AutoSize = true;
            txtU.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtU.Location = new Point(119, 202);
            txtU.Name = "txtU";
            txtU.Size = new Size(163, 25);
            txtU.TabIndex = 6;
            txtU.Text = "Ingrese Usuario";
            // 
            // txtC
            // 
            txtC.AutoSize = true;
            txtC.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(92, 247);
            txtC.Name = "txtC";
            txtC.Size = new Size(200, 25);
            txtC.TabIndex = 7;
            txtC.Text = "Ingrese Contraseña";
            // 
            // txbU
            // 
            txbU.Location = new Point(288, 208);
            txbU.Name = "txbU";
            txbU.Size = new Size(118, 23);
            txbU.TabIndex = 8;
            // 
            // txbC
            // 
            txbC.Location = new Point(298, 252);
            txbC.Name = "txbC";
            txbC.Size = new Size(108, 23);
            txbC.TabIndex = 9;
            txbC.UseSystemPasswordChar = true;
            // 
            // btnDatos
            // 
            btnDatos.Location = new Point(12, 307);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(94, 44);
            btnDatos.TabIndex = 10;
            btnDatos.Text = "Registro de Datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Visible = false;
            btnDatos.Click += btnDatos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 363);
            Controls.Add(btnDatos);
            Controls.Add(txbC);
            Controls.Add(txbU);
            Controls.Add(txtC);
            Controls.Add(txtU);
            Controls.Add(txtTitulo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnInicio);
            Controls.Add(btnfactura);
            Controls.Add(btnCerrar);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnfactura;
        private Button btnInicio;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label txtTitulo;
        private Label txtU;
        private Label txtC;
        private TextBox txbU;
        private TextBox txbC;
        private Button btnDatos;
    }
}