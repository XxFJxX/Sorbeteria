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
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            txt = new TextBox();
            button7 = new Button();
            label4 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl6 = new Label();
            lbl5 = new Label();
            lblt = new Label();
            lbl06 = new Label();
            lbl05 = new Label();
            lbl04 = new Label();
            lbl03 = new Label();
            lbl02 = new Label();
            lbl01 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 35);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 92);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Articulo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 32);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(204, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(348, 81);
            button1.Name = "button1";
            button1.Size = new Size(37, 37);
            button1.TabIndex = 6;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(391, 81);
            button2.Name = "button2";
            button2.Size = new Size(37, 37);
            button2.TabIndex = 7;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(14, 369);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(96, 369);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Imprimir";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(177, 369);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 10;
            button5.Text = "Grabar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(353, 369);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 11;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-Wafle", "-Wafle Doble", "-Chocowafle", "-Chovcowafle Doble", "-Chocowafle Especial", "-Chocowafle Especial Doble" });
            comboBox1.Location = new Point(106, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(361, 139);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(84, 23);
            textBox4.TabIndex = 14;
            textBox4.Text = " Total";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(258, 139);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(108, 23);
            textBox5.TabIndex = 15;
            textBox5.Text = "Cantidad";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(2, 139);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(257, 23);
            textBox6.TabIndex = 16;
            textBox6.Text = "Descripcion";
            // 
            // txt
            // 
            txt.Location = new Point(308, 93);
            txt.Name = "txt";
            txt.Size = new Size(30, 23);
            txt.TabIndex = 17;
            // 
            // button7
            // 
            button7.Location = new Point(258, 369);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 18;
            button7.Text = "Total";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(321, 329);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 19;
            label4.Text = "Total";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(71, 165);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 15);
            lbl1.TabIndex = 20;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(71, 189);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(0, 15);
            lbl2.TabIndex = 21;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(71, 239);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(0, 15);
            lbl4.TabIndex = 23;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(71, 215);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(0, 15);
            lbl3.TabIndex = 22;
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(71, 288);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(0, 15);
            lbl6.TabIndex = 25;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(71, 264);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(0, 15);
            lbl5.TabIndex = 24;
            // 
            // lblt
            // 
            lblt.AutoSize = true;
            lblt.Location = new Point(378, 318);
            lblt.Name = "lblt";
            lblt.Size = new Size(28, 15);
            lblt.TabIndex = 32;
            lblt.Text = "0.00";
            // 
            // lbl06
            // 
            lbl06.AutoSize = true;
            lbl06.Location = new Point(275, 288);
            lbl06.Name = "lbl06";
            lbl06.Size = new Size(0, 15);
            lbl06.TabIndex = 38;
            // 
            // lbl05
            // 
            lbl05.AutoSize = true;
            lbl05.Location = new Point(275, 264);
            lbl05.Name = "lbl05";
            lbl05.Size = new Size(0, 15);
            lbl05.TabIndex = 37;
            // 
            // lbl04
            // 
            lbl04.AutoSize = true;
            lbl04.Location = new Point(275, 239);
            lbl04.Name = "lbl04";
            lbl04.Size = new Size(0, 15);
            lbl04.TabIndex = 36;
            // 
            // lbl03
            // 
            lbl03.AutoSize = true;
            lbl03.Location = new Point(275, 215);
            lbl03.Name = "lbl03";
            lbl03.Size = new Size(0, 15);
            lbl03.TabIndex = 35;
            // 
            // lbl02
            // 
            lbl02.AutoSize = true;
            lbl02.Location = new Point(275, 189);
            lbl02.Name = "lbl02";
            lbl02.Size = new Size(0, 15);
            lbl02.TabIndex = 34;
            // 
            // lbl01
            // 
            lbl01.AutoSize = true;
            lbl01.Location = new Point(275, 165);
            lbl01.Name = "lbl01";
            lbl01.Size = new Size(0, 15);
            lbl01.TabIndex = 33;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 409);
            Controls.Add(lbl06);
            Controls.Add(lbl05);
            Controls.Add(lbl04);
            Controls.Add(lbl03);
            Controls.Add(lbl02);
            Controls.Add(lbl01);
            Controls.Add(lblt);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(txt);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txt;
        private Button button7;
        private Label label4;
        private Label lbl1;
        private Label lbl2;
        private Label lbl4;
        private Label lbl3;
        private Label lbl6;
        private Label lbl5;
        private Label lblt;
        private Label lbl06;
        private Label lbl05;
        private Label lbl04;
        private Label lbl03;
        private Label lbl02;
        private Label lbl01;
    }
}