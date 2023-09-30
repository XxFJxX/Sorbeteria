namespace test
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnsalir = new Button();
            btnModificar = new Button();
            btnCalcular = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 56);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(196, 92);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BUSCAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 145);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 203);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "PRODUCTO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(213, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 249);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 7;
            label4.Text = "CANTIDAD";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(216, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 288);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "PRECIO";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(458, 78);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(569, 78);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(458, 137);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 12;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(569, 137);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(93, 23);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(458, 220);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 23);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "CalcularTotal";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(215, 286);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(457, 249);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 16;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(509, 174);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 17;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 503);
            Controls.Add(btnBorrar);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(btnCalcular);
            Controls.Add(btnModificar);
            Controls.Add(btnsalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnBuscar;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnsalir;
        private Button btnModificar;
        private Button btnCalcular;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnBorrar;
    }
}