namespace OPERACIONES_interfaz
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
            btn_limpiar = new Button();
            btn_salir = new Button();
            label2 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            txt_valor2 = new Label();
            txt_resultado = new Label();
            txt_resta = new Label();
            text_resta = new TextBox();
            txt_multiplicacion = new Label();
            text_multiplicacion = new TextBox();
            btn_calcular = new Button();
            txt_division = new Label();
            text_division = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Linen;
            btn_limpiar.BackgroundImage = (Image)resources.GetObject("btn_limpiar.BackgroundImage");
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_limpiar.ForeColor = SystemColors.ControlLightLight;
            btn_limpiar.Location = new Point(758, 490);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(151, 46);
            btn_limpiar.TabIndex = 2;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click_1;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Linen;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Center;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_salir.ForeColor = SystemColors.ButtonHighlight;
            btn_salir.Location = new Point(770, 37);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(151, 46);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click_1;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.TitleBar;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(237, 237, 237);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(23, 32, 38);
            label2.Location = new Point(417, 123);
            label2.Name = "label2";
            label2.Size = new Size(113, 43);
            label2.TabIndex = 5;
            label2.Text = "Valor1";
            // 
            // txt1
            // 
            txt1.Location = new Point(395, 189);
            txt1.Name = "txt1";
            txt1.Size = new Size(152, 27);
            txt1.TabIndex = 7;
            // 
            // txt2
            // 
            txt2.Location = new Point(395, 284);
            txt2.Name = "txt2";
            txt2.Size = new Size(152, 27);
            txt2.TabIndex = 8;
            // 
            // txt3
            // 
            txt3.Location = new Point(291, 363);
            txt3.Name = "txt3";
            txt3.Size = new Size(133, 27);
            txt3.TabIndex = 9;
            // 
            // txt_valor2
            // 
            txt_valor2.AutoSize = true;
            txt_valor2.BackColor = Color.FromArgb(237, 237, 237);
            txt_valor2.FlatStyle = FlatStyle.Flat;
            txt_valor2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txt_valor2.ForeColor = Color.FromArgb(23, 32, 38);
            txt_valor2.Location = new Point(417, 229);
            txt_valor2.Name = "txt_valor2";
            txt_valor2.Size = new Size(111, 41);
            txt_valor2.TabIndex = 15;
            txt_valor2.Text = "Valor2";
            // 
            // txt_resultado
            // 
            txt_resultado.AutoSize = true;
            txt_resultado.BackColor = Color.FromArgb(237, 237, 237);
            txt_resultado.FlatStyle = FlatStyle.Flat;
            txt_resultado.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_resultado.ForeColor = Color.FromArgb(23, 32, 38);
            txt_resultado.Location = new Point(109, 350);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(148, 40);
            txt_resultado.TabIndex = 16;
            txt_resultado.Text = "Resultado";
            // 
            // txt_resta
            // 
            txt_resta.AutoSize = true;
            txt_resta.BackColor = Color.FromArgb(237, 237, 237);
            txt_resta.FlatStyle = FlatStyle.Flat;
            txt_resta.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_resta.ForeColor = Color.FromArgb(23, 32, 38);
            txt_resta.Location = new Point(153, 400);
            txt_resta.Name = "txt_resta";
            txt_resta.Size = new Size(94, 40);
            txt_resta.TabIndex = 17;
            txt_resta.Text = "Resta";
            // 
            // text_resta
            // 
            text_resta.Location = new Point(291, 411);
            text_resta.Name = "text_resta";
            text_resta.Size = new Size(133, 27);
            text_resta.TabIndex = 18;
            // 
            // txt_multiplicacion
            // 
            txt_multiplicacion.AutoSize = true;
            txt_multiplicacion.BackColor = Color.FromArgb(237, 237, 237);
            txt_multiplicacion.FlatStyle = FlatStyle.Flat;
            txt_multiplicacion.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_multiplicacion.ForeColor = Color.FromArgb(23, 32, 38);
            txt_multiplicacion.Location = new Point(56, 450);
            txt_multiplicacion.Name = "txt_multiplicacion";
            txt_multiplicacion.Size = new Size(191, 40);
            txt_multiplicacion.TabIndex = 19;
            txt_multiplicacion.Text = "Multipicacion";
            // 
            // text_multiplicacion
            // 
            text_multiplicacion.Location = new Point(291, 463);
            text_multiplicacion.Name = "text_multiplicacion";
            text_multiplicacion.Size = new Size(133, 27);
            text_multiplicacion.TabIndex = 20;
            // 
            // btn_calcular
            // 
            btn_calcular.BackColor = Color.Linen;
            btn_calcular.BackgroundImage = (Image)resources.GetObject("btn_calcular.BackgroundImage");
            btn_calcular.FlatStyle = FlatStyle.Flat;
            btn_calcular.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_calcular.ForeColor = SystemColors.ControlLightLight;
            btn_calcular.Location = new Point(758, 244);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(151, 46);
            btn_calcular.TabIndex = 21;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txt_division
            // 
            txt_division.AutoSize = true;
            txt_division.BackColor = Color.FromArgb(237, 237, 237);
            txt_division.FlatStyle = FlatStyle.Flat;
            txt_division.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txt_division.ForeColor = Color.FromArgb(23, 32, 38);
            txt_division.Location = new Point(128, 503);
            txt_division.Name = "txt_division";
            txt_division.Size = new Size(119, 40);
            txt_division.TabIndex = 22;
            txt_division.Text = "Division";
            // 
            // text_division
            // 
            text_division.Location = new Point(291, 516);
            text_division.Name = "text_division";
            text_division.Size = new Size(133, 27);
            text_division.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(95, 205, 217);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(175, 29);
            label4.Name = "label4";
            label4.Size = new Size(558, 53);
            label4.TabIndex = 25;
            label4.Text = "Calcular_Operaciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 190, 177);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 577);
            Controls.Add(label4);
            Controls.Add(text_division);
            Controls.Add(txt_division);
            Controls.Add(btn_calcular);
            Controls.Add(text_multiplicacion);
            Controls.Add(txt_multiplicacion);
            Controls.Add(text_resta);
            Controls.Add(txt_resta);
            Controls.Add(txt_resultado);
            Controls.Add(txt_valor2);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(btn_salir);
            Controls.Add(btn_limpiar);
            DoubleBuffered = true;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_limpiar;
        private Button btn_salir;
        private Label label2;
        private TextBox txt1;
        private TextBox txt2;
        private Label txt_valor2;
        private Label txt_resultado;
        protected TextBox txt3;
        private Label txt_resta;
        protected TextBox text_resta;
        private Label txt_multiplicacion;
        protected TextBox text_multiplicacion;
        private Button btn_calcular;
        private Label txt_division;
        protected TextBox text_division;
        private Label label4;
    }
}
